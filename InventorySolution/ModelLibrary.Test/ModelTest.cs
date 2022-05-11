using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
