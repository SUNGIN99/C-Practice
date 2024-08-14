using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             * Class1
            Console.WriteLine("Hello World");

            Class1 c1 = new Class1();

            c1.intTest();
            c1.doubleTest();
            c1.charTest();


            c1.arrTest();
            */

            /*
             * Class2
            Lion lion = new Lion();

            lion.Move();

            Mammal one = lion;

            one.Move();
            */


            //Class3(opeator, getter, setter)
            //Node n1 = new Node(10);
            //Node n2 = new Node(20);
            //Node n3 = n1 + n2;
            //Console.WriteLine(n3.Value);

            //n3.Value = 50;
            //Console.WriteLine(n3.Value);

            /* Class4 (implict, explict)
            Yen yen = new Yen(13m);
            Won won = (Won) yen;

            Dollar dollar = new Dollar(10m);
            Won won2 = (Won) dollar;

            Console.WriteLine(won.Money);
            */

            /*
             * Class 5
            // delegate
            Class5 c5 = new Class5();

            c5.go();
            c5.two();
            */

            /*
             * SortObject , callback delegate
            SortObject so = new SortObject(new object[] { 15, 6, 49, 21, -5, 3, 21, 5, 41, 0, 1 });

            Console.WriteLine(so);
            so.Sort(so.compareAsc);
            Console.WriteLine(so);
            so.Sort(so.compareDesc);
            Console.WriteLine(so);
            */


            //int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            //System.Collections.IEnumerator enumerator = intArray.GetEnumerator();
            //Console.Write(enumerator.Current + ", ");

            //while (enumerator.MoveNext())
            //{
            //    Console.Write(enumerator.Current + ", ");
            //}

            //Vector v1, v2;
            //v1.x = v1.y = v2.x = v2.y = 1;

            //Console.WriteLine(v1.Equals(v2));

            //Change(ref v1);

            //Days today = Days.Sun;
            //Console.WriteLine(today);

            //int dayNum = (int)Days.Fri;
            //Console.WriteLine(dayNum);

            //today = (Days)dayNum;
            //Console.WriteLine(today);

            //Days workingDays = Days.Mon | Days.Tue | Days.Wed | Days.Thu | Days.Fri;
            //Console.WriteLine(workingDays.HasFlag(Days.Sun));

            //Days today = Days.Fri;
            //Console.WriteLine(workingDays.HasFlag(today));

            //Console.WriteLine(workingDays);

            //Console.WriteLine(PracInterface.abc);

            int[][] a = new int[10][];
            for(int i = 0; i< 10; i++)
            {
                a[i] = new int[5];
                Console.WriteLine(a[i]);
            }
        }

        static void Change(ref Vector vt)
        {
            vt.x = 7;
            vt.y = 10;
        }

        struct Vector
        {
            public int x, y;
        }

       //[Flags]
        enum Days
        {
            Sun = 1, Mon = 2, Tue = 4, Wed = 8, Thu = 16,
            Fri = 32, Sat = 64
        }

    }
}
