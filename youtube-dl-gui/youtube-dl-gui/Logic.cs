using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtube_dl_gui
{
    class Logic
    {
        public string Filename { get; set; }
        public Logic()
        {

        }


        //Downloads entered video from URL
        public void DownloadVideo(string url, string parameters)
        {
            string command = url + parameters;
            try
            {
                Process.Start(Filename, command);
            }
            catch
            {
                //TODO Catch errors.
            }
        }

        //Config methods

        public void LoadDefaultConfig()
        {
            throw new NotImplementedException();
        }

        public void LoadNewConfig()
        {
            throw new NotImplementedException();
        }

        public void SaveNewConfig()
        {
            throw new NotImplementedException();
        }

    }
}
