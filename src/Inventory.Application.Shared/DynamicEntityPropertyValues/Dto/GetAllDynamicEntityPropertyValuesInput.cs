using System.ComponentModel.DataAnnotations;

namespace Inventory.DynamicEntityPropertyValues.Dto
{
    public class GetAllDynamicEntityPropertyValuesInput
    {
        [Required]
        public string EntityFullName { get; set; }

        [Required]
        public string EntityId { get; set; }
    }
}
