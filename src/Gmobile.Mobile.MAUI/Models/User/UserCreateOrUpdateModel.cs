using Abp.AutoMapper;
using Gmobile.Authorization.Users.Dto;

namespace Gmobile.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
