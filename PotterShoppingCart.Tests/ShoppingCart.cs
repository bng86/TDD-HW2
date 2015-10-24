using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart.Tests
{
    public class ShoppingCart
    {
        private List<Book> _books;

        public void SetBooks(List<Book> books)
        {
            _books = books;
        }

        public double GetPrice()
        {
            double price = 0;
            var books = _books;

            while (books.Count > 0)
            {
                var combination = books.Distinct().ToList();
                price += GetPriceByDiscountRule(combination);
                foreach (var book in combination)
                {
                    books.Remove(book);
                }
            }

            return price;
        }

        private double GetPriceByDiscountRule(List<Book> books)
        {
            var price = books.Sum(x => x.Price);
            var booksAmount = books.Count;

            switch (booksAmount)
            {
                case 1:
                    price *= 1.0;
                    break;
                case 2:
                    price *= 0.95;
                    break;
                case 3:
                    price *= 0.9;
                    break;
                case 4:
                    price *= 0.8;
                    break;
                case 5:
                    price *= 0.75;
                    break;
            }

            return price;
        }
    }
}
