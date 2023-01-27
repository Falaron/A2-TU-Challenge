using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> numPrimary = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i)) numPrimary.Add(i);
            }
            return numPrimary;
        }
        public static bool IsDivisible(int a, int b)
        {
            return a % b == 0;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            return -1;
        }

        public static bool IsListInOrder(List<int> list)
        {
            int previousNum = list[0];
            for(int i = 1; i < list.Count; i ++)
            {
                if (list[i] >= previousNum) previousNum = list[i];
                else return false;
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age >= 150 || age < 0) throw new ArgumentException();
            return age >= 18;
        }

        public static bool IsPrimary(int a)
        {
            for(int i = 2; i <= a/2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int result = 1;
            for(int i = 0; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            List<int> sorted = new List<int>();
            for (int i = 0; i < toSort.Count; i ++)
            {
                int min = toSort[0];
                int position = 0;
                for (int j = 0; j < toSort.Count; j++)
                {
                    
                    if (min > toSort[j])
                    {
                        min = toSort[j];
                        position = j;
                    }
                }
                toSort.RemoveAt(position);
                sorted.Add(min);
            }
            return sorted;
        }
    }
}
