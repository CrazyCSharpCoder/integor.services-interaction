using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegorServicesInteraction.Exceptions
{
	/// <summary>
	/// Thrown in cases when could not establish connection to some application service
	/// </summary>
	public class ServiceConnectionFailedException : ApplicationException
	{
		private const string _defaultMessage = "Could not establish connection to the application service";

        public ServiceConnectionFailedException() : base(_defaultMessage)
        {
        }

        public ServiceConnectionFailedException(Exception? innerException)
			: base(_defaultMessage, innerException)
        {
        }

        public ServiceConnectionFailedException(string? message) : base(message)
        {
        }

        public ServiceConnectionFailedException(string? message, Exception? innerException)
			: base(message, innerException)
        {
        }

        public ServiceConnectionFailedException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
        {   
        }
    }
}
