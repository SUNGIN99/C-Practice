using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SortObject
    {
        object[] objArr;

        public override string ToString()
        {
            return string.Join(" ", objArr);
        }

        public SortObject(object[] objArr)
        {
            this.objArr = objArr;
        }

        public delegate bool CompareDelegate(object arg1, object arg2);

        public void Sort(CompareDelegate compareMethod)
        {
            object temp;

            for(int i = 0; i< objArr.Length; i++)
            {
                int lowPos = i;
                for(int j = i+1; j< objArr.Length; j++)
                {
                    if (compareMethod(objArr[lowPos], objArr[j]))
                    {
                        lowPos = j;
                    }

                } 

                temp = objArr[lowPos];
                objArr[lowPos] = objArr[i];
                objArr[i] = temp;

            }
        }

        public bool compareDesc(object num1, object num2)
        {
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            return n1 < n2;
        }

        public bool compareAsc(object num1, object num2)
        {
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            return n1 > n2;
        }


    }
}
