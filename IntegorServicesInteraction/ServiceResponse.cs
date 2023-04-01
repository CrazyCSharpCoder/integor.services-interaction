using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorErrorsHandling;

namespace IntegorServicesInteraction
{
	public class ServiceResponse<TResponseObject> where TResponseObject : class
	{
		public int StatusCode { get; }
		public UserAuthentication AuthenticationResult { get; }

		public TResponseObject? Value { get; }
		public IResponseError[]? Errors { get; }

		public bool Ok => StatusCode >= 200 && StatusCode < 300;

        public ServiceResponse(int statusCode, UserAuthentication authenticationResult, TResponseObject? value = null)
		{
			StatusCode = statusCode;

			Value = value;
			AuthenticationResult = authenticationResult;
		}

        public ServiceResponse(int statusCode, UserAuthentication authenticationResult, IEnumerable<IResponseError> errors)
		{
			StatusCode = statusCode;

			Errors = errors?.ToArray() ?? throw new ArgumentNullException(nameof(errors));
			AuthenticationResult = authenticationResult;
		}
	}
}
