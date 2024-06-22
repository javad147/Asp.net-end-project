using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineStore.Data;
using OnlineStore.Models;
using System.Collections.Generic;

namespace OnlineStore.Controllers
{
    public class ShopController : Controller
    {
        private readonly OnlineStoreContext _context;
        private readonly IHttpContextAccessor _accessor;

        public ShopController(OnlineStoreContext context,
                                IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;

        }
        public IActionResult Index(string? search)
        {
            List<Product> model = _context.Products.Where(x => x.SoftDeleted != true).ToList();
            if (!string.IsNullOrEmpty(search))
            {
                model = model.Where(x => x.Name.Contains(search)).ToList();
            }
            return View(model);
        }
        public IActionResult Details() 
        {
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            var products = _context.Products.Where(x => x.SoftDeleted != true).ToList();

            List<CartVM> cartProducts = new List<CartVM>();

            foreach (var product in basketProducts)
            {
                var dbProduct = products.FirstOrDefault(m => m.Id == product.Id);

                cartProducts.Add(new CartVM
                {
                    Id = product.Id,
                    Name = dbProduct.Name,
                    Description = dbProduct.Description,
                    Category = dbProduct.Category.Name,
                    Price = dbProduct.Price,
                    Count = product.Count,
                    TotalPrice = product.Count * product.Price
                });
            }
            return View(cartProducts);
        }
    }
}
