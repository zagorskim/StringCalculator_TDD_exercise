using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string calculation)
        {
            int res = 0;

            if (calculation.Length == 0)
                return res;

            string[] delim = { ",", "\n" };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-' };
            string[] brackets = { "[", "]", "][" };
            var i = 2;
            string[] additional_delims = { };
            if (calculation.Length > 1 && calculation.ElementAt(0).ToString() + calculation.ElementAt(1).ToString() == "//")
            {
                while (!numbers.Contains(calculation[i]))
                    i++;
                additional_delims = calculation.Substring(2, i - 2).Split(brackets, StringSplitOptions.RemoveEmptyEntries);
                calculation = calculation.Remove(0, i);
            }
            if (i > 2)
                foreach (var s in additional_delims)
                    delim = delim.Append(s).ToArray();
            foreach (var s in calculation.Split(delim, StringSplitOptions.RemoveEmptyEntries))
            {
                var num = int.Parse(s);
                if (num < 0)
                    throw new ArgumentException("Numbers should be > 0");
                if (num > 1000)
                    continue;
                res += num;
            }

            return res;
        }
    }
}
