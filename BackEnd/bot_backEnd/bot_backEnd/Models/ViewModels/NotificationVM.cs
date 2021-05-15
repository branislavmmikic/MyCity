using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.Models.ViewModels
{
    public class NotificationVM
    {
        public JObject Notification{ get; set; }
        public JObject SecondNotification { get; set; }
    }
}
