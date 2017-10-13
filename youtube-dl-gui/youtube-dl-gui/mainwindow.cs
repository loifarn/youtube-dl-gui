using System;
using System.Diagnostics;
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

        private void github_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/loifarn/youtube-dl-gui");
        }

        private void ytdl_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://rg3.github.io/youtube-dl/download.html");
        }
    }
}
