using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorPublicDto.Authorization.Users;
using IntegorPublicDto.Authorization.Users.Input;

namespace IntegorServicesInteraction.Authorization
{
    public interface IAuthorizationServiceAuthApi
	{
        Task<ServiceResponse<UserAccountInfoDto>> RegisterAsync(RegisterUserDto dto);
		Task<ServiceResponse<UserAccountInfoDto>> LoginAsync(LoginUserDto dto);
		Task<ServiceResponse<UserAccountInfoDto>> RefreshAsync(string refreshToken);
    }
}
