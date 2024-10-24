using System.ComponentModel.DataAnnotations;

namespace Inventory.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}