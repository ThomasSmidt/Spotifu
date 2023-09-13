namespace Spotifu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.bar_volume = new System.Windows.Forms.TrackBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btn_previous = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.bar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.AccessibleName = "";
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_next.Location = new System.Drawing.Point(190, 383);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(54, 54);
            this.btn_next.TabIndex = 2;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_open
            // 
            this.btn_open.AccessibleName = "";
            this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.White;
            this.btn_open.Location = new System.Drawing.Point(325, 393);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(144, 36);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // bar_volume
            // 
            this.bar_volume.AutoSize = false;
            this.bar_volume.Location = new System.Drawing.Point(631, 399);
            this.bar_volume.Maximum = 100;
            this.bar_volume.Name = "bar_volume";
            this.bar_volume.Size = new System.Drawing.Size(157, 25);
            this.bar_volume.TabIndex = 4;
            this.bar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bar_volume.Scroll += new System.EventHandler(this.bar_volume_Scroll);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.progressBar.Location = new System.Drawing.Point(12, 364);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 11);
            this.progressBar.TabIndex = 5;
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.AccessibleName = "";
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.track_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.ForeColor = System.Drawing.SystemColors.Window;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 24;
            this.track_list.Location = new System.Drawing.Point(12, 39);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(776, 292);
            this.track_list.TabIndex = 6;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.White;
            this.lbl_track_start.Location = new System.Drawing.Point(9, 339);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(43, 16);
            this.lbl_track_start.TabIndex = 7;
            this.lbl_track_start.Text = "00:00";
            this.lbl_track_start.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.White;
            this.lbl_track_end.Location = new System.Drawing.Point(745, 339);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(43, 16);
            this.lbl_track_end.TabIndex = 8;
            this.lbl_track_end.Text = "00:00";
            // 
            // btn_play
            // 
            this.btn_play.AccessibleName = "";
            this.btn_play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play.BackgroundImage")));
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_play.Location = new System.Drawing.Point(70, 382);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(57, 57);
            this.btn_play.TabIndex = 10;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click_1);
            // 
            // btn_pause
            // 
            this.btn_pause.AccessibleName = "";
            this.btn_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pause.BackgroundImage")));
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_pause.Location = new System.Drawing.Point(129, 382);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(57, 57);
            this.btn_pause.TabIndex = 11;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Playlist";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btn_previous
            // 
            this.btn_previous.AccessibleName = "";
            this.btn_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_previous.BackgroundImage")));
            this.btn_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_previous.Location = new System.Drawing.Point(12, 383);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(54, 54);
            this.btn_previous.TabIndex = 13;
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(58, 335);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(681, 23);
            this.player.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bar_volume);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_next);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TrackBar bar_volume;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btn_previous;
    }
}

