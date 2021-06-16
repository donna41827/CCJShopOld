using CCJShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCJShop.Context
{
    public class ParamContext : DbContext
    {
        public ParamContext(DbContextOptions<ParamContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Param>().HasData(
                new Param { ParamId = 1, GroupId = 1, Code = "1", Name = "北部", Memo = "地區", UpParamId = 0 },
                new Param { ParamId = 2, GroupId = 1, Code = "2", Name = "中部", Memo = "地區", UpParamId = 0 },
                new Param { ParamId = 3, GroupId = 1, Code = "3", Name = "南部", Memo = "地區", UpParamId = 0 },
                new Param { ParamId = 4, GroupId = 1, Code = "4", Name = "東部", Memo = "地區", UpParamId = 0 },
                new Param { ParamId = 5, GroupId = 1, Code = "5", Name = "外島", Memo = "地區", UpParamId = 0 }
            );
        }

        public DbSet<Param> Param { get; set; }
    }
}
