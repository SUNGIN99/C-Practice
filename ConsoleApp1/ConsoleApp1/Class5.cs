using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class5
    {
        public delegate void Callback(string message);

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public void go()
        {
            Callback handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");
        }


        delegate void CalcDelegate(int x, int y);
        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Sub(int x, int y) { Console.WriteLine(x - y); }
        static void Mul(int x, int y) { Console.WriteLine(x * y); }
        static void Div(int x, int y) { Console.WriteLine(x / y); }
        public void two()
        {
            CalcDelegate cd = Add;
            cd += Sub;
            cd += Mul;
            cd += Div;

            cd(10, 5);


        }

        // call back Function

    }
}
