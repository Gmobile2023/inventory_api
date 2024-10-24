using System.Collections.Generic;
using Abp.Notifications;

namespace Inventory.Web.Areas.AppAreaName.Models.Notifications
{
    public class CreateMassNotificationViewModel
    {
        public List<string> TargetNotifiers { get; set; }
    
        public NotificationSeverity Severity { get; set; }
    }
}