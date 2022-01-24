using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace PillarOfAutumn.Management
{
    /// <summary>
    /// Provide the abstraction of ability
    /// to control file accesses.
    /// </summary>
    public interface IAccessController
    {
        /// <summary>
        /// The accessor.
        /// </summary>
        public Process Process { get; }

        /// <summary>
        /// The file which is about to be accessed.
        /// </summary>
        public FileInfo Target { get; }


        /// <summary>
        /// The type of access.
        /// </summary>
        public AccessType Type { get; }

        /// <summary>
        /// Just deny the access of file.
        /// </summary>
        void Deny();


        /// <summary>
        /// Hijack the access progress of file.
        /// </summary>
        IAccessHijakcer Hijack();
    }
}
