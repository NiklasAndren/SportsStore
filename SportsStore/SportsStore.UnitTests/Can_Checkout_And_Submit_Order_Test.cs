using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.WebUI.Controllers;
using SportsStore.Domain.Entities;
using Moq;
using SportsStore.Domain.Abstract;
using System.Web.Mvc;

namespace SportsStore.UnitTests
{
    [TestClass]
    public class Can_Checkout_And_Submit_Order_Test
    {
        [TestMethod]
        public void Can_Checkout_And_Submit_Order()
        {
            // Arrange
            Mock<IOrderProcessor> mock = new Mock<IOrderProcessor>();

            Cart cart = new Cart();
            cart.AddItem(new Product(), 1);

            CartController target = new CartController(null, mock.Object);

            // Act
            ViewResult result = target.Checkout(cart, new ShippingDetails());

            // Assert 
            mock.Verify(m => m.ProcessOrder(It.IsAny<Cart>(), It.IsAny<ShippingDetails>()),
            Times.Once());

            Assert.AreEqual("Completed", result.ViewName);

            Assert.AreEqual(true, result.ViewData.ModelState.IsValid);
        }
    }
}
