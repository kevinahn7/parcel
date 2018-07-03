using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcel.Controllers;
using Parcel.Models;

namespace Parcel.Tests
{
    [TestClass]
    public class ParcelsControllerTest
    {
        [TestMethod]
        public void Form_ReturnsCorrectView_True()
        {
            ParcelsController controller = new ParcelsController();
            ActionResult indexView = controller.Form();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Cost_ReturnsCorrectView_True()
        {
            ParcelsController controller = new ParcelsController();

            IActionResult indexView = controller.Cost(2, 2, 2, 2);

            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Cost_HasCorrectModelType_ShippingItem()
        {
            //Arrange
            ParcelsController controller = new ParcelsController();
            IActionResult actionResult = controller.Cost(2, 2, 2, 2);
            ViewResult costDataType = controller.Cost(2, 2, 2, 2) as ViewResult;

            //Act
            var result = costDataType.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(ShippingItem));
        }
    }
}
