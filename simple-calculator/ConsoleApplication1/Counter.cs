using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    public class Counter
    {
        public int ConsoleCounter(string userinput, int count)
        {
            
            userinput = Console.ReadLine();
            if (userinput !="")
            {
                return ++count;
            }
            else
            {
                return count;
            }
        }
    }
}
