using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 다형성 테스트

    public class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("이동한다.");
        }

    }

    public class Lion : Mammal
    {
         new public void Move()
        {
           // base.Move();
            Console.WriteLine("네발로 움직인다.");
        }
    }
}

