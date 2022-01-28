using System;
using System.Threading.Tasks;
using Gas.Admin.Models.Device;
using Gas.Admin.Signalr;
using Gas.Shared.Repository.Device;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace Gas.Admin.HostedServices
{
    public class DeviceHubWorker
    {

        private readonly DeviceRepository _deviceRepository;
        private IHubContext<DeviceHub> _hubContext;

        public DeviceHubWorker(IHubContext<DeviceHub> hubContext, DeviceRepository deviceRepository)
        {
            _hubContext = hubContext;
            _deviceRepository = deviceRepository;
        }

        public async Task DeviceConfigUpdated(string key, DateTime date)
        {
            var device = _deviceRepository.GetByKey(key);
            if (device != null)
            {
                DeviceInfoResponse response = new DeviceInfoResponse();
                response.key = key;
                response.date = date;
                response.dppastaci = device.DeviceConfig.dppastaci;
                response.flowpast = device.DeviceConfig.flowpast;
                response.flowsarqac = device.DeviceConfig.flowsarqac;
                response.presspastaci = device.DeviceConfig.presspastaci;
                await _hubContext.Clients.All.SendAsync("DeviceInfo", JsonConvert.SerializeObject(response));
            }
        }
        public async Task DeviceInfo(DeviceInfoResponse response)
        {
            await _hubContext.Clients.All.SendAsync("DeviceInfo", JsonConvert.SerializeObject(response));
        }
    }
};