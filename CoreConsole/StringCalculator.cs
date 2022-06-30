using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoreConsole
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            if (numbers.Length == 1)
            {
                return int.Parse(numbers);
            }

            Regex regex = new Regex(@"-?(\d+)");
            var nums = regex.Matches(numbers);

            var result = 0;

            foreach (Match num in nums)
            {
                var value = int.Parse(num.Value);

                if (value < 0)
                {
                    Regex regexNegative = new Regex(@"-(\d+)");
                    var negativeNums = regexNegative.Matches(numbers).Select(num => num.Value)
                        .Aggregate((i, j) => i + "," + j);

                    throw new Exception($"negative not allowed - ({negativeNums})");
                }

                if (value > 1000)
                {
                    continue;
                }

                result += int.Parse(num.Value);
            }

            return result;
        }
    }
}
