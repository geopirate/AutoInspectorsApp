using AutoInspectors.Models;
using System;
using Xunit;

namespace UnitTests.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanChangeMake()
        {
            // Arrange
            var m = new Vehicle { Make = "Honda" };

            //Act
            m.Make = "Audi";

            //Assert
            Assert.Equal("Audi", m.Make);
        }


        [Fact]
        public void YearIsInRange()
        {
            // Arrange
            var y = new Vehicle { Year = 2017 };

            //Act
            y.Year = 2200;

            //Assert
            Assert.NotInRange(2200, 1900, 2100);
        }

    }
}
