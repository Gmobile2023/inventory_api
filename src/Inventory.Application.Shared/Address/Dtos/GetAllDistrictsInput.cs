using Abp.Application.Services.Dto;

namespace Inventory.Address.Dtos
{
    public class GetAllDistrictsInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }

		public string DistrictCodeFilter { get; set; }

		public string DistrictNameFilter { get; set; }

		public int? StatusFilter { get; set; }


		 public string CityCityNameFilter { get; set; }

		 
    }
}