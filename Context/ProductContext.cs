using CCJShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCJShop.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "個性渲染絲絨連身裙", Memo = "內搭竹節T真的很好穿！<br>忽冷忽熱的時候都可以搭配到 非常親膚<br>整套搭配Claire自留<br>渲染洋裝多層次穿搭百摺裙 讓整體更有變化<br>比較偏一點點日系的搭配法<br>洋裝不能調肩帶唷！<br>但是材質有彈性 穿起來一樣親膚不刺癢", Price = 560, Status = 1 },
                new Product { ProductId = 2, Name = "個性不規則工裝長裙", Memo = "不規則長裙非常能多層次穿搭<br>黑色最為首選<br>也可以簡單搭個毛衣或是素上衣單品<br>分三個尺寸", Price = 499, Status = 1 },
                new Product { ProductId = 3, Name = "圓領素面背心含口袋洋裝", Memo = "熱賣款短款洋裝<br>厚度適中 所以白色不太會透喔！總共黑白兩色<br>而且還有口袋 非常方便～<br>認真很多人包色的款<br>不過闆娘夏天搭淺色衣服裡面幾乎都穿「膚色」內搭", Price = 499, Status = 1 },
                new Product { ProductId = 4, Name = "涼爽款可調肩蛋糕洋裝", Memo = "可甜可鹹的蓁蓁<br>洋裝不是棉麻材質是偏涼爽材質<br>顏色很亮真的超美 可以背心內搭或是穿短袖長袖<br>所以可以一路穿到秋冬", Price = 499, Status = 1 },
                new Product { ProductId = 5, Name = "薄款同色扣假口袋西裝外套", Memo = "最愛黑白配 <br>夏天必備的薄透感西裝外套<br>設計假口袋 長度適中 沒有墊肩問題<br>配褲裝或是裙類單品都可以", Price = 550, Status = 1 }
                );
            modelBuilder.Entity<ProductImg>().HasData(
                new ProductImg { ProductImgId = 1, ProductId = 1, ProductColorId = 0, ImgPath = "/Image/", ImgName = "1.jpg" },
                new ProductImg { ProductImgId = 2, ProductId = 1, ProductColorId = 0, ImgPath = "/Image/", ImgName = "2.jpg" },
                new ProductImg { ProductImgId = 3, ProductId = 1, ProductColorId = 0, ImgPath = "/Image/", ImgName = "3.jpg" },
                new ProductImg { ProductImgId = 4, ProductId = 1, ProductColorId = 0, ImgPath = "/Image/", ImgName = "4.jpg" },
                new ProductImg { ProductImgId = 5, ProductId = 1, ProductColorId = 0, ImgPath = "/Image/", ImgName = "5.jpg" },
                new ProductImg { ProductImgId = 6, ProductId = 2, ProductColorId = 0, ImgPath = "/Image/", ImgName = "6.jpg" },
                new ProductImg { ProductImgId = 7, ProductId = 2, ProductColorId = 0, ImgPath = "/Image/", ImgName = "7.jpg" },
                new ProductImg { ProductImgId = 8, ProductId = 2, ProductColorId = 0, ImgPath = "/Image/", ImgName = "8.jpg" },
                new ProductImg { ProductImgId = 9, ProductId = 2, ProductColorId = 0, ImgPath = "/Image/", ImgName = "9.jpg" },
                new ProductImg { ProductImgId = 10, ProductId = 3, ProductColorId = 0, ImgPath = "/Image/", ImgName = "10.jpg" },
                new ProductImg { ProductImgId = 11, ProductId = 3, ProductColorId = 0, ImgPath = "/Image/", ImgName = "11.jpg" },
                new ProductImg { ProductImgId = 12, ProductId = 3, ProductColorId = 0, ImgPath = "/Image/", ImgName = "12.jpg" },
                new ProductImg { ProductImgId = 13, ProductId = 3, ProductColorId = 0, ImgPath = "/Image/", ImgName = "13.jpg" },
                new ProductImg { ProductImgId = 14, ProductId = 4, ProductColorId = 0, ImgPath = "/Image/", ImgName = "14.jpg" },
                new ProductImg { ProductImgId = 15, ProductId = 4, ProductColorId = 0, ImgPath = "/Image/", ImgName = "15.jpg" },
                new ProductImg { ProductImgId = 16, ProductId = 4, ProductColorId = 0, ImgPath = "/Image/", ImgName = "16.jpg" },
                new ProductImg { ProductImgId = 17, ProductId = 4, ProductColorId = 0, ImgPath = "/Image/", ImgName = "17.jpg" },
                new ProductImg { ProductImgId = 18, ProductId = 4, ProductColorId = 0, ImgPath = "/Image/", ImgName = "18.jpg" },
                new ProductImg { ProductImgId = 19, ProductId = 5, ProductColorId = 0, ImgPath = "/Image/", ImgName = "19.jpg" },
                new ProductImg { ProductImgId = 20, ProductId = 5, ProductColorId = 0, ImgPath = "/Image/", ImgName = "20.jpg" },
                new ProductImg { ProductImgId = 21, ProductId = 5, ProductColorId = 0, ImgPath = "/Image/", ImgName = "21.jpg" },
                new ProductImg { ProductImgId = 22, ProductId = 5, ProductColorId = 0, ImgPath = "/Image/", ImgName = "22.jpg" },
                new ProductImg { ProductImgId = 23, ProductId = 5, ProductColorId = 0, ImgPath = "/Image/", ImgName = "23.jpg" },
                new ProductImg { ProductImgId = 24, ProductId = 5, ProductColorId = 0, ImgPath = "/Image/", ImgName = "24.jpg" }
                );
            modelBuilder.Entity<ProductColor>().HasData(
                new ProductColor { ProductColorId = 1, ColorCode = "#FFFFFF", ColorName = "白", ProductId = 3 },
                new ProductColor { ProductColorId = 2, ColorCode = "#000000", ColorName = "黑", ProductId = 3 },
                new ProductColor { ProductColorId = 3, ColorCode = "#FFF9CD", ColorName = "杏", ProductId = 4 },
                new ProductColor { ProductColorId = 4, ColorCode = "#7697FF", ColorName = "藍", ProductId = 4 },
                new ProductColor { ProductColorId = 5, ColorCode = "#FFFFFF", ColorName = "白", ProductId = 5 },
                new ProductColor { ProductColorId = 6, ColorCode = "#000000", ColorName = "黑", ProductId = 5 },
                new ProductColor { ProductColorId = 7, ColorCode = "#BDCDFF", ColorName = "藍", ProductId = 5 },
                new ProductColor { ProductColorId = 8, ColorCode = "#FFFBD1", ColorName = "杏", ProductId = 5 },
                new ProductColor { ProductColorId = 9, ColorCode = "#E1FFA5", ColorName = "綠", ProductId = 5 }
                );
            modelBuilder.Entity<ProductSize>().HasData(
                new ProductSize { ProductSizeId = 1, SizeCode = "S", ProductId = 2, SizeMemo = "腰圍58 裙長77" },
                new ProductSize { ProductSizeId = 2, SizeCode = "M", ProductId = 2, SizeMemo = "腰圍60 裙長78" },
                new ProductSize { ProductSizeId = 3, SizeCode = "L", ProductId = 2, SizeMemo = "腰圍63 裙長79" }
                );
            modelBuilder.Entity<ProductVideo>().HasData(
                new ProductVideo { ProductVideoId = 1, ProductId = 1,  VideoPath = "/Video/", VideoName = "KNwCkIfpIP5gbfoh.mp4" }
                );
        }


        public DbSet<Product> Product { get; set; }
        public DbSet<ProductColor> ProductColor { get; set; }
        public DbSet<ProductSize> ProductSize { get; set; }
        public DbSet<ProductImg> ProductImg { get; set; }
        public DbSet<ProductVideo> ProductVideo { get; set; }
    }
}
