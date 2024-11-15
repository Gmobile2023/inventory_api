﻿using Abp.AspNetCore.Mvc.Authorization;
using Inventory.Authorization;
using Inventory.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace Inventory.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}