using Abp.Application.Services.Dto;
using Inventory.Common;

namespace Inventory.Address.Dtos
{
    public class DistrictDto : EntityDto
    {
        public string DistrictCode { get; set; }

        public string DistrictName { get; set; }

        public CommonConst.DistrictStatus Status { get; set; }


        public int CityId { get; set; }
    }
}
