using DataAccessLayer;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalServices 
{
    public class ReviewsServices : IReviewService
    {
        private readonly EshopContext _db;
        public ReviewsServices(EshopContext db)
        {
            _db = db;
        }

        public Review Add(Guid id)
        {
            var review = new Review();
            review.Product = _db.Products.FirstOrDefault(p => p.Id == id);
            return review;
        }

        public void SaveToDb([Bind(new[] { "ReviewText,ProductId" })] Review model)
        {
            var newReview = new Review();
            newReview.ReviewText = model.ReviewText;
            newReview.Product = _db.Products.FirstOrDefault(p => p.Id == model.ProductId);

            _db.Reviews.Add(newReview);
            _db.SaveChanges();
        }
     
    }
}
