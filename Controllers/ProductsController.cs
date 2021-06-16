using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CCJShop.Context;
using CCJShop.Models;
using System.Drawing;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CCJShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductContext _context;
        private readonly IHostingEnvironment hostingEnvironment;
        public ProductsController(ProductContext context, IHostingEnvironment _hostingEnvironment)
        {
            _context = context;
            hostingEnvironment = _hostingEnvironment;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var m = new List<ProductViewModel>();
            foreach (var it in _context.Product.Where(w => w.Status == 1))
            {
                var prodColor = _context.ProductColor.Where(w => w.ProductId == it.ProductId).ToList();
                var prodSize = _context.ProductSize.Where(w => w.ProductId == it.ProductId).ToList();
                var prodImg = _context.ProductImg.Where(w => w.ProductId == it.ProductId).ToList();
                m.Add(new ProductViewModel { Product = it, ProductColorList = prodColor, ProductSizeList = prodSize, ProductImgList = prodImg });
            }
            return View(m);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var m = new ProductViewModel();
            var product = await _context.Product.FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            m.Product = product;
            m.ProductColorList = _context.ProductColor.Where(w => w.ProductId == id).ToList();
            m.ProductSizeList = _context.ProductSize.Where(w => w.ProductId == id).ToList();
            m.ProductImgList = _context.ProductImg.Where(w => w.ProductId == id).ToList();
            return View(m);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create([FromBody] ProductViewModel productView)
        {
            ReturnMsg retMsg = new ReturnMsg();
            if (!ModelState.IsValid)
            {
                retMsg.Success = false;
                retMsg.Msg = "新增失敗!資料驗證失敗!";
                retMsg.ValidationItemList = new List<ValidationItem>();

                bool SizeValidation = true;//尺碼檢核Flag( true:檢核通過 false:檢核失敗(有任一筆為空就失敗) )

                foreach (var item in ModelState.ToList())
                {
                    string errmsg = "";
                    if (item.Key.StartsWith("ProductSizeList"))
                    {
                        SizeValidation = false;
                    }
                    else
                    {
                        for (int i = 0; i < item.Value.Errors.Count; i++)
                        {
                            errmsg += item.Value.Errors[i].ErrorMessage;
                            if (i != 0) errmsg += "<br>";
                        }
                        retMsg.ValidationItemList.Add(new ValidationItem { Key = item.Key.ToString(), Msg = errmsg });
                    }
                }

                //尺碼驗證失敗增加一筆尺碼失敗訊息
                if (!SizeValidation) 
                {
                    retMsg.ValidationItemList.Add(new ValidationItem { Key = "ProductSizeList", Msg = "<br>尺碼不可為空，請刪除或填寫資料" });
                }

                return Json(new { ret = retMsg });
            }
            try
            {
                Product p = new Product();
                p = productView.Product;
                p.CDT = DateTime.Now;
                p.MDT = DateTime.Now;
                p.ProductColor = new List<ProductColor>();
                p.ProductSize = new List<ProductSize>();
                p.ProductImg = new List<ProductImg>();

                foreach (ProductColor pc in productView.ProductColorList)
                {
                    pc.CDT = DateTime.Now;
                    pc.MDT = DateTime.Now;
                    p.ProductColor.Add(pc);
                }

                foreach (ProductSize ps in productView.ProductSizeList)
                {
                    ps.CDT = DateTime.Now;
                    ps.MDT = DateTime.Now;
                    p.ProductSize.Add(ps);
                }

                foreach (ProductImg pm in productView.ProductImgList)
                {
                    string fileName = "";
                    string PathStr = "";
                    if (!SaveImage(pm.ImgName, ref fileName, ref PathStr))
                    {
                        throw new Exception("圖片儲存失敗!");
                    }
                    ProductImg newPm = new ProductImg();
                    newPm.CDT = DateTime.Now;
                    newPm.MDT = DateTime.Now;
                    newPm.ImgName = fileName;
                    newPm.ImgPath = PathStr;
                    newPm.ProductColorId = 0;
                    p.ProductImg.Add(newPm);
                }

                _context.Product.Add(p);
                await _context.SaveChangesAsync();
                retMsg.Success = true;
                retMsg.Msg = "新增成功!";
                return Json(new { ret = retMsg });
            }
            catch (Exception ex)
            {
                retMsg.Success = false;
                retMsg.Msg = "新增失敗:" + ex.Message.ToString();
                return Json(new { ret = retMsg });
            }
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductViewModel vm = new ProductViewModel();
            vm.Product = _context.Product.FirstOrDefault(f => f.ProductId == id);
            if (vm.Product == null)
            {
                return NotFound();
            }
            vm.ProductColorList = _context.ProductColor.Where(w => w.ProductId == id).ToList();
            vm.ProductSizeList = _context.ProductSize.Where(w => w.ProductId == id).ToList();
            vm.ProductImgList = new List<ProductImg>();
            foreach (ProductImg p in _context.ProductImg.Where(w => w.ProductId == id).ToList())
            {
                p.ImgName = "data:image/jpeg;base64," + ImgToBase64String(hostingEnvironment.WebRootPath + p.ImgPath + p.ImgName);
                vm.ProductImgList.Add(p);
            }
            return View(vm);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Name,Descript,Price,Status,CDT,MDT")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ReturnMsg retMsg = new ReturnMsg();
            try
            {
                if (id == null)
                {
                    throw new Exception("商品序號錯誤，請重新選取");
                }

                var product = await _context.Product
                    .FirstOrDefaultAsync(m => m.ProductId == id);

                if (product == null)
                {
                    throw new Exception("查無商品資料，請重新選取");
                }

                retMsg.Msg = "<h5>" + product.Name + "</h5><p>$" + product.Price + "</p>";
                var ProdSize = _context.ProductSize.Where(w => w.ProductId == id);
                var ProdColor = _context.ProductColor.Where(w => w.ProductId == id);
                var ProdImg = _context.ProductImg.Where(w => w.ProductId == id);

                foreach (ProductSize ps in ProdSize)
                {
                    _context.ProductSize.Remove(ps);
                }
                foreach (ProductColor pc in ProdColor)
                {
                    _context.ProductColor.Remove(pc);
                }
                foreach (ProductImg pm in ProdImg)
                {
                    var fullPathFileName = hostingEnvironment.WebRootPath + pm.ImgPath.Replace("/", "\\") + pm.ImgName;
                    if (System.IO.File.Exists(fullPathFileName))
                    {
                        System.IO.File.Delete(fullPathFileName);
                    }
                    _context.ProductImg.Remove(pm);
                }
                _context.Product.Remove(product);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                retMsg.Msg = ex.Message.ToString();
                return View(retMsg);
            }

            retMsg.Msg += "<p>已刪除</p>";
            return View(retMsg);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
        public bool SaveImage(string base64image, ref string fileName, ref string PathStr)
        {
            try
            {
                if (string.IsNullOrEmpty(base64image))
                {
                    fileName = "";
                    PathStr = "";
                    return false;
                }

                var t = base64image.Substring(23);  // remove data:image/jpeg;base64,
                byte[] bytes = Convert.FromBase64String(t);
                var randomFileName = Guid.NewGuid().ToString().Substring(0, 6) + ".jpg";
                var fullPath = Path.Combine(hostingEnvironment.WebRootPath + "\\Image\\", randomFileName);
                while (System.IO.File.Exists(fullPath))
                {
                    randomFileName = Guid.NewGuid().ToString().Substring(0, 6) + ".jpg";
                    fullPath = Path.Combine(hostingEnvironment.WebRootPath + "\\Image\\", randomFileName);
                }
                MemoryStream ms = new MemoryStream(bytes);
                Bitmap bmp = new Bitmap(ms);

                bmp.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                //bmp.Save("test.bmp", ImageFormat.Bmp);
                //bmp.Save("test.gif", ImageFormat.Gif);
                //bmp.Save("test.png", ImageFormat.Png);
                ms.Close();

                fileName = randomFileName;
                PathStr = "/Image/";
                return true;
            }
            catch (Exception ex)
            {
                fileName = "";
                PathStr = "";
                return false;
            }
        }
        protected string ImgToBase64String(string Imagefilename)
        {
            try
            {
                Bitmap bmp = new Bitmap(Imagefilename);

                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
