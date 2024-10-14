using System.Collections.Generic;
using Gmobile.Authorization.Users.Dto;
using Gmobile.Dto;

namespace Gmobile.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos, List<string> selectedColumns);
    }
}