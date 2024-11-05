using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Inventory.Address.Dtos;
using Inventory.Dto;

namespace Inventory.Address
{
    public interface IDistrictsAppService : IApplicationService 
    {
        Task<PagedResultDto<GetDistrictForViewDto>> GetAll(GetAllDistrictsInput input);

        Task<GetDistrictForViewDto> GetDistrictForView(int id);

		Task<GetDistrictForEditOutput> GetDistrictForEdit(EntityDto input);

		Task CreateOrEdit(CreateOrEditDistrictDto input);

		Task Delete(EntityDto input);

		// Task<FileDto> GetDistrictsToExcel(GetAllDistrictsForExcelInput input);
		
		Task<List<DistrictCityLookupTableDto>> GetAllCityForTableDropdown();

	    Task<List<DistrictCityLookupTableDto>> GetDistrictByCity(int cityId);

    }
}