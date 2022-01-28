using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Gas.Admin.HostedServices;

namespace Gas.Admin.Signalr
{
    public class DeviceHub : Hub
    {
        private readonly ILogger<DeviceHub> _logger;

        public DeviceHub(ILogger<DeviceHub> logger)
        {
            _logger = logger;
        }
        public async Task SendMessage(string user, string message, string myProjectId, string myProjectVal)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, myProjectId, myProjectVal);
        }
        public async Task UpdateInfo(string key, DateTime dateTime)
        {
            await Clients.All.SendAsync("UpdateInfo", key, dateTime);
        }
    }
}