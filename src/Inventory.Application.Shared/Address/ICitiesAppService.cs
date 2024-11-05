using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HLS.Topup.Address.Dtos;
using Inventory.Address.Dtos;
using Inventory.Dto;

namespace Inventory.Address
{
    public interface ICitiesAppService : IApplicationService 
    {
        Task<PagedResultDto<GetCityForViewDto>> GetAll(GetAllCitiesInput input);

        Task<GetCityForViewDto> GetCityForView(int id);

		Task<GetCityForEditOutput> GetCityForEdit(EntityDto input);

		Task CreateOrEdit(CreateOrEditCityDto input);

		Task Delete(EntityDto input);

		// Task<FileDto> GetCitiesToExcel(GetAllCitiesForExcelInput input);

		
		Task<List<CityCountryLookupTableDto>> GetAllCountryForTableDropdown();
		
    }
}