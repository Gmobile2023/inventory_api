using System.ComponentModel.DataAnnotations;

namespace Gmobile.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}