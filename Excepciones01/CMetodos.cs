using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones01
{
    class CMetodos
    {
        public void Calcular()
        {
            int a = 1, b = 0;
            //int result = a / b;
            Exception ex=new Exception("Error al realizar el calculo");

            //Informacion propia en las excepciones
            ex.HelpLink = "http://google.com.ni";

            //Agregar informacion extra
            ex.Data.Add("Momento:", string.Format("Ocurrio en {0}", DateTime.Now));

            throw ex;
        }
    }
}
