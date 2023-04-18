using KitmEshop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KitmEshop.Controllers
{
    public class ReviewController : Controller
    {
        private readonly EshopContext _db;

        public ReviewController(EshopContext db)
        {
            _db = db;
        }

        public IActionResult Add(Guid id)
        {
            var review = new Review();
            review.Product = _db.Products.FirstOrDefault(p => p.Id == id);

            return View(review);
        }

        [HttpPost]
        public async Task<IActionResult> Add([Bind("ReviewText,ProductId")]Review model)
        {
            var newReview = new Review();
            newReview.ReviewText = model.ReviewText;
            newReview.Product = _db.Products.FirstOrDefault(p => p.Id == model.ProductId);

            newReview.Product = await _db.Products.FindAsync(model.ProductId);

            _db.Reviews.Add(newReview);
            _db.SaveChanges();
            
            return RedirectToAction("Index","Home", new { reviewAdded = true});
        }
    }
}
