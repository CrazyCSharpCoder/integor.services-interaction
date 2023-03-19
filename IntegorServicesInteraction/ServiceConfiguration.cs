using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IntegorServicesInteraction
{
	public abstract class ServiceConfiguration
	{
		public string Url { get; set; } = null!;
		public string ApiLocalPath { get; set; } = null!;

		public string GetFullApiPath() => Path.Combine(Url, ApiLocalPath);
	}
}
