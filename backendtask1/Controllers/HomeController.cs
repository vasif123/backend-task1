using Backend_Homework_6.DAL;
using Backend_Homework_6.Models;
using Backend_Homework_6.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_6.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(x => x.Comments).Include(x => x.Tags).OrderByDescending(x=>x.ReleaseDate).Take(4).ToList();
            return View(blogs);
        }

        public IActionResult Blog()
        {
            List<Blog> blogs = _context.Blogs.Include(x => x.Comments).Include(x => x.Tags).Take(10).ToList();
            
            return View(blogs);
        }
        public IActionResult BlogDetails(int? id)
        {
            if (id == null) return NotFound();

            BlogsVM model = new BlogsVM
            {
                Blogs = _context.Blogs.Include(x=>x.Tags).OrderByDescending(x => x.ReleaseDate).Take(5).ToList(),
                Blog = _context.Blogs.Include(x => x.Comments).Include(x => x.Tags).FirstOrDefault(x => x.Id == id)
            };

            if (model.Blog == null) return NotFound();

            return View(model);
        }
     
    }
}
