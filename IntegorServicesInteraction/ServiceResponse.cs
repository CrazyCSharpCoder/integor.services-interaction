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
		public string[] SetCookieHeaders { get; }

		public TResponseObject? Value { get; }
		public IResponseError[]? Errors { get; }

        public ServiceResponse(int statusCode)
        {
			StatusCode = statusCode;
			SetCookieHeaders = new string[0];
        }

        public ServiceResponse(int statusCode, TResponseObject? value, IEnumerable<string> setCookieHeaders)
		{
			StatusCode = statusCode;
			Value = value;
			SetCookieHeaders = setCookieHeaders?.ToArray() ?? throw new ArgumentNullException(nameof(setCookieHeaders));
		}

        public ServiceResponse(int statusCode, IEnumerable<IResponseError> errors, IEnumerable<string> setCookieHeaders)
		{
			StatusCode = statusCode;
			Errors = errors?.ToArray() ?? throw new ArgumentNullException(nameof(errors));
			SetCookieHeaders = setCookieHeaders?.ToArray() ?? throw new ArgumentNullException(nameof(setCookieHeaders));
		}

        public ServiceResponse(int statusCode, TResponseObject? value)
			: this(statusCode, value, new string[0])
        {
        }

		public ServiceResponse(int statusCode, IEnumerable<IResponseError> errors)
			: this(statusCode, errors, new string[0])
		{
		}
	}
}
