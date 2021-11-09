using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class ReverseNo
    {
        public static void reverseNo()
        {
            int n, rev = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + rev);

            Console.ReadLine();
        }
    }
}
