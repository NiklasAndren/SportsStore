﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.Domain.Abstract;
using Moq;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Controllers;


namespace SportsStore.UnitTests
{
    [TestClass]
    public class Indicates_Selected_Category_Test
    {
        [TestMethod]
        public void Indicates_Selected_Category()
        {
            /*
            // Arrange
            // - create the mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
                new Product {ProductID = 1, Name = "P1", Category = "Apples"},
                new Product {ProductID = 4, Name = "P2", Category = "Oranges"},
                }.AsQueryable());

            NavController target = new NavController(mock.Object);

            string categoryToSelect = "Apples";

            // Action
            //string result = target.Menu(categoryToSelect).ViewBag.SelectedCategory;

            string result = target.Menu(categoryToSelect).ViewBag.SelectedCategory;

            // Assert
            Assert.AreEqual(categoryToSelect, result); */
        }
    }
}
