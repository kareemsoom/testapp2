using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication1
{
    class Program
    {
           
        static void Main(string[] args)
        {

            TestClass1 c1 = new TestClass1();
            TestClass1 c2 = new TestClass1();

            var loginPage = new LoginPage();
            loginPage.UserName("farhan");
            //Console.WriteLine( loginPage.GetType());

            c1.SetValue(30);
            c1.GetValue();

            c2.SetValue(40);
            c2.GetValue();

            c1.SetValue(50);
            c1.GetValue();
            c1.GetValue();


            //c1.Testcase1("PASSED");
            //c1.Testcase2("FAILED");

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello to the C# World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public class LoginPage
        {
            public void UserName(String hameed)
            {
                Console.WriteLine(hameed) ;
            }
                
        }

        public class UserListPage
        {
            public string ListOfUsers { get; set; }
        }

    }
}
