using CCJShop.Validation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCJShop.Models
{
    public class Product
    {
		/// <summary>
		/// 商品流水號
		/// </summary>
		public int ProductId { get; set; }
		/// <summary>
		/// 商品名稱
		/// </summary>
		[Display(Name = "商品名稱")]
		[Required(ErrorMessage ="商品名稱不可為空")]
		public string Name { get; set; }
		/// <summary>
		/// 商品描述
		/// </summary>
		[Display(Name = "商品描述")]
		public string Memo { get; set; }
		/// <summary>
		/// 商品售價
		/// </summary>
		[Display(Name = "商品售價")]
		[Required(ErrorMessage ="商品售價不可為空")]
		[Range(1,100000,ErrorMessage ="商品售價須為正整數")]
		public int Price { get; set; }
		/// <summary>
		/// 商品狀態:0暫存 1上架中
		/// </summary>
		[Display(Name = "商品狀態")]
		[Required(ErrorMessage ="請選擇商品狀態")]
		public int Status { get; set; }
		/// <summary>
		/// 商品資料建立時間
		/// </summary>
		public DateTime CDT { get; set; }
		/// <summary>
		/// 商品資料最後修改時間
		/// </summary>
		public DateTime MDT { get; set; }
		public virtual ICollection<ProductColor> ProductColor { get; set; }
		public virtual ICollection<ProductSize> ProductSize { get; set; }
		public virtual ICollection<ProductImg> ProductImg { get; set; }
		public virtual ICollection<ProductVideo> ProductVideo { get; set; }
	}
	public class ProductColor 
	{
		/// <summary>
		/// 商品顏色流水號
		/// </summary>
		public int ProductColorId { get; set; }
		/// <summary>
		/// 對應商品流水號(Product.ProductId)
		/// </summary>
		public int ProductId { get; set; }
		/// <summary>
		/// 色碼
		/// </summary>
		[Display(Name = "顏色")]
		public string ColorCode { get; set; }
		/// <summary>
		/// 顏色名稱
		/// </summary>
		public string ColorName { get; set; }
		/// <summary>
		/// 增減售價
		/// </summary>
		public int AddPrice { get; set; }
		/// <summary>
		/// 商品顏色資料建立時間
		/// </summary>
		public DateTime CDT { get; set; }
		/// <summary>
		/// 商品顏色資料最後修改時間
		/// </summary>
		public DateTime MDT { get; set; }
		public virtual Product Product { get; set; }
	}
	public class ProductSize 
	{
		/// <summary>
		/// 商品尺碼流水號
		/// </summary>
		public int ProductSizeId { get; set; }
		/// <summary>
		/// 對應商品流水號(Product.ProductId)
		/// </summary>
		public int ProductId { get; set; }
		/// <summary>
		/// 尺碼
		/// </summary>
		[Display(Name = "尺碼")]
		[Required(ErrorMessage ="請填寫尺碼")]
		public string SizeCode { get; set; }
		/// <summary>
		/// 尺寸描述
		/// </summary>
		[Display(Name = "尺寸描述")]
		[Required(ErrorMessage = "請填寫尺碼描述")]
		public string SizeMemo { get; set; }
		/// <summary>
		/// 增減售價
		/// </summary>
		public int AddPrice { get; set; }
		/// <summary>
		/// 商品尺碼資料建立時間
		/// </summary>
		public DateTime CDT { get; set; }
		/// <summary>
		/// 商品尺碼資料最後修改時間
		/// </summary>
		public DateTime MDT { get; set; }
		public virtual Product Product { get; set; }
	}
	public class ProductImg
    {
		/// <summary>
		/// 商品圖片流水號
		/// </summary>
		public int ProductImgId { get; set; }
		/// <summary>
		/// 商品圖片檔案路徑
		/// </summary>
		public string ImgPath { get; set; }
		/// <summary>
		/// 商品圖片檔案名稱
		/// </summary>
		public string ImgName { get; set; }
		/// <summary>
		/// 對應商品流水號(選取顏色顯示圖檔)
		/// </summary>
		public int ProductId { get; set; }
		/// <summary>
		/// 對應商品顏色流水號(選取顏色顯示圖檔)
		/// </summary>
		public int ProductColorId { get; set; }
		/// <summary>
		/// 商品圖片資料建立時間
		/// </summary>
		public DateTime CDT { get; set; }
		/// <summary>
		/// 商品圖片資料最後修改時間
		/// </summary>
		public DateTime MDT { get; set; }
		public virtual Product Product { get; set; }
	}
	public class ProductVideo
	{
		/// <summary>
		/// 商品影片流水號
		/// </summary>
		public int ProductVideoId { get; set; }
		/// <summary>
		/// 商品影片檔案路徑
		/// </summary>
		public string VideoPath { get; set; }
		/// <summary>
		/// 商品影片檔案名稱
		/// </summary>
		public string VideoName { get; set; }
		/// <summary>
		/// 對應商品流水號(選取顏色顯示圖檔)
		/// </summary>
		public int ProductId { get; set; }
		/// <summary>
		/// 商品影片資料建立時間
		/// </summary>
		public DateTime CDT { get; set; }
		/// <summary>
		/// 商品影片資料最後修改時間
		/// </summary>
		public DateTime MDT { get; set; }
		public virtual Product Product { get; set; }
	}
	public class ProductViewModel 
	{
		/// <summary>
		/// 商品
		/// </summary>
		public Product Product { get; set; }
		/// <summary>
		/// 商品狀態
		/// </summary>
		public Status Status { get; set; }
		/// <summary>
		/// 上傳影片檔案
		/// </summary>
		public IFormFile VideoFile { get; set; }
		/// <summary>
		/// 商品顏色
		/// </summary>
		public List<ProductColor> ProductColorList { get; set; }
		/// <summary>
		/// 商品尺碼
		/// </summary>
		public List<ProductSize> ProductSizeList { get; set; }
		/// <summary>
		/// 商品圖片
		/// </summary>
		[RequiredCollection(ErrorMessage = "至少需上傳一張圖片")]
		public List<ProductImg> ProductImgList { get; set; }
		/// <summary>
		/// 商品影片
		/// </summary>
		public List<ProductVideo> ProductVideoList { get; set; }
	}
	public class ProductPostReqViewModel 
	{
		/// <summary>
		/// AJAX POST其他欄位JSON字串
		/// </summary>
		public string ProductPostReqViewModelFormStr { get; set; }
		/// <summary>
		/// 影片檔案是否異動(true:異動(刪除或重新上傳,false:沒異動，不刪除原有影片資料))
		/// </summary>
		public bool FileReUpload { get; set; }
		/// <summary>
		/// 上傳影片檔案
		/// </summary>
		public IFormFile VideoFile { get; set; }
	}
	/// <summary>
	/// 商品狀態
	/// </summary>
	public enum Status
	{
		暫存=0,
		上架中=1
	}
}
