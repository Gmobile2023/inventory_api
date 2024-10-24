using System.Collections.Generic;
using Inventory.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Inventory.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
