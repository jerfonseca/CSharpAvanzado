using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita
{
    public class CReal
    {
        public double R { get; set; }

        public CReal()
        {

        }
        public CReal(double pr)
        {
            R = pr;
        }
        public override string ToString()
        {
            return string.Format("r={0}", R);
        }
    }
}
