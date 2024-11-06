﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HLS.Topup.Address.Dtos;
using Inventory.Address.Dtos;
using Inventory.Dto;

namespace Inventory.Address
{
    public interface IWardsAppService : IApplicationService 
    {
        Task<PagedResultDto<GetWardForViewDto>> GetAll(GetAllWardsInput input);

        Task<GetWardForViewDto> GetWardForView(int id);

		Task<GetWardForEditOutput> GetWardForEdit(EntityDto input);

		Task CreateOrEdit(CreateOrEditWardDto input);

		Task Delete(EntityDto input);

		// Task<FileDto> GetWardsToExcel(GetAllWardsForExcelInput input);

		
		Task<List<WardDistrictLookupTableDto>> GetAllDistrictForTableDropdown();
		Task<GetWardForViewDto> GetTestWard();
		
    }
}