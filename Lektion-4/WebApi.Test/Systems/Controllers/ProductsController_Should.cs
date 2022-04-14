using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;
using Xunit;

namespace WebApi.Test.Systems.Controllers
{
    
    public class ProductsController_Should
    {
        [Fact]
        public async Task GetAllProducts_OnSuccess_Return_StatusCode_200()
        {
            //Arrange
            var sut = new ProductsController();

            //Act
            var result = (OkObjectResult)await sut.GetAllProducts();

            //Assert
            result.StatusCode.Should().Be(200);
        }
    }
}
