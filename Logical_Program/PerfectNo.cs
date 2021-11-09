using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class PerfectNo
    {
        public static void perfectNo()
        {
            int n, i, sum;

            Console.Write("Check whether a given number is perfect number or not:\n");
            Console.Write("Input the  number : ");
            n = Convert.ToInt32(Console.ReadLine());

            sum = 0;

            Console.Write("The positive divisor  : ");

            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}", sum);

            if (sum == n)
                Console.Write("\nThe number is perfect.");
            else
                Console.Write("\nThe number is not perfect.");

            Console.ReadLine();
        }
    }
}
