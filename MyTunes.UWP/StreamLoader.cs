using MyTunes.Shared;
using System;
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
