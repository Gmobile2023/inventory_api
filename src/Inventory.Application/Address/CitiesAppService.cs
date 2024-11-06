using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using HLS.Topup.Address.Dtos;
using Inventory.Address.Dtos;
using Inventory.Authorization;
using Inventory.Common;
using Inventory.Dto;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Address
{
    // [AbpAuthorize(AppPermissions.Pages_Cities)]
    public class CitiesAppService : InventoryAppServiceBase, ICitiesAppService
    {
        private readonly IRepository<City> _cityRepository;
        private readonly IRepository<Country, int> _lookup_countryRepository;


        public CitiesAppService(IRepository<City> cityRepository,
            IRepository<Country, int> lookup_countryRepository)
        {
            _cityRepository = cityRepository;
            _lookup_countryRepository = lookup_countryRepository;
        }

        public async Task<PagedResultDto<GetCityForViewDto>> GetAll(GetAllCitiesInput input)
        {
            var statusFilter = input.StatusFilter.HasValue
                ? (CommonConst.CityStatus) input.StatusFilter
                : default;

            var filteredCities = _cityRepository.GetAll()
                .Include(e => e.CountryFk)
                .WhereIf(!string.IsNullOrWhiteSpace(input.Filter),
                    e => false || e.CityCode.Contains(input.Filter) || e.CityName.Contains(input.Filter))
                .WhereIf(!string.IsNullOrWhiteSpace(input.CityNameFilter), e => e.CityName == input.CityNameFilter)
                .WhereIf(input.StatusFilter.HasValue && input.StatusFilter > -1, e => e.Status == statusFilter)
                .WhereIf(!string.IsNullOrWhiteSpace(input.CountryCountryNameFilter),
                    e => e.CountryFk != null && e.CountryFk.CountryName == input.CountryCountryNameFilter);

            var pagedAndFilteredCities = filteredCities
                .OrderByDescending(x=>x.Id)
                .PageBy(input);

            var cities = from o in pagedAndFilteredCities
                join o1 in _lookup_countryRepository.GetAll() on o.CountryId equals o1.Id into j1
                from s1 in j1.DefaultIfEmpty()
                select new GetCityForViewDto()
                {
                    City = new CityDto
                    {
                        CityCode = o.CityCode,
                        CityName = o.CityName,
                        Status = o.Status,
                        CountryId = o.CountryId,
                        Id = o.Id
                    },
                    CountryCountryName = s1 == null || s1.CountryName == null ? "" : s1.CountryName.ToString()
                };

            var totalCount = await filteredCities.CountAsync();

            return new PagedResultDto<GetCityForViewDto>(
                totalCount,
                await cities.ToListAsync()
            );
        }

        public async Task<GetCityForViewDto> GetCityForView(int id)
        {
            var city = await _cityRepository.GetAsync(id);

            var output = new GetCityForViewDto {City = ObjectMapper.Map<CityDto>(city)};

            if (output.City.CountryId != null)
            {
                var _lookupCountry = await _lookup_countryRepository.FirstOrDefaultAsync((int) output.City.CountryId);
                output.CountryCountryName = _lookupCountry?.CountryName?.ToString();
            }

            return output;
        }
        
        public async Task<GetCityForEditOutput> GetCityForEdit(EntityDto input)
        {
            var city = await _cityRepository.FirstOrDefaultAsync(input.Id);

            var output = new GetCityForEditOutput {City = ObjectMapper.Map<CreateOrEditCityDto>(city)};

            if (output.City.CountryId != null)
            {
                var _lookupCountry = await _lookup_countryRepository.FirstOrDefaultAsync((int) output.City.CountryId);
                output.CountryCountryName = _lookupCountry?.CountryName?.ToString();
            }

            return output;
        }

        public async Task CreateOrEdit(CreateOrEditCityDto input)
        {
            if (input.Id == null)
            {
                await Create(input);
            }
            else
            {
                await Update(input);
            }
        }
        
        protected virtual async Task Create(CreateOrEditCityDto input)
        {
            var city = ObjectMapper.Map<City>(input);


            if (AbpSession.TenantId != null)
            {
                city.TenantId = (int?) AbpSession.TenantId;
            }


            await _cityRepository.InsertAsync(city);
        }
        
        protected virtual async Task Update(CreateOrEditCityDto input)
        {
            var city = await _cityRepository.FirstOrDefaultAsync((int) input.Id);
            ObjectMapper.Map(input, city);
        }

        // [AbpAuthorize(AppPermissions.Pages_Cities_Delete)]
        public async Task Delete(EntityDto input)
        {
            await _cityRepository.DeleteAsync(input.Id);
        }

        // public async Task<FileDto> GetCitiesToExcel(GetAllCitiesForExcelInput input)
        // {
        //     var statusFilter = input.StatusFilter.HasValue
        //         ? (CommonConst.CityStatus) input.StatusFilter
        //         : default;
        //
        //     var filteredCities = _cityRepository.GetAll()
        //         .Include(e => e.CountryFk)
        //         .WhereIf(!string.IsNullOrWhiteSpace(input.Filter),
        //             e => false || e.CityCode.Contains(input.Filter) || e.CityName.Contains(input.Filter))
        //         .WhereIf(!string.IsNullOrWhiteSpace(input.CityNameFilter), e => e.CityName == input.CityNameFilter)
        //         .WhereIf(input.StatusFilter.HasValue && input.StatusFilter > -1, e => e.Status == statusFilter)
        //         .WhereIf(!string.IsNullOrWhiteSpace(input.CountryCountryNameFilter),
        //             e => e.CountryFk != null && e.CountryFk.CountryName == input.CountryCountryNameFilter);
        //
        //     var query = (from o in filteredCities
        //         join o1 in _lookup_countryRepository.GetAll() on o.CountryId equals o1.Id into j1
        //         from s1 in j1.DefaultIfEmpty()
        //         select new GetCityForViewDto()
        //         {
        //             City = new CityDto
        //             {
        //                 CityCode = o.CityCode,
        //                 CityName = o.CityName,
        //                 Status = o.Status,
        //                 Id = o.Id
        //             },
        //             CountryCountryName = s1 == null || s1.CountryName == null ? "" : s1.CountryName.ToString()
        //         });
        //
        //
        //     var cityListDtos = await query.ToListAsync();
        //
        //     return _citiesExcelExporter.ExportToFile(cityListDtos);
        // }


        // [AbpAuthorize(AppPermissions.Pages_Cities)]
        public async Task<List<CityCountryLookupTableDto>> GetAllCountryForTableDropdown()
        {
            return await _lookup_countryRepository.GetAll()
                .Select(country => new CityCountryLookupTableDto
                {
                    Id = country.Id,
                    DisplayName = country == null || country.CountryName == null ? "" : country.CountryName.ToString()
                }).ToListAsync();
        }
    }
}
