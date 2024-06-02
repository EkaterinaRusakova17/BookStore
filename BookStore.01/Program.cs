
using BookStore;
using System;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр книжного магазина
            BookStore bookStore = new BookStore();

            // Добавляем книги
            bookStore.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99m));
            bookStore.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 8.75m));

            // Покупаем книги с использованием различных стратегий оплаты
            bookStore.Purchase(new CreditCardPaymentStrategy());
            bookStore.Purchase(new PayPalPaymentStrategy());

            // Оставляем отзывы
            bookStore.AddReview(new Review("The Great Gatsby", "Excellent book!", 5));
            bookStore.AddReview(new Review("To Kill a Mockingbird", "A classic!", 4));

            Console.ReadLine();
        }
    }
}