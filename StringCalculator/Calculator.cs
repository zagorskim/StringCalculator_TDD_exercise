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

            char[] delim = { ',', '\n' };

            foreach (var s in calculation.Split(delim))
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
