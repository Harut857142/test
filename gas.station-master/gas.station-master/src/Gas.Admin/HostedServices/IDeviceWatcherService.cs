using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Gas.Admin.HostedServices
{
    public interface IDeviceWatcherService
    {
        Task DoWork(CancellationToken stoppingToken);
    }
}