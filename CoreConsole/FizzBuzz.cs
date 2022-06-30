using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoreConsole
{
    public class FizzBuzz
    {
        public static string FizzBuzzPrint(int n)
        {
            if (n % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (n % 3 == 0)
            {
                return "Fizz";
            }

            if (n % 5 == 0)
            {
                return "Buzz";
            }
            
            return n.ToString();
        }
    }
}
