﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class PrimeNo
    {
        public static void primeNo()
        {
            int i, flag = 0;

            Console.Write("Enter the Number to check Prime: ");
            int n = int.Parse(Console.ReadLine());

            int m = n / 2;

            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
            Console.ReadLine();
        }
    }
}
