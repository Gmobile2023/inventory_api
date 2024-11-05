using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Inventory.Common;

namespace Inventory.Address
{
    [Table("Cities")]
    public class City : Entity, IMayHaveTenant
    {
        public int? TenantId { get; set; }


        [Required]
        [StringLength(CityConsts.MaxCityCodeLength, MinimumLength = CityConsts.MinCityCodeLength)]
        public virtual string CityCode { get; set; }

        [Required]
        [StringLength(CityConsts.MaxCityNameLength, MinimumLength = CityConsts.MinCityNameLength)]
        public virtual string CityName { get; set; }

        public virtual CommonConst.CityStatus Status { get; set; }


        public virtual int? CountryId { get; set; }

        [ForeignKey("CountryId")] public Country CountryFk { get; set; }
        
        [StringLength(50)]
        public virtual string RefCode { get; set; }
    }
}