using System.ComponentModel.DataAnnotations;

namespace Gmobile.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
