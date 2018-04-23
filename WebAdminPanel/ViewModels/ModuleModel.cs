using EmbeddedServer.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdminPanel.ViewModels
{
    public class ModuleModel
    {
        public string DeviceName { get; set; }
        public Module module { get; set; }

        public Int32 Value { get; set; }
        public string Type { get; set; }
        public string StrVal { get; set; }
        public bool HaveTrigger { get; set; }

        public bool EditShow { get; set; }

        public bool DetailsShow { get; set; }
    }
}
