using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SqlLibrary.Queries;
using System.Configuration;
using ModelLibrary.Models;

namespace SqlLibrary.Test
{
    public class QueriesTest
    {
       [Fact]
       public void StringIsNotNull_ShouldReturnFalse()
        {
            //Arrange
            string str = "Test";

            //Act
            bool result = Queries.Queries.StringIsNullOrEmpty(str);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void StringIsEmpty_ShouldReturnTrue()
        {
            //Arrange
            string str = "";

            //Act
            bool result = Queries.Queries.StringIsNullOrEmpty(str);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void StringIsNull_ShouldReturnTrue()
        {
            //Arrange
            string str = null;

            //Act
            bool result = Queries.Queries.StringIsNullOrEmpty(str);
            //Assert
            Assert.True(result);
            //Assert.Throws<NullReferenceException>(() => Queries.Queries.StringIsNullOrEmpty(str, "Connection string"));
        }

        //Category cat = Queries.SearchCategoryByIdReturnCategory(conStr, "1");
        [Fact]
        public void SearchCategoryByIdReturnCategory_ShouldReturnValidCategoryItem()
        {
            //Act
            string conStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            int id = 1;

            //Arrange
            Category cat = Queries.Queries.SearchCategoryByIdReturnCategory(conStr, id.ToString());

            //Assert
            Assert.True(cat.Id == 1);
            Assert.True(cat.Name == "Food and drink");

        }

        

    }
}
