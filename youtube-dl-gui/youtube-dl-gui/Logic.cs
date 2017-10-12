using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_dl_gui
{
    class Logic
    {
        public string Filename { get; set; }
        private string DefaultName = "%(title)s.%(ext)s\"";




        public Logic()
        {

        }


        //Downloads entered video from URL
        public void DownloadVideo(string url, string parameters)
        {
            string command = url + parameters + DefaultName;

            try
            {
                Process.Start(Filename, command);
                //MessageBox.Show(command);
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
