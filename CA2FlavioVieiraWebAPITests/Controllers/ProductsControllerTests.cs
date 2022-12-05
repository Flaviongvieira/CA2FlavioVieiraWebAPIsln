using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA2FlavioVieiraWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA2FlavioVieiraWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CA2FlavioVieiraWebAPI.Controllers.Tests
{
    [TestClass()]
    public class ProductsControllerTests
    {
        IRepository repo = new MockDB();


        [TestMethod()]
        public void GetAllProductsTest()
        {
            // Arrange
            ProductsController test = new ProductsController(repo);

            // Act
            var result = test.GetAllProducts();
            var resultStatusCode = (result.Result as OkObjectResult).StatusCode;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(resultStatusCode == 200);
        }

        [TestMethod()]
        public void GetAllProductsbyCategoryRatingTest()
        {
            // Arrange
            ProductsController test = new ProductsController(repo);

            // Act
            var result = test.GetAllProductsbyCategoryRating("Hurling", 5);
            var resultStatusCode = (result.Result as OkObjectResult).StatusCode;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(resultStatusCode == 200);
        }

        [TestMethod()]
        public void GetAllProductsbyCPriceTest()
        {
            // Arrange
            ProductsController test = new ProductsController(repo);

            // Act
            var result = test.GetAllProductsbyCPrice(39, 60);
            var resultStatusCode = (result.Result as OkObjectResult).StatusCode;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(resultStatusCode == 200);
        }
    }
}