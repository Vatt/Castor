using System;
using System.Collections.Generic;
using System.Text;

namespace Castor.Network.Protocol
{
    public struct CastorProtocolHeader
    {
        public Guid AppIdTo;
        public Guid AppIdFrom;
        public int Size;
    }
}
