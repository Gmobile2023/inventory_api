using Abp.AspNetCore.Mvc.Authorization;
using AuthServer.Authorization.Users.Profile;
using AuthServer.Graphics;
using AuthServer.Storage;

namespace AuthServer.Web.Controllers
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