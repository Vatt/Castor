using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace Castor.Network
{
    public interface ICastorApplication
    {
        Guid AppId { get; }
        MemoryPool<byte> MemoryPool { get; }
    }
}
