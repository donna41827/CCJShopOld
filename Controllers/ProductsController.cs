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
using Microsoft.AspNetCore.Http;
using System.Text.Json;

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
        public async Task<IActionResult> Index(int? Status)
        {
            var m = new List<ProductViewModel>();
            foreach (var it in _context.Product.Where(w => w.Status == (Status == null ? 1 : Status)))
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
        public async Task<IActionResult> Create([FromForm] ProductPostReqViewModel productViewOrg)//[FromBody] ProductViewModel productView
        {
            ProductViewModel productView = new ProductViewModel();
            productView = JsonSerializer.Deserialize<ProductViewModel>(productViewOrg.ProductPostReqViewModelFormStr);
            productView.VideoFile = productViewOrg.VideoFile;
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
                p.ProductVideo = new List<ProductVideo>();

                AddProductDetails(productView, productViewOrg.FileReUpload, ref p);

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
            vm.Product.Memo = vm.Product.Memo.Replace("<br>", "\n");
            vm.ProductColorList = _context.ProductColor.Where(w => w.ProductId == id).ToList();
            vm.ProductSizeList = _context.ProductSize.Where(w => w.ProductId == id).ToList();
            vm.ProductImgList = new List<ProductImg>();
            foreach (ProductImg p in _context.ProductImg.Where(w => w.ProductId == id).ToList())
            {
                p.ImgName = "data:image/jpeg;base64," + ImgToBase64String(hostingEnvironment.WebRootPath + p.ImgPath + p.ImgName);
                vm.ProductImgList.Add(p);
            }
            vm.ProductVideoList = _context.ProductVideo.Where(w => w.ProductId == id).ToList();
            return View(vm);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Edit([FromForm] ProductPostReqViewModel productViewOrg)
        {
            ProductViewModel productView = new ProductViewModel();
            productView = JsonSerializer.Deserialize<ProductViewModel>(productViewOrg.ProductPostReqViewModelFormStr);
            productView.VideoFile = productViewOrg.VideoFile;
            ReturnMsg retMsg = new ReturnMsg();
            if (!ModelState.IsValid)
            {
                retMsg.Success = false;
                retMsg.Msg = "修改失敗!資料驗證失敗!";
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
                int id = productView.Product.ProductId;
                Product p = _context.Product.FirstOrDefault(f => f.ProductId == id);

                RemoveProductDetails(productView.Product.ProductId, productViewOrg.FileReUpload);

                p.Name = productView.Product.Name;
                p.Memo = productView.Product.Memo;
                p.Price = productView.Product.Price;
                p.Status = productView.Product.Status;
                p.MDT = DateTime.Now;

                p.ProductColor = new List<ProductColor>();
                p.ProductSize = new List<ProductSize>();
                p.ProductImg = new List<ProductImg>();
                p.ProductVideo = new List<ProductVideo>();
                AddProductDetails(productView, productViewOrg.FileReUpload, ref p);

                _context.Update(p);

                await _context.SaveChangesAsync();

                retMsg.Success = true;
                retMsg.Msg = "修改成功!";
                return Json(new { ret = retMsg });
            }
            catch (Exception ex)
            {
                retMsg.Success = false;
                retMsg.Msg = "修改失敗:" + ex.Message.ToString();
                return Json(new { ret = retMsg });
            }
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

                RemoveProductDetails(id, true);

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
        private bool SaveVideo(IFormFile f, ref string fileName, ref string PathStr)
        {
            bool ret = false;
            fileName = "";
            PathStr = "";
            try
            {
                var randomFileName = Guid.NewGuid().ToString().Substring(0, 6) + Path.GetExtension(f.FileName);
                var fullPath = Path.Combine(hostingEnvironment.WebRootPath + "\\Video\\", randomFileName);

                using (Stream fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    f.CopyTo(fileStream);
                }
                fileName = randomFileName;
                PathStr = "/Video/";
                ret = true;
            }
            catch (Exception ex)
            {
                fileName = "";
                PathStr = "";
                ret = false;
            }
            return ret;
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
        private void RemoveProductDetails(int? id, bool VideoReUpload)
        {
            var ProdSize = _context.ProductSize.Where(w => w.ProductId == id);
            var ProdColor = _context.ProductColor.Where(w => w.ProductId == id);
            var ProdImg = _context.ProductImg.Where(w => w.ProductId == id);
            var ProdVideo = _context.ProductVideo.Where(w => w.ProductId == id);

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
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    System.IO.File.Delete(fullPathFileName);
                }
                _context.ProductImg.Remove(pm);
            }
            if (VideoReUpload)
            {
                foreach (ProductVideo pv in ProdVideo)
                {
                    var fullPathFileName = hostingEnvironment.WebRootPath + pv.VideoPath.Replace("/", "\\") + pv.VideoName;
                    if (System.IO.File.Exists(fullPathFileName))
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        System.IO.File.Delete(fullPathFileName);
                    }
                    _context.ProductVideo.Remove(pv);
                }
            }
        }
        private void AddProductDetails(ProductViewModel productView, bool VideoReUpload, ref Product p)
        {
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

            string fileName = "";
            string PathStr = "";

            foreach (ProductImg pm in productView.ProductImgList)
            {
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
            if (VideoReUpload)
            {
                if (productView.VideoFile != null)
                {
                    if (!SaveVideo(productView.VideoFile, ref fileName, ref PathStr))
                    {
                        throw new Exception("影片儲存失敗!");
                    }
                    ProductVideo newVf = new ProductVideo();
                    newVf.CDT = DateTime.Now;
                    newVf.MDT = DateTime.Now;
                    newVf.VideoName = fileName;
                    newVf.VideoPath = PathStr;
                    p.ProductVideo.Add(newVf);
                }
            }
        }

    }
}
