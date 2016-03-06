using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Expression
    {
        public int Term1 { get; set; }
        public int Term2 { get; set; }
        public char Op { get; set; }

        public void ParseInput(string input)
        {
            var operators = new char[] { '+', '-', '%', '*', '/' };
            // input = "9 + 8"
            input = input.Replace(" ", "");
            // input "9+8"
            string[] terms = input.Split(operators);
            // terms = ["9", "8"]

            int term1;
            if(!int.TryParse(terms[0], out term1))
            {
                throw new ArgumentException("Not valid input");
            }
            Term1 = term1;

            int term2;
            if (!int.TryParse(terms[1], out term2))
            {
                throw new ArgumentException("Not valid input");
            }
            Term2 = term2;

            string foundoperators = "";
            char[] inputcharacters = input.ToCharArray();
            for(int i=0; i < operators.Length; i++)
            {
                var singleOp = operators[i];
                for(int j=0; j < inputcharacters.Length; j++)
                {
                    char letter = inputcharacters[j];
                    if(letter == singleOp)
                    {
                        foundoperators += singleOp;
                    }
                }
            }
            if(foundoperators.Length == 1)
            {
                Op = foundoperators[0];
            }
            else
            {
                throw new ArgumentException("Not valid input");
            }
            
        }
    }
}
