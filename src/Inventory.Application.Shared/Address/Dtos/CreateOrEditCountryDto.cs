using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Inventory.Common;

namespace Inventory.Address.Dtos
{
    public abstract class CreateOrEditCountryDto : EntityDto<int?>
    {

		[Required]
		[StringLength(CountryConsts.MaxCountryCodeLength, MinimumLength = CountryConsts.MinCountryCodeLength)]
		public string CountryCode { get; set; }


		[Required]
		[StringLength(CountryConsts.MaxCountryNameLength, MinimumLength = CountryConsts.MinCountryNameLength)]
		public string CountryName { get; set; }


		public CommonConst.CountryStatus Status { get; set; }



    }
}
