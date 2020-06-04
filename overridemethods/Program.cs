using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethods
{
    class Program
    {
        class Cal
        {
            public int Power(int input)
            {
                return (int)(Math.Pow(input, 2));
            }
            public int Power(int input, int count)
            {
                int result = (int)(Math.Pow(input, count));
                return result;
            }
            public int SumAll(int end)
            {
                int sum = 0;
                for (int i = 0; i <= end; i++)
                {
                    sum += i;
                }
                return sum;
            }
            public int SumAll(int start, int end)
            {
                int sum = 0;
                for (int i = start; i <= end; i++)
                {
                    sum += i;
                }
                return sum;
            }
        }
        
        static void Main(string[] args)
        {
            Cal cal = new Cal();
            
            Console.WriteLine(cal.Power(5));
            Console.WriteLine(cal.Power(5,3));
            Console.WriteLine(cal.SumAll(3));
            Console.WriteLine(cal.SumAll(1,3));
        }
    }
}
