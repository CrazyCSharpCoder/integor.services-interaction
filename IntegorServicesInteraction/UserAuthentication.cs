using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegorServicesInteraction
{
	public class UserAuthentication
	{
		public string? AccessToken { get; }
		public string? RefreshToken { get; }

        public UserAuthentication(string? accessToken, string? refreshToken)
        {
			AccessToken = accessToken;
			RefreshToken = refreshToken;
		}
    }
}
