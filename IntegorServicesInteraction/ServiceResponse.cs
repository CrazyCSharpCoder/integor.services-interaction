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
		public string[]? SetCookieHeaders { get; }

		public TResponseObject? Value { get; }
		public IResponseError[]? Errors { get; }

        public ServiceResponse(int statusCode, TResponseObject? value = null, IEnumerable<string>? setCookieHeaders = null)
		{
			StatusCode = statusCode;
			Value = value;
			SetCookieHeaders = setCookieHeaders?.ToArray();
		}

        public ServiceResponse(int statusCode, IEnumerable<IResponseError> errors, IEnumerable<string>? setCookieHeaders = null)
		{
			StatusCode = statusCode;
			Errors = errors?.ToArray() ?? throw new ArgumentNullException(nameof(errors));
			SetCookieHeaders = setCookieHeaders?.ToArray();
		}
	}
}
