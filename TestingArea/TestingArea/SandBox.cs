using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlayGround
{
    public class SandBox
    {
        public void Main()
        {

        }

        public bool match(string s)
        {
            return Regex.IsMatch(s,"^0x[a-fA-F1-9]+$");
        }

        public object Evalu(Func<string, double> lookup)
        {
            return lookup("cat");  
        }

        static int Choose(Func<int, int, bool>f, int x, int y)
        {
            if (f(x,y))
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
