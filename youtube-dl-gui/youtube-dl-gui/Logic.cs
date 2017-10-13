using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //Getting user downloads folder the lazy way
        private static string userRoot = Environment.GetEnvironmentVariable("USERPROFILE");
        private static string downloadFolder = Path.Combine(userRoot, "Downloads");
        private string DefaultParameters = $" --output \"{downloadFolder}\\";

        public Logic()
        {

        }

        //Downloads entered video from URL

        public void DownloadVideo(string url)
        {
            string command = url + DefaultParameters + DefaultName;

            try
            {
                Process.Start(Filename, command);
            }
            catch(Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
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
