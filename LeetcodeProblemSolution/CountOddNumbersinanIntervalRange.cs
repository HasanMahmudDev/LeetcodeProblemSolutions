using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblemSolution
{

    internal class CountOddNumbersinanIntervalRange
    {
        public void CountOddNumbers(int low, int high)
        {
            int total = high - low + 1;
            if(total%2 == 0) 
            { 
                Console.WriteLine("Odd number are: "+ total / 2);
            }
            else
            {
                if (low % 2 == 0)
                {
                    Console.WriteLine("Odd number are: " + total / 2);
                }
                else
                {
                    Console.WriteLine("Odd number are: " + total / 2 + 1);
                }
            }
        }
    }
}
