using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYpractice
{
    public class processor
    {
        public int add(int firstnum, int secondnum)
        {
            int result = firstnum + secondnum;
            return result;
        }

        public int subtract(int firstnum, int secondnum)
        {
            int result = firstnum - secondnum;
            return result;
        }

        public int multiply(int firstnum, int secondnum)
        {
            int result = firstnum * secondnum;
            return result;
        }

        public double divide(double firstnum, double secondnum)
        {
            double result = firstnum / secondnum;
            return result;
        }
    }
}
