using EmbeddedServer.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdminPanel.ViewModels
{
    public class DeviceModel
    {
        public DeviceInfo DeviceInfo { get; set; }

        public bool EditShow { get; set; }

        public bool DetailsShow { get; set; }
    }
}
