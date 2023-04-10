using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorErrorsHandling;

namespace IntegorServicesInteraction
{
	public class UniversalServiceResponse : ServiceResponse<object>
	{
		public UniversalServiceResponse(int statusCode, object? value = null)
			: base(statusCode, value)
		{
		}

		public UniversalServiceResponse(int statusCode, UserAuthentication authenticationResult, object? value = null)
			: base(statusCode, authenticationResult, value)
		{
		}

		public UniversalServiceResponse(int statusCode, IEnumerable<IResponseError> errors)
			: base(statusCode, errors)
		{
		}

		public UniversalServiceResponse(int statusCode, UserAuthentication authenticationResult, IEnumerable<IResponseError> errors)
			: base(statusCode, authenticationResult, errors)
		{
		}
	}
}
