using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtube_dl_gui
{
    [Serializable]
    class Config
    {
        //Properties
        public string Parameters { get; set; }
        public string YTDL_Location { get; set; }

        //Getting user downloads folder the lazy way
        private static string _userRoot;
        public string DownloadFolder;

        //Command formatting
        public string DefaultParameters;
        public string DefaultOutputName;


        public Config()
        {
            YTDL_Location = "No youtube-dl.exe found";

            _userRoot = Environment.GetEnvironmentVariable("USERPROFILE");
            DownloadFolder = Path.Combine(_userRoot, "Downloads");

            DefaultParameters = $" --output \"{DownloadFolder}\\";
            DefaultOutputName = "%(title)s.%(ext)s\"";
        }

    }
}
