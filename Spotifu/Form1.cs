using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Spotifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            player.uiMode = "None";
            bar_volume.Value = 50;
        }

        List<string> paths = new List<string>(), files = new List<string>();
        bool trackSelected = false;

        private void btn_play_Click(object sender, EventArgs e)
        {
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            trackSelected = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bar_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = bar_volume.Value;  
        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void btn_play_Click_1(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex++;
            }
            else if (track_list.SelectedIndex >= 0)
            {
                track_list.SelectedIndex = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)player.Ctlcontrols.currentPosition;

                try
                {
                    lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                    lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString;
                }
                catch
                {

                }
            }
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(trackSelected)
            {
                player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progressBar.Width;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex--;
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<string> newPaths = new List<string>(ofd.FileNames);
                List<string> newFiles = new List<string>(ofd.FileNames);

                foreach (var file in newFiles)
                {
                    string fileName = Path.GetFileName(file);

                    track_list.Items.Add(fileName);
                }

                paths.AddRange(newPaths); // Add the new paths to the existing list
                files.AddRange(newFiles); // Add the new files to the existing list

                // Update the player to use the new playlist
                player.URL = paths[0]; // Assuming you want to start playing the first track
                trackSelected = true;
            }
        }
    }
}
