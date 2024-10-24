using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Inventory.Dto;

namespace Inventory.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
