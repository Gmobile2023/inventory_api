using Abp.Application.Services.Dto;
using Inventory.Common;

namespace Inventory.Address.Dtos
{
    public class CityDto : EntityDto
    {
		public string CityCode { get; set; }

		public string CityName { get; set; }

		public CommonConst.CityStatus Status { get; set; }


		 public int? CountryId { get; set; }


    }
}
