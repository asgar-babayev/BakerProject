using BakerProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BakerProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeProducts.Take(8).ToListAsync());
        }
    }
}
