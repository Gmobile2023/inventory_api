﻿namespace Inventory.Authorization.Delegation
{
    public interface IUserDelegationConfiguration
    {
        bool IsEnabled { get; set; }
    }
}