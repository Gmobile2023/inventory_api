using Abp.AspNetCore.Mvc.Authorization;
using Gmobile.Authorization.Users.Profile;
using Gmobile.Graphics;
using Gmobile.Storage;

namespace Gmobile.Web.Controllers
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