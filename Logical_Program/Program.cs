using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Program to use Press Y.");
            char ch1 = Convert.ToChar(Console.ReadLine());
            char consent = ch1;

            while (consent == 'y' || consent == 'Y')
            {
                Console.WriteLine("Enter the choice : \n1.Fibonacci Series. \n2.Perfect Number. \n3.Prime Number.\n4.Reverse Number.\n5.Stop Watch.\n6.Generate Coupon.");
                Console.WriteLine("............................................");
                int key = Convert.ToInt32(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        FibonacciSeries.fibonacci();
                        break;
                    case 2:
                        PerfectNo.perfectNo();
                        break;
                    case 3:
                        PrimeNo.primeNo();
                        break;
                    case 4:
                        ReverseNo.reverseNo();
                        break;
                    case 5:
                        Watch.watch();
                        break;
                    case 6:
                       CouponNo.couponNo();
                        break;
                    default:
                        Console.WriteLine("Enter the Given option");
                        break;
                }
                Console.WriteLine("Do you Want to continue press Y.");
                char ch = Convert.ToChar(Console.ReadLine());
                consent = ch;
            }
        }
    }
}
