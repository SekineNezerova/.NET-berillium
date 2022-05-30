using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewNetProject.DAL;
using NewNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewNetProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Index()
        {
            HomeView hv = new HomeView()
            {
                services = await db.Services.ToListAsync()
            };
            return View(hv);
        }
    }
}
