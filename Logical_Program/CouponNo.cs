using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class CouponNo
    {
        public static void couponNo()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();

            Console.WriteLine("How many ticket u want to generate.");
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);
                Console.WriteLine(finalString);

                number = number - 1;

                Console.ReadLine();
            }
        }
    }
}
