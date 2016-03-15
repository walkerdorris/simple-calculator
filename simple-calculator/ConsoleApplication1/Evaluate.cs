using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    public class Evaluate
    {
        public int Calculate(int term1, int term2, char oper)
        {
           if (oper == '+')
            {
                return term1 + term2;
            }
           if (oper == '-')
            {
                return term1 - term2;
            }
            if (oper == '/')
            {
                return term1 / term2;
            }
            if (oper == '*')
            {
                return term1 * term2;
            }
            if (oper == '%')
            {
                return term1 % term2;
            }
            else
            {
                throw new ArgumentException("Not valid input");
            }
        }
    }
}
