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
		public Dictionary<string, string> Cookies { get; }

		public TResponseObject? Value { get; }
		public IResponseError[]? Errors { get; }

        public ServiceResponse(int statusCode)
        {
			StatusCode = statusCode;
			Cookies = new Dictionary<string, string>();
        }

        public ServiceResponse(int statusCode, TResponseObject value, Dictionary<string, string> cookies)
		{
			StatusCode = statusCode;
			Value = value ?? throw new ArgumentNullException(nameof(value));
			Cookies = cookies ?? throw new ArgumentNullException(nameof(cookies));
		}

        public ServiceResponse(int statusCode, IEnumerable<IResponseError> errors, Dictionary<string, string> cookies)
		{
			StatusCode = statusCode;
			Errors = errors?.ToArray() ?? throw new ArgumentNullException(nameof(errors));
			Cookies = cookies ?? throw new ArgumentNullException(nameof(cookies));
		}

        public ServiceResponse(int statusCode, TResponseObject value)
			: this(statusCode, value, new Dictionary<string, string>())
        {
        }

		public ServiceResponse(int statusCode, IEnumerable<IResponseError> errors)
			: this(statusCode, errors, new Dictionary<string, string>())
		{
		}
	}
}
