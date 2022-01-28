using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Gas.Admin.Models;
using Gas.Admin.Models.Device;
using Gas.Shared.Models.Core.Device;
using Gas.Shared.Repository.Device;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Gas.Admin.HostedServices
{
    public class DeviceWatcherService : IDeviceWatcherService
    {
        private readonly ILogger _logger;
        private readonly DeviceHubWorker _hubWorker;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMemoryCache _memoryCache;
    
        public DeviceWatcherService(ILogger<DeviceWatcherService> logger,
            DeviceHubWorker hubWorker,
            IMemoryCache memoryCache,
            IServiceProvider serviceProvider
            
            )
        {
            _memoryCache = memoryCache;
            _logger = logger;
            _hubWorker = hubWorker;
            _serviceProvider = serviceProvider;
        }
        public async Task DoWork(CancellationToken stoppingToken)
        {
            try
            {
                var cts = new CancellationTokenSource();
                
                while (!stoppingToken.IsCancellationRequested)
                {
                    await Task.Delay(2000, stoppingToken);

                    var deviceRepository = (DeviceRepository) _serviceProvider.GetService<DeviceRepository>();
                    var databaseDevices = deviceRepository.GetList(new DeviceFilter(1, 10000)).Results;
                    // var devices = _memoryCache.Get<IDictionary<string, DeviceCacheModel>>("devices");
                    // if (devices == null)
                    // {
                    //     devices = new Dictionary<string, DeviceCacheModel>();
                    // }
                    foreach (var databaseDevice in databaseDevices)
                    {
                        DeviceInfoResponse response = new DeviceInfoResponse();

                        // var current = devices[databaseDevice.Key];
                        long timestamp = 0;
                        response.key = databaseDevice.Key;
                        response.date = databaseDevice.DeviceConfig.ModificationDate;
                        response.dppastaci = databaseDevice.DeviceConfig.dppastaci;
                        response.flowpast = databaseDevice.DeviceConfig.flowpast;
                        response.flowsarqac = databaseDevice.DeviceConfig.flowsarqac;
                        response.presspastaci = databaseDevice.DeviceConfig.presspastaci;
                        response.active = (DateTimeOffset.Now.ToUnixTimeMilliseconds() - timestamp) < 5000;

                        await _hubWorker.DeviceInfo(response);
                    }
                }
                    
                cts.Cancel();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            
        }
    }
    
}