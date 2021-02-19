using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _ctx;

        public HomeController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View(new Post());
        }

        [HttpPost]
        public IActionResult Edit(Post post)
        {
            return RedirectToAction("Index");
        }
    }
}
