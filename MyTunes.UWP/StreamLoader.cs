using MyTunes.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Windows.ApplicationModel;

namespace MyTunes.UWP
{
    public class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            var storageFile = Package.Current.InstalledLocation.GetFileAsync(filename).AsTask().Result;

            var stream = storageFile.OpenStreamForReadAsync().Result;

            return stream;

        }
    }
}
