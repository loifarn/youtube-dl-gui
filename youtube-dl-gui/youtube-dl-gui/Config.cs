using System;
using System.IO;

namespace youtube_dl_gui
{
    [Serializable]
    class Config
    {
        //Properties
        public string YTDL_Location { get; set; }

        //For YTDL arguements
        public string DownloadFolder;
        public string DefaultParameters;
        public string DefaultOutputFilename;


        public Config()
        {
            YTDL_Location = "No youtube-dl.exe found";

            DownloadFolder = Path.Combine((Environment.GetEnvironmentVariable("USERPROFILE")), "Downloads");
            DefaultParameters = $" --output \"{DownloadFolder}\\";
            DefaultOutputFilename = "%(title)s.%(ext)s\"";
        }
    }
}
