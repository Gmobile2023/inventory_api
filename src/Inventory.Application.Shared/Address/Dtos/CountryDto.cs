using Abp.Application.Services.Dto;
using Inventory.Common;

namespace Inventory.Address.Dtos
{
    public class CountryDto : EntityDto
    {
		public string CountryCode { get; set; }

		public string CountryName { get; set; }

		public CommonConst.CountryStatus Status { get; set; }



    }
}
