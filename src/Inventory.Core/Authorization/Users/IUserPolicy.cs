﻿using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Inventory.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
