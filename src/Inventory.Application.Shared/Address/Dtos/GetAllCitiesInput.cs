using Abp.Application.Services.Dto;

namespace Inventory.Address.Dtos
{
    public class GetAllCitiesInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }

		public string CityNameFilter { get; set; }

		public int? StatusFilter { get; set; }


		 public string CountryCountryNameFilter { get; set; }

		 
    }
}