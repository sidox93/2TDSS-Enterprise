using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Exceptions
{
    //exception -> tab tab

    [Serializable]
    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException() { }
        public ValorInvalidoException(string message) : base(message) { }
        public ValorInvalidoException(string message, Exception inner) : base(message, inner) { }
        protected ValorInvalidoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
}
