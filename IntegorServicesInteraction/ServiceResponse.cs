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
		public Dictionary<string, string> Cookies { get; }

		public TResponseObject? Value { get; }
		public IResponseError[]? Errors { get; }

        public ServiceResponse()
        {
			Cookies = new Dictionary<string, string>();
        }

        public ServiceResponse(TResponseObject value, Dictionary<string, string> cookies)
		{
			Value = value ?? throw new ArgumentNullException(nameof(value));
			Cookies = cookies ?? throw new ArgumentNullException(nameof(cookies));
		}

        public ServiceResponse(IEnumerable<IResponseError> errors, Dictionary<string, string> cookies)
		{
			Errors = errors?.ToArray() ?? throw new ArgumentNullException(nameof(errors));
			Cookies = cookies ?? throw new ArgumentNullException(nameof(cookies));
		}

        public ServiceResponse(TResponseObject value) : this(value, new Dictionary<string, string>())
        {
        }

		public ServiceResponse(IEnumerable<IResponseError> errors) : this(errors, new Dictionary<string, string>())
		{
		}
	}
}
