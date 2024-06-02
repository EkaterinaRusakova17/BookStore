using System.Collections.Generic;

namespace BookStore
{
    public class ReviewManager
    {
        private List<Review> reviews;

        public ReviewManager()
        {
            reviews = new List<Review>();
        }

        public void AddReview(Review review)
        {
            reviews.Add(review);
        }

        public List<Review> GetReviews(string bookTitle)
        {
            return reviews.FindAll(r => r.BookTitle == bookTitle);
        }
    }
}