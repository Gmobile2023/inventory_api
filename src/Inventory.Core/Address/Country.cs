using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Inventory.Common;

namespace Inventory.Address
{
	[Table("Countries")]
    public class Country : AuditedEntity , IMayHaveTenant
    {
			public int? TenantId { get; set; }


		[Required]
		[StringLength(CountryConsts.MaxCountryCodeLength, MinimumLength = CountryConsts.MinCountryCodeLength)]
		public virtual string CountryCode { get; set; }

		[Required]
		[StringLength(CountryConsts.MaxCountryNameLength, MinimumLength = CountryConsts.MinCountryNameLength)]
		public virtual string CountryName { get; set; }

		public virtual CommonConst.CountryStatus Status { get; set; }


    }
}
