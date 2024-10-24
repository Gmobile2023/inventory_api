using System.Collections.Generic;
using Inventory.Authorization.Users.Dto;
using Inventory.Dto;

namespace Inventory.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}