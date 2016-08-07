using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using MyTunes.Shared;

namespace MyTunes
{
	public static class SongLoader
	{
		const string Filename = "songs.json";

        public static IStreamLoader Loader { get; set; }

        public static async Task<IEnumerable<Song>> Load()
        {
            using (var reader = new StreamReader(OpenData()))
            {
                var songsFromStream = await reader.ReadToEndAsync();
                var deserializedSongs = JsonConvert.DeserializeObject<List<Song>>(songsFromStream);
                return deserializedSongs;
                //return JsonConvert.DeserializeObject<List<Song>>(await reader.ReadToEndAsync());
            }
        }

        private static Stream OpenData()
        {
            if (Loader == null)
            {
                throw new Exception("Must set platform Loader before calling Load.");
            }
            else
            {
               return Loader.GetStreamForFilename(Filename);
            }
        }

    }
}

