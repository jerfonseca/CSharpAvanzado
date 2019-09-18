using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita
{
    public class CComplejo
    {
        public int a { get; set; }
        public int b { get; set; }

        public CComplejo(int pa,int pb)
        {
            a = pa;
            b = pb;
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}i", a, b);
        }

        //Se indica que tipo de Clase se puede convertir
        public static explicit operator CReal(CComplejo pi)
        {
            CReal temp = new CReal();
            temp.R = pi.a;
            return temp;
        }
    }
}
