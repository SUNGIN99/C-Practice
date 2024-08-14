using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class4
    {
    }

    public class Currency
    {
        decimal money;
        public decimal Money { get { return money; } }

        public Currency (Decimal money)
        {
            this.money = money;
        }
    }

    public class Won : Currency
    {
        public Won(decimal money) : base(money)
        {
            
        }

        static public implicit operator Won(Yen yen)
        {
            //Console.WriteLine(yen.Money);
            return new Won(yen.Money * 13m);
        }

        static public explicit operator Won(Dollar dollar)
        {
            return new Won(dollar.Money * 1000m);
        }

        public override string ToString()
        {
            return Money +"Won";
        
        }
    }

    public class Dollar : Currency
    {
        public Dollar(decimal money) : base(money)
        {

        }

        public override string ToString()
        {
            return Money + "Dollar";

        }
    }

    public class Yen : Currency
    {
        public Yen(decimal money) : base(money)
        {
            
        }

        public override string ToString()
        {
            return Money + "Yen";

        }
    }
}
