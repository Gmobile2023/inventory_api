using Abp.AutoMapper;
using AuthServer.Authorization.Users.Dto;

namespace AuthServer.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
