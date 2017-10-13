using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_dl_gui
{
    class Logic
    {
        //Classes
        private Config _config;
        private string _configFilepath;

        public Logic()
        {
            _config = new Config();
            _configFilepath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "Config.bin");
            LoadConfig();
        }

        //Runs youtube-dl with given url and params.
        public void DownloadVideo(string url)
        {
            string command = url + _config.DefaultParameters + _config.DefaultOutputName;

            try
            {
                using(Process p = new Process())
                {
                    p.StartInfo.FileName = _config.YTDL_Location;
                    p.StartInfo.Arguments = command;
                    p.Start();
                    p.WaitForExit();
                    MessageBox.Show($"File downloaded to {_config.DownloadFolder}");
                }
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
        public void LoadConfig()
        {
            try
            {
                using (FileStream fs = new FileStream(_configFilepath, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    _config = (Config)bf.Deserialize(fs);
                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("No youtube-dl.exe found");
            }
            catch(SerializationException)
            {
                MessageBox.Show("No youtube-dl.exe found");
            }
        }

        public void SaveConfig()
        {
            try
            {
                using (FileStream fs = new FileStream(_configFilepath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, _config);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NewYTDL()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
                _config.YTDL_Location = ofd.FileName;
            }
        }

        public string GetYTDL()
        {
            return _config.YTDL_Location;
        }

    }
}
