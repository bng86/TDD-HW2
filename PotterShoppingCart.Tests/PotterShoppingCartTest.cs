﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void GetPrice_第一集買了一本_其他都沒買_價格應為100_乘_1_等於_100元()
        {
            //arrange
            var books = new List<Book>
            {
                new Book{ Name = "第一集", Price = 100}
            };

            var target = new ShoppingCart();
            target.SetBooks(books);

            var expected = 100;

            //act
            var actual = target.GetPrice();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPrice_第一集買了一本_第二集也買了一本_價格應為100_乘_2_乘_0_點_95_等於_190()
        {
            //arrange
            var books = new List<Book>
            {
                new Book{ Name = "第一集", Price = 100 },
                new Book{ Name = "第二集", Price = 100 }
            };

            var target = new ShoppingCart();
            target.SetBooks(books);

            var expected = 190;

            //act
            var actual = target.GetPrice();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPrice_一二三集各買了一本_價格應為100_乘_3_乘_0_點_9_等於_270()
        {
            //arrange
            var books = new List<Book>
            {
                new Book{ Name = "第一集", Price = 100 },
                new Book{ Name = "第二集", Price = 100 },
                new Book{ Name = "第三集", Price = 100 }
            };

            var target = new ShoppingCart();
            target.SetBooks(books);

            var expected = 270;

            //act
            var actual = target.GetPrice();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPrice_一二三四集各買了一本_價格應為100_乘_4_乘_0_點_8_等於_320()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetPrice_一次買了整套_一二三四五集各買了一本_價格應為100_乘_5_乘_0_點_75_等於_375()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetPrice_一二集各買了一本_第三集買了兩本_價格應為100_乘_3_乘_0_點_9_加_100_等於_370()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetPrice_第一集買了一本_第二三集各買了兩本_價格應為100_乘_3_乘_0_點_9_加_100_乘_2_乘_0_點_95_等於_460()
        {
            Assert.Fail();
        }
    }

    public class Book
    {
        public double Price { get; set; }

        public string Name { get; set; }
    }
}
