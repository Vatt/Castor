using System;
using System.Threading.Tasks;

namespace Castor.Network.Abstractions
{
    public interface IUdpProtocol : IDisposable
    {
        ValueTask OnMessage(byte[] data);
    }
}