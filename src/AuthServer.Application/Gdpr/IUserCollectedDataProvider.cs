using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using AuthServer.Dto;

namespace AuthServer.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
