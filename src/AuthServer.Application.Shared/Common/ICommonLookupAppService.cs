using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AuthServer.Common.Dto;
using AuthServer.Editions.Dto;

namespace AuthServer.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<FindUsersOutputDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}