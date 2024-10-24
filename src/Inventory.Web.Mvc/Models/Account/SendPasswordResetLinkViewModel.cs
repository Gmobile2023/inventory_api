using System.ComponentModel.DataAnnotations;

namespace Inventory.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}