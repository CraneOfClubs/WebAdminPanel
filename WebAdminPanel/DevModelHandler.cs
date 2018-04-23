using EmbeddedServer.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAdminPanel.ViewModels;

namespace WebAdminPanel
{
    public static class DevModelHandler
    {
        public static List<DeviceModel> deviceModel = new List<DeviceModel>();
        public static List<DeviceModel> GenerateDeviceModel()
        {
            var ret = new List<DeviceModel>();
            var devs = DeviceStorage.Devices;
            foreach (var d in devs)
            {
                ret.Add(new DeviceModel { DeviceInfo = d, DetailsShow = false, EditShow = false });
            }
            return ret;
        }


    }
}
