using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Inventory.Common;

namespace Inventory.Address.Dtos
{
    public class CreateOrEditWardDto : EntityDto<int?>
    {

		[Required]
		[StringLength(WardConsts.MaxWardCodeLength, MinimumLength = WardConsts.MinWardCodeLength)]
		public string WardCode { get; set; }


		[Required]
		[StringLength(WardConsts.MaxWardNameLength, MinimumLength = WardConsts.MinWardNameLength)]
		public string WardName { get; set; }


		public CommonConst.WardStatus Status { get; set; }


		 public int DistrictId { get; set; }


    }
}
