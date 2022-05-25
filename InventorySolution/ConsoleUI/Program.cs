using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Models;
using SqlLibrary.Queries;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            //Category cat1 = new Category(1, "QwertyuiopQwertyuiopQwertyuiopQwertyuiopQwertyuiop", "test description");
            //cat1.Print();

            //Category cat2 = new Category(1, "QwertyuiopQwertyuiopQwertyuiopQwertyuiopQwertyuiopAAAAAAAAA", "test description");
            //cat2.Print();

            //Queries.SearchCategoryByIdReturnCategory(conStr, "1");
            //Category cat = Queries.SearchCategoryByIdReturnCategory(conStr, "1");
            //cat.Print();
            //Console.WriteLine();

            //Group grp = new Group(1, "group", "description", cat);
            //grp.Print();

            //GenericProductName gpn = new GenericProductName(1, "gpn", grp);
            //gpn.Print();

            string A = "z";
            string B = "Z";
            int result = string.Compare(A, B);
            Console.WriteLine(result);



            //Category cat3 = new Category(-1, "test name", "test description"); //Should throw error
            //cat3.Print();

        }
    }
}
