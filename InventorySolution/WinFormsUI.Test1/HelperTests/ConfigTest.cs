using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormUI.Helper;
using Xunit;

namespace WinFormUI.Test1.HelperTests
{
    public class ConfigTest
    {
        [Fact]
        public void GetConString_ShouldWork()
        {
            string expected = "Server=localhost\\SQLEXPRESS;Database=Inventory;Trusted_Connection=True;";
            string actual = ConfigInfo.GetConString("ConString");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetImageDirectory_ShouldWork()
        {
            string expected = "C:\\Users\\donnp\\source\\repos\\Inventory app\\Img\\";
            string actual = ConfigInfo.GetImageDirectory("ImageFileDirectory");
            Assert.Equal(expected, actual);
        }
    }
}
