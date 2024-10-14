using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Gmobile.Dto;

namespace Gmobile.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
