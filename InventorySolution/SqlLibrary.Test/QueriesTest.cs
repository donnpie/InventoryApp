using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SqlLibrary.Queries;

namespace SqlLibrary.Test
{
    public class QueriesTest
    {
       [Fact]
       public void StringIsNull_ShouldReturnFalse()
        {
            //Arrange
            string conStr = "Test";

            //Act
            bool result = Queries.Queries.StringIsNull(conStr, "Connection string");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void StringIsNull_ShouldReturnTrue()
        {
            //Arrange
            string conStr = "";

            //Act
            bool result = Queries.Queries.StringIsNull(conStr, "Connection string");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void StringIsNull_NullShouldReturnTrue()
        {
            //Arrange
            string conStr = null;

            //Act
            bool result = Queries.Queries.StringIsNull(conStr, "Connection string");

            //Assert
            Assert.True(result);
        }
    }
}
