using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        // 연산자 오버로드
    }

    class Node
    {
        int value;
        public int Value
        {
            get { return value;  }
            set { this.value = value; }
        }

        public static Node operator +(Node n1, Node n2) 
        {
            return new Node(n1.value + n2.value);
        }


        internal Node(int value)
        {
            this.value = value;
        }

    }
}
