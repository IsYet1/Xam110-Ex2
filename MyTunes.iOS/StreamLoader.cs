using MyTunes.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyTunes
{
    public class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return File.OpenRead(filename);
        }
    }
}
