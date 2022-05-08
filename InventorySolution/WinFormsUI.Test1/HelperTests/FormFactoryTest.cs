using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Helper;
using Xunit;

namespace WinFormUI.Test1.HelperTests
{
    public class FormFactoryTest
    {
        [Fact]
        public void MakeCategoryForm_TitleShouldEqual()
        {
            //Arrange
            string expected = "Test Category";

            //Actual
            Form f = FormFactory.MakeCategoryForm(
                "Test Category",
                "Add",
                FormMode.New,
                Table.Category
            );
            f.Show();
            string actual = f.Name;

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
