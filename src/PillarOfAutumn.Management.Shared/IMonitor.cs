using System;
using System.Collections.Generic;
using System.Text;

namespace PillarOfAutumn.Management
{
    /// <summary>
    /// The abstraction of the logic of 
    /// file accessing monitor. It should
    /// provides the ability to enable callers
    /// to be aware of file accessing activties which 
    /// is occuring in the configured scope of monitoring.
    /// </summary>
    internal interface IMonitor
    {
        /// <summary>
        /// Happens when certain process is 
        /// trying to acess certain file.
        /// </summary>
        event FileAccessEvent AccessingFile;

        /// <summary>
        /// Run the file accessing monitor. 
        /// </summary>
        void Start();

        /// <summary>
        /// Stop monitoring activity.
        /// </summary>
        void Stop();
    }
}
