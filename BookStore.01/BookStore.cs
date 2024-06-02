using BookStore;
using System;
using System.Collections.Generic;

namespace BookStore
{
    public class BookStore
    {
        private List<Book> books;
        private List<Review> reviews;

        public BookStore()
        {
            books = new List<Book>();
            reviews = new List<Review>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void Purchase(IPaymentStrategy paymentStrategy)
        {
            // Логика покупки книг с использованием выбранной стратегии оплаты
            paymentStrategy.Pay();
        }

        public void AddReview(Review review)
        {
            reviews.Add(review);
        }

        public List<Review> GetReviews(string bookTitle)
        {
            // Возвращает список отзывов для указанной книги
            return reviews.FindAll(r => r.BookTitle == bookTitle);
        }
    }
}