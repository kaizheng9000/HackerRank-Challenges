using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    public class RepeatedStringSolution
    {
        public long SolveRepeatedString(String s, long n)
        {
            if(s.Count() == 1 && s.Equals("a"))
            {
                return n;
            }

            long countInOne = 0;

            long finalCount = 0;

            // Count the number of "a" in the string
            for(int i = 0; i < s.Count(); i++)
            {
                if(s[i].Equals('a'))
                {
                    countInOne++;
                }
            }

            long multiply = n / s.Count();

            finalCount = countInOne * multiply;

            if(n % s.Count() != 0)
            {     
                long remainder = n % s.Count();

                for (int i = 0; i < remainder; i++)
                {
                    if (s[i].Equals('a'))
                    {
                        finalCount++;
                    }
                }
            }


            return finalCount;
        }
        
    }
}
