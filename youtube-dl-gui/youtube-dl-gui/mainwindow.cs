using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_dl_gui
{
    public partial class mainwindow : Form
    {
        private Logic logic;
        private string parameters = " ";

        //Getting user downloads folder the lazy way
        private static string userRoot = Environment.GetEnvironmentVariable("USERPROFILE");
        private static string downloadFolder = Path.Combine(userRoot, "Downloads");

        public mainwindow()
        {
            InitializeComponent();
            logic = new Logic();
            logic.Filename = "";

        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            logic.DownloadVideo(Tb_URL.Text, parameters);
        }

        private void Menu_Open_Click(object sender, EventArgs e)
        {
           using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
                logic.Filename = ofd.FileName;
                Label_Location.Text = $"youtube-dl location: {logic.Filename}";
            }
        }
    }
}
