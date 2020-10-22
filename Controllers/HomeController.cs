using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using AS_ChefDishes.Models;

namespace AS_ChefDishes.Controllers
{
    public class HomeController : Controller
    {
        
        private MyContext _context;

        public  HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            
            List<Chef> AllChefs = _context.Chefs.ToList();
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View();
        }

        [HttpGet("new")] //route
        public IActionResult New()
        {
            return View("new"); //look for the View called this.  if blank, then will pull name
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllDishes = _context.Dishes.ToList();
            return View("dishes"); //dishes.cshtml
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            // List<Chef> AllChefs = _context.Chefs.ToList()
            //     .Include(d => d.Dishes);
                
            return View("NewDish");
        }

        [HttpPost("CreateChef")]
        public IActionResult CreateChef(Chef newChef)
        {
            if (ModelState.IsValid){
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
            else {
                return View("New");
            }
        }

        [HttpPost("dishes/new/submit")]
        public IActionResult SaveDish(Dish newDish)
        {
            if (ModelState.IsValid){
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Dishes");
            }
            else{
                ViewBag.AllChefs = _context.Chefs.ToList();
                return View("NewDish");
            }
        }







        
    }
}
