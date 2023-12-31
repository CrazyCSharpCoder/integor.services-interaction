﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IntegorPublicDto.Authorization.Users;

namespace IntegorServicesInteraction.Authorization
{
    public interface IAuthorizationServiceUsersApi
	{
        Task<ServiceResponse<UserAccountInfoDto>> GetByIdAsync(int id);
        Task<ServiceResponse<UserAccountInfoDto>> GetByEmailAsync(string email);
    }
}
