using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PillarOfAutumn.Management
{
    /// <summary>
    /// Provide the abstraction of ability
    /// to control file accesses.
    /// </summary>
    public interface IAccessController
    {
        Process Process { get; }
        void Deny();
    }
}
