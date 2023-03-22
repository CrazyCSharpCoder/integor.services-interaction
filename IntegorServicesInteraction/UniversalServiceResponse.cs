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
		public UniversalServiceResponse(int statusCode, object? value = null, IEnumerable<string>? setCookieHeaders = null)
			: base(statusCode, value, setCookieHeaders)
		{
		}

		public UniversalServiceResponse(int statusCode, IEnumerable<IResponseError> errors, IEnumerable<string>? setCookieHeaders = null)
			: base(statusCode, errors, setCookieHeaders)
		{
		}
	}
}
