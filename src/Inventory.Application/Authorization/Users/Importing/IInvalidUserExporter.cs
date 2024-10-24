using System.Collections.Generic;
using Inventory.Authorization.Users.Importing.Dto;
using Inventory.Dto;

namespace Inventory.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
