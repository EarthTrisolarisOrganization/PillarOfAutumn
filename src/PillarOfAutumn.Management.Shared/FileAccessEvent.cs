using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace PillarOfAutumn.Management
{
    public delegate void FileAccessEvent(object sender, FileAccessEventArgs e);
    public class FileAccessEventArgs : EventArgs
    {
        public Process Process { get; }
        public FileInfo Target { get; }

        public IAccessController Controller { get; }
    }
}
