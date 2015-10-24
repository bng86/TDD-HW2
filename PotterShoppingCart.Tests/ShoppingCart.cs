using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    public class ShoppingCart
    {
        private List<Book> _books; 

        public void SetBooks(List<Book> books)
        {
            this._books = books;
        }

        public int GetPrice()
        {
            return _books.Sum(x => x.Price);
        }
    }
}
