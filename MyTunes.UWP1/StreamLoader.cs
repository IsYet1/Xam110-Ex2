using MyTunes.Shared;
using System;
using System.IO;
using Windows.ApplicationModel;

namespace MyTunes.UWP1
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
