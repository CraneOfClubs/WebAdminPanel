using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmbeddedServer.Storages;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using EmbeddedServer;
using System.Threading;

namespace WebAdminPanel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DeviceStorage.LoadDevicesFromDb();
            new Thread(() =>
            {
                TcpServer server = new TcpServer(5555);
            }).Start();
            new Thread(() =>
            {
                while (true)
                {
                    Scheduler.InvokeReadyEvents();
                    Thread.Sleep(500);
                }

            }).Start();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
