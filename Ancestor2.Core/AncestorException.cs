using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ancestor
{
    /// <summary>
    /// Ancestor Exception
    /// </summary>
    [Serializable]
    public class AncestorException : Exception
    {
        public AncestorException()
        {
        }

        public AncestorException(string message) : base(message)
        {
        }

        public AncestorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AncestorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
