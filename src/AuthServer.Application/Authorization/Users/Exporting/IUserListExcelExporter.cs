using System.Collections.Generic;
using AuthServer.Authorization.Users.Dto;
using AuthServer.Dto;

namespace AuthServer.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos, List<string> selectedColumns);
    }
}