using ModelLibrary.Models;
using System;
using Xunit;

namespace ModelLibrary.Test
{
    public class ModelTest
    {
        [Fact]
        public void Category_PropertiesShouldReadCorrect()
        {
            //Arrange
            int id = 1;
            string name = "Test name";
            string description = "Test description";

            //Action
            Category cat = new Category(id, name, description);

            //Assert
            Assert.Equal(id, cat.Id);
            Assert.Equal(name, cat.Name);
            Assert.Equal(description, cat.Description);
        }

        [Fact]
        public void Category_IdIsZeroShouldReadCorrect()
        {
            //Arrange
            int id = 0;
            string name = "Test name";
            string description = "Test description";

            //Action
            Category cat = new Category(id, name, description);

            //Assert
            Assert.Equal(id, cat.Id);
            Assert.Equal(name, cat.Name);
            Assert.Equal(description, cat.Description);
        }

        [Fact]
        public void Category_InvalidIdShouldThrowArgumentException()
        {
            //Arrange
            int id = -1;
            string name = "Valid name";
            string description = "valid description";

            //Assert
            Assert.Throws<ArgumentException>(() => new Category(id, name, description));
        }

        [Fact]
        public void Category_InvalidNameShouldThrowArgumentException()
        {
            //Arrange
            int id = 1;
            string name = "";
            string description = "valid description";

            //Assert
            Assert.Throws<ArgumentException>(() => new Category(id, name, description));
        }
    }
}
