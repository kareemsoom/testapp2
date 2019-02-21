using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication1
{
    class TestClass1
    {
        int i = 0;
        public void GetValue()
        {
            Console.WriteLine("value for i: " + i );
        }

        public void SetValue(int value)
        {
            i = value;
        }

        public void Testcase1(String result)
        {
            Console.WriteLine(" testcase1: " + result);
        }


        public void Testcase2(String result)
        {
            Console.WriteLine(" testcase2: " + result);
        }
    }
}
