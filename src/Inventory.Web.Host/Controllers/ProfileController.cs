using Abp.AspNetCore.Mvc.Authorization;
using Inventory.Authorization.Users.Profile;
using Inventory.Graphics;
using Inventory.Storage;

namespace Inventory.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageValidator imageValidator) :
            base(tempFileCacheManager, profileAppService, imageValidator)
        {
        }
    }
}