using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblemSolution
{
    internal class AverageSalaryExcludingTheMinimumAndMaximumSalary
    {
        public void Average(int[] Salary)
        {
            Array.Sort(Salary);
            int count = 0;
            double sum = 0;
            double Avg = 0;
            for (int i = 1; i < Salary.Length-1; i++)
            {
                sum += Salary[i];
                count++;
            }

            Avg= sum / count;
            Console.WriteLine(Avg.ToString());
            
        }
    }
}
