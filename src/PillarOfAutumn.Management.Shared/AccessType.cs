using System;
using System.Collections.Generic;
using System.Text;

namespace PillarOfAutumn.Management
{
    public enum AccessType
    {
        Read = 1,
        Write = 1 << 1,
        Create = 1 << 2
    }
}
