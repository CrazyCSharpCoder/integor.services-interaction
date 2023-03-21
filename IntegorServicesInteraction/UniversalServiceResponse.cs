using IntegorErrorsHandling;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegorServicesInteraction
{
	public class UniversalServiceResponse : ServiceResponse<object>
	{
		public UniversalServiceResponse(int statusCode) : base(statusCode)
		{
		}

		public UniversalServiceResponse(int statusCode, object value, Dictionary<string, string> cookies)
			: base(statusCode, value, cookies)
		{
		}

		public UniversalServiceResponse(int statusCode, IEnumerable<IResponseError> errors, Dictionary<string, string> cookies)
			: base(statusCode, errors, cookies)
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
