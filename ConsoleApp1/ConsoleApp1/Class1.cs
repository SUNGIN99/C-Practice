using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public void intTest()
        {
            int n1 = 10;
            int n2 = 20;
            int n3 = null == null ? 1: 0 ;

            Console.WriteLine(n1 + n2);
            print(n3);
        }

        public void doubleTest()
        {
            float f = 5.2f;
            double d = 10.5;
            decimal money = 200.099m;

            print(f);
            print(d);
            print(money);
        }

        public void charTest()
        {
            char ch = 'A';
            String str = "String Class?";
            string str2 = "string primitive";
            string str3 = null;

            char b = (char) 48;

            print(str + " " + str2);
            print(b);
            print(str3);
        }

        internal void print(Object o)
        {
            Console.WriteLine(o);
        }

        public void arrTest()
        {
            int[] arr = new int[5];
            for(int i = 0; i<arr.Length; i++)
            {
                print(i);
            }

            int[][] arr2 = new int[10][];
            for(int i = 0; i<arr2.Length; ++i)
            {
                arr2[i] = new int[5];
                print(arr2[i]);
            }
        }
        
    }
}
