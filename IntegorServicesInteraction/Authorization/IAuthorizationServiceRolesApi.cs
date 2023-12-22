using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorPublicDto.Authorization.Roles;

namespace IntegorServicesInteraction.Authorization
{
    public interface IAuthorizationServiceRolesApi
	{
		Task<ServiceResponse<UserRoleFullDto[]>> GetAllAsync();
    }
}
