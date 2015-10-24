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
            return GetPriceByDiscountRule();
        }

        private double GetPriceByDiscountRule()
        {
            var price = _books.Sum(x => x.Price);
            var booksAmount = _books.Count;

            switch (booksAmount)
            {
                case 1:
                    price *= 1.0;
                    break;
                case 2:
                    price *= 0.95;
                    break;
            }

            return price;
        }
    }
}
