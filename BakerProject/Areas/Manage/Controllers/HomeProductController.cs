using BakerProject.DAL;
using BakerProject.Models;
using BakerProject.Utility.Extension;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BakerProject.Areas.Manage.Controllers
{
    [Area("Manage"), Authorize]
    public class HomeProductController : Controller
    {
        private readonly Context _context;

        public HomeProductController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeProducts.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeProduct product)
        {
            if (!ModelState.IsValid) return View(product);
            if (product.ImageFile != null)
            {
                if (product.ImageFile.ContentType != "image/jpeg" && product.ImageFile.ContentType != "image/png" && product.ImageFile.ContentType != "image/webp")
                {
                    ModelState.AddModelError("ImageFile", "Image can be only .jpeg or .png");
                    return View(product);
                }
                if (product.ImageFile.Length / 1024 > 2000)
                {
                    ModelState.AddModelError("ImageFile", "Image size must be lower than 2mb");
                    return View(product);
                }

                string filename = product.ImageFile.FileName;
                if (filename.Length > 64)
                {
                    filename.Substring(filename.Length - 64, 64);
                }
                string newFileName = Guid.NewGuid().ToString() + filename;
                string path = Path.Combine(FileExtension.rootPath, newFileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    product.ImageFile.CopyTo(stream);
                }
                product.Image = newFileName;
                await _context.HomeProducts.AddAsync(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Image can't be null");
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            HomeProduct product = _context.HomeProducts.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(HomeProduct product)
        {
            var existProduct = _context.HomeProducts.FirstOrDefault(x => x.Id == product.Id);
            if (existProduct == null) return NotFound();
            string newFileName = null;

            if (product.ImageFile != null)
            {
                if (product.ImageFile.ContentType != "image/jpeg" && product.ImageFile.ContentType != "image/png" && product.ImageFile.ContentType != "image/webp")
                {
                    ModelState.AddModelError("ImageFile", "Image can be only .jpeg or .png");
                    return View(product);
                }
                if (product.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Image size must be lower than 2mb");
                    return View(product);
                }
                string fileName = product.ImageFile.FileName;
                if (fileName.Length > 64)
                {
                    fileName = fileName.Substring(fileName.Length - 64, 64);
                }
                newFileName = Guid.NewGuid().ToString() + fileName;

                string path = Path.Combine(FileExtension.rootPath, newFileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    product.ImageFile.CopyTo(stream);
                }
            }
            if (newFileName != null)
            {
                string deletePath = Path.Combine(FileExtension.rootPath, existProduct.Image);

                if (System.IO.File.Exists(deletePath))
                {
                    System.IO.File.Delete(deletePath);
                }

                existProduct.Image = newFileName;
            }

            existProduct.Title = product.Title;
            existProduct.Description = product.Description;
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var product = _context.HomeProducts.FirstOrDefault(x => x.Id == id);
            string path = Path.Combine(product.Image);
            _context.HomeProducts.Remove(product);
            _context.SaveChanges();
            FileExtension.DeleteFile(path);
            return RedirectToAction("index");
        }
    }
}
