using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CCJShop.Context;
using CCJShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCJShop.Controllers
{
    public class ParamController : Controller
    {
        private readonly ParamContext _context;

        public ParamController(ParamContext context)
        {
            _context = context;
        }
        // 
        // GET: /Param/
        public IActionResult Index()
        {
            var query = _context.Param.Select(s => new { s.GroupId, s.Memo }).Distinct().ToList();
            List<ParamGroupViewModel> p = new List<ParamGroupViewModel>();
            foreach (var item in query) 
            {
                p.Add(new ParamGroupViewModel { GroupId = item.GroupId, Memo = item.Memo });
            }
            return View(p);
        }
        public IActionResult Create() 
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
