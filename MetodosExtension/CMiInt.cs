using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    class CMiInt: ISaludador
    {
        private int a;

        public CMiInt(int pa)
        {
            a = pa;
        }
        public override string ToString()
        {
            return string.Format("Tu int es {0}", a);
        }
        public void Saludar()
        {
            Console.WriteLine("Hola desde mi int {0}", a);
        }
    }
}
