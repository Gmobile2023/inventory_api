﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Inventory.Authorization.Users.Dto;

namespace Inventory.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<PagedResultDto<UserLoginAttemptDto>> GetUserLoginAttempts(GetLoginAttemptsInput input);
    }
}
