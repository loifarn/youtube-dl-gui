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

        public mainwindow()
        {
            InitializeComponent();
            logic = new Logic();
            Label_Location.Text = $"youtube-dl location: {logic.GetYTDL()}";
        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            if(Tb_URL.Text.Length > 1)
            {
                logic.DownloadVideo(Tb_URL.Text);
            }
            else
            {
                MessageBox.Show("Please enter a url");
            }
            
        }

        private void Menu_Open_Click(object sender, EventArgs e)
        {
            logic.NewYTDL();
            Label_Location.Text = $"youtube-dl location: {logic.GetYTDL()}";
        }

        private void mainwindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            logic.SaveConfig();
        }
    }
}
