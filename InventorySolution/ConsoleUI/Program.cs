using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Category cat1 = new Category(1, "QwertyuiopQwertyuiopQwertyuiopQwertyuiopQwertyuiop", "test description");
            cat1.Print();

            Category cat2 = new Category(1, "QwertyuiopQwertyuiopQwertyuiopQwertyuiopQwertyuiopAAAAAAAAA", "test description");
            cat2.Print();

            //Category cat3 = new Category(-1, "test name", "test description"); //Should throw error
            //cat3.Print();

        }
    }
}
