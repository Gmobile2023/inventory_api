using Abp.Application.Services.Dto;

namespace Inventory.Address.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }
    }
}