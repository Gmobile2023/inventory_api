using System.ComponentModel.DataAnnotations;

namespace Inventory.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
