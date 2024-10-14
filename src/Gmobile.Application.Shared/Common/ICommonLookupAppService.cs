using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Gmobile.Common.Dto;
using Gmobile.Editions.Dto;

namespace Gmobile.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<FindUsersOutputDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}