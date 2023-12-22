using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegorServicesInteraction.Exceptions
{
	/// <summary>
	/// Throw it in cases when getting a microservice response having a structure that
	/// does not correspond expected one. E.g. in occurrence of an internal microservice bug
	/// that eventually affects the response result of committed request and causes getting
	/// some data receiving of which is not planned
	/// </summary>
	public class UnexpectedServiceResponseException : ApplicationException
	{
        public UnexpectedServiceResponseException(string? message) : base(message)
        {
        }

        public UnexpectedServiceResponseException(string? message, Exception? innerException)
			: base(message, innerException)
        {
        }

        public UnexpectedServiceResponseException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{
		}
	}
}
