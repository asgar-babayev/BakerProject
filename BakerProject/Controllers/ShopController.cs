using BakerProject.DAL;
using BakerProject.Models;
using BakerProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakerProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly Context _context;

        public ShopController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ShopVm shopVm = new ShopVm();
            shopVm.Products = await _context.Products.Include(x => x.Category).Take(6).ToListAsync();
            shopVm.Categories = await _context.Categories.ToListAsync();
            return View(shopVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            Product productdb = await _context.Products.FindAsync(id);
            if (productdb == null) return NotFound();
            UpdateBasket((int)id);
            return RedirectToAction("Index");
        }

        public IActionResult Bag()
        {
            return Json(_context.ShopBags.ToList());
        }

        private void UpdateBasket(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                List<BasketVm> basketItems = GetBasket();
                BasketVm existItem = basketItems.Find(x => x.ProductId == id);
                if (existItem != null)
                {
                    existItem.Count += 1;
                }
                else
                {
                    BasketVm basketVm = new BasketVm();
                    basketVm.ProductId = id;
                    basketVm.Count = 1;
                    basketItems.Add(basketVm);
                }
                Response.Cookies.Append("Basket", JsonConvert.SerializeObject(basketItems));
            }
            else
            {
                List<ShopBag> items = GetShopBag();
                ShopBag existItem = items.Find(x => x.ProductId == id);
                if (existItem != null)
                {
                    existItem.Count += 1;
                    _context.SaveChanges();
                }
                else
                {
                    ShopBag shopBag = new ShopBag();
                    shopBag.ProductId = id;
                    shopBag.Count = 1;
                    var userId = _context.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault().Id;
                    shopBag.AppUserId = userId;
                    _context.ShopBags.Add(shopBag);
                    _context.SaveChanges();
                }
            }

        }
        private List<BasketVm> GetBasket()
        {
            List<BasketVm> basketItems = new List<BasketVm>();
            if (Request.Cookies["Basket"] != null)
                basketItems = JsonConvert.DeserializeObject<List<BasketVm>>(Request.Cookies["Basket"]);
            return basketItems;
        }
        private List<ShopBag> GetShopBag()
        {
            List<ShopBag> basketItems = new List<ShopBag>();
            if (_context.ShopBags != null && _context.ShopBags.Count() > 0)
            {
                var userId = _context.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault().Id;
                return _context.ShopBags.Where(x => x.AppUserId == userId).ToList();
            }
            return basketItems;
        }
        public IActionResult RemoveBasketProduct(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                List<BasketVm> basketItems = GetBasket();
                BasketVm existItem = basketItems.Find(x => x.ProductId == id);
                if (existItem != null)
                {
                    basketItems.Remove(existItem);
                    Response.Cookies.Append("Basket", JsonConvert.SerializeObject(basketItems));
                }
            }
            else
            {
                List<ShopBag> items = GetShopBag();
                ShopBag existBag = items.Find(x => x.ProductId == id);
                if (existBag != null)
                {
                    _context.ShopBags.Remove(existBag);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
