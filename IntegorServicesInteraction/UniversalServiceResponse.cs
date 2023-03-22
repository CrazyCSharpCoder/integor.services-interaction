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
		public UniversalServiceResponse(int statusCode) : base(statusCode)
		{
		}

		public UniversalServiceResponse(int statusCode, object value, IEnumerable<string> setCookieHeaders)
			: base(statusCode, value, setCookieHeaders)
		{
		}

		public UniversalServiceResponse(int statusCode, IEnumerable<IResponseError> errors, IEnumerable<string> setCookieHeaders)
			: base(statusCode, errors, setCookieHeaders)
		{
		}

		public UniversalServiceResponse(int statusCode, object value)
			: base(statusCode, value)
		{
		}

		public UniversalServiceResponse(int statusCode, IEnumerable<IResponseError> errors)
			: base(statusCode, errors)
		{
		}
	}
}
