using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesAplicacion
{
    class CMetodos
    {
        public void Calcular()
        {
            int a = 1, b = 0;
            //int result = a / b;
            //Se crea la instancia de nuestra clase de Excepcion
            CMetodoException ex=new CMetodoException("Error al realizar el calculo", DateTime.Now);

            //Informacion propia en las excepciones
            ex.HelpLink = "http://google.com.ni";

            throw ex;
        }
    }

    ////V1
    ////todas las clases de excepcion propias deben ser publicas
    //public class CMetodoException : ApplicationException
    //{
    //    private string mensaje;
    //    public DateTime Momento { get; set; }

    //    public CMetodoException(string pMensaje, DateTime pMomento)
    //    {
    //        mensaje = pMensaje;
    //        Momento = pMomento;
    //    }

    //    public override string Message
    //    {
    //        get {
    //            return string.Format("Mensaje de la excepcion=> {0}", mensaje);
    //        }
    //    }
    //}

    ////V2
    ////No es necesario hacer override de Message
    ////si pasamos a la clase padre la info en el constructor
    //public class CMetodoException : ApplicationException
    //{
    //    private string mensaje;
    //    public DateTime Momento { get; set; }

    //    public CMetodoException(string pMensaje, DateTime pMomento) : base(pMensaje)
    //    {
    //        mensaje = pMensaje;
    //        Momento = pMomento;
    //    }
    //}


    //V3
    //Excepcion completa de acuerdo con las reglas de .NET
    //Derivar de Exception/ApplicationException
    //Usar [System.Serializable]
    //Definir constructor default
    //Definir constructor que coloca Message en la herencia
    //Definir constructor que maneja excepciones internas
    //Definir constructor que maneja la serializacion del tipo

    [Serializable]
    public class CMetodoException : ApplicationException
    {
        public CMetodoException() { }
        public CMetodoException(string pMensaje): base(pMensaje) { }
        public CMetodoException(string pMensaje, 
                                Exception inner)
            : base(pMensaje, inner) { }

        protected CMetodoException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context
            ) : base(info, context) { }

        //Propiedades adicionales
        public DateTime Momento { get; set; }

        public CMetodoException(string pMensaje, DateTime pMomento) : base(pMensaje)
        {
            Momento = pMomento;
        }
    }
}
