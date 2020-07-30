using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Castor.Network.Abstractions
{
    public interface IUdpApplication : IAsyncDisposable
    {
        Guid AppId { get; }
        IUdpProtocol UdpProtocol { get; }
        Task ExecutionTask { get; }

        Task StartAsync();
        Task StopAsync();

    }
}
