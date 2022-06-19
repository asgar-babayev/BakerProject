using BakerProject.DAL;
using BakerProject.Models;
using BakerProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace BakerProject.Services
{
    public class LayoutService
    {
        readonly Context _context;
        readonly IHttpContextAccessor _accessor;

        public LayoutService(Context context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public int BasketProductCount()
        {
            if (!_accessor.HttpContext.User.Identity.IsAuthenticated)
            {
                if (_accessor.HttpContext.Request.Cookies["Basket"] != null)
                {
                    List<BasketVm> basket = JsonConvert.DeserializeObject<List<BasketVm>>(_accessor.HttpContext.Request.Cookies["Basket"]);
                    return basket.Sum(p => p.Count);
                }
            }
            else
            {
                if (_context.ShopBags != null && _context.ShopBags.Count() > 0 && _accessor.HttpContext.User.Identity.Name != null)
                {
                    var userId = _context.Users.Where(x => x.UserName == _accessor.HttpContext.User.Identity.Name).FirstOrDefault().Id;
                    List<ShopBag> bag = _context.ShopBags.Where(x=>x.AppUserId == userId).ToList();
                    return bag.Sum(p => p.Count);
                }
            }
            return 0;
        }

        public List<BasketItemsVm> Cart()
        {
            List<BasketVm> basket = GetBasket();
            List<BasketItemsVm> basketItems = new List<BasketItemsVm>();
            foreach (var item in basket)
            {
                Product product = _context.Products.FirstOrDefault(p => p.Id == item.ProductId);
                if (product == null) continue;
                BasketItemsVm basketItemsVm = new BasketItemsVm()
                {
                    ProductId = product.Id,
                    Image = product.Image,
                    Name = product.Name,
                    Price = product.Price,
                    Count = item.Count,

                };
                basketItems.Add(basketItemsVm);
            }
            return basketItems;
        }

        public List<BasketItemsVm> CartForUser()
        {
            List<ShopBag> basket = GetShopBag();
            List<BasketItemsVm> basketItems = new List<BasketItemsVm>();
            foreach (var item in basket)
            {
                Product product = _context.Products.FirstOrDefault(p => p.Id == item.ProductId);
                if (product == null) continue;
                BasketItemsVm basketItemsVm = new BasketItemsVm()
                {
                    ProductId = product.Id,
                    Image = product.Image,
                    Name = product.Name,
                    Price = product.Price,
                    Count = item.Count,

                };
                basketItems.Add(basketItemsVm);
            }
            return basketItems;
        }

        private List<ShopBag> GetShopBag()
        {
            List<ShopBag> basketItems = new List<ShopBag>();
            if (_context.ShopBags != null && _context.ShopBags.Count() > 0 && _accessor.HttpContext.User.Identity.Name != null)
            {
                var userId = _context.Users.Where(x => x.UserName == _accessor.HttpContext.User.Identity.Name).FirstOrDefault().Id;
                return _context.ShopBags.Where(x => x.AppUserId == userId).ToList();
            }
            return basketItems;
        }

        private List<BasketVm> GetBasket()
        {
            List<BasketVm> basketItems = new List<BasketVm>();
            if (_accessor.HttpContext.Request.Cookies["Basket"] != null)
                basketItems = JsonConvert.DeserializeObject<List<BasketVm>>(_accessor.HttpContext.Request.Cookies["Basket"]);
            return basketItems;
        }
    }
}
