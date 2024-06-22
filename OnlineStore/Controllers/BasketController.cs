using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineStore.Data;
using OnlineStore.Models;
using System;

namespace OnlineStore.Controllers
{
    public class BasketController : Controller
    {
        private readonly OnlineStoreContext _context;
        private readonly IHttpContextAccessor _accessor;

        public BasketController(OnlineStoreContext context,
                                IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;

        }
        public IActionResult AddToCart(int id)
        {
            List<BasketVM> basketProducts = null;

            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }
            else
            {
                basketProducts = new List<BasketVM>();
            }

            
            List<CartVM> cartProducts = new List<CartVM>();
            var dbProduct = _context.Products.FirstOrDefault(m => m.Id == id);
            cartProducts.Add(new CartVM
            {
                Id = id,
                Name = dbProduct.Name,
                Description = dbProduct.Description,
                Category = dbProduct.Category.Name,
                Price = dbProduct.Price,
                Count = 1,
                TotalPrice = 1 * dbProduct.Price
            });
            
            ViewBag.TotalPrice = basketProducts.Sum(x => x.Price * x.Count);
            _accessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketProducts));
            return RedirectToAction("Index", "Shop");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int? id)
        {
            if (id is null) return BadRequest();

            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);

            basketProducts = basketProducts.Where(m => m.Id != (int)id).ToList();

            _accessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketProducts));


            int count = basketProducts.Sum(m => m.Count);
            decimal totalPrice = basketProducts.Sum(m => m.Count * m.Price);


            return Ok(new { count, totalPrice });
        }
        [HttpGet]
        public IActionResult ShopNow() 
        {
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            var shop = new Shop()
            {
                Title = "Order Done",
                Description = "",
                Id = 0,
                ShopDetails = new List<ShopDetail>()
            };
            foreach (var item in basketProducts)
            {
                shop.ShopDetails.Add(new ShopDetail() { ProductId = item.Id, Quantity = item.Count, Id = 0 });
            }
            _context.Shops.Add(shop);
            _context.SaveChanges();

            return RedirectToAction("Index", "Shop");
        }


    }
}
