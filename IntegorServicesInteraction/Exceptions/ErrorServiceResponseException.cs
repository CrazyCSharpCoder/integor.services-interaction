using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorErrorsHandling;

namespace IntegorServicesInteraction.Exceptions
{
	/// <summary>
	/// Throw it when getting response containing errors for further their processing
	/// </summary>
	public class ErrorServiceResponseException : ApplicationException
	{
		private const string _defaultMessage = "Errors in the requested application service occurred";

		public IEnumerable<IResponseError> Errors { get; }

		public ErrorServiceResponseException(IEnumerable<IResponseError> errors) : this(errors, _defaultMessage, null)
        {
        }

        public ErrorServiceResponseException(IEnumerable<IResponseError> errors, string? message)
			 : this(errors, message, null)
		{
		}

		public ErrorServiceResponseException(IEnumerable<IResponseError> errors, Exception? innerException)
			: this(errors, _defaultMessage, innerException)
		{
		}

		public ErrorServiceResponseException(IEnumerable<IResponseError> errors, string? message, Exception? innerException)
			: base(message, innerException)
		{
			Errors = errors;
		}

		// TODO add constructor with serialization
	}
}
