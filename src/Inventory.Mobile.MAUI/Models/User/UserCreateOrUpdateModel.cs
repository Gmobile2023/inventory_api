using Abp.AutoMapper;
using Inventory.Authorization.Users.Dto;

namespace Inventory.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
