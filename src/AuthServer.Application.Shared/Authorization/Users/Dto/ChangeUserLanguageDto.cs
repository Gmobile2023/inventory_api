using System.ComponentModel.DataAnnotations;

namespace AuthServer.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
