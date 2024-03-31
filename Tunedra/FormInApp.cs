using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Drawing.Drawing2D;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using Windows.Devices.Enumeration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using Windows.ApplicationModel.Background;
using System.Windows.Forms.VisualStyles;
using System.Media;
using NAudio.Wave;
using NAudio.SoundTouch;
using Timer = System.Windows.Forms.Timer;
using SoundTouch.Net.NAudioSupport;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Tunedra
{

    public partial class FormInApp : Form
    {
        int okChangeText = 1;
        int okClick = 0;
        private string dbPath;
        private string connectionString;
        private OleDbConnection con;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private string dbPath1;
        private string connectionString1;
        private OleDbConnection con1;
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter ad1 = new OleDbDataAdapter();

        public static int ant;
        public static int i;

        Label[,] songs = new Label[10000005, 3];
        Label[,] artists = new Label[10000005, 1];

        bool startt = false;

        float Default_value = 0.25f, Min = 0.0f, Max = 1.0f;

        public float Bar(float value)
        {
            return (pictureBoxVolumeBar.Width - 24) * (value - Min) / (float)(Max - Min);
        }

        public float sliderWidth(int x)
        {
            return Min + (Max - Min) * x / (float)(pictureBoxVolumeBar.Width);
        }
        public void thumb(float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            Default_value = value;
            if (audioFile != null)
            {
                audioFile.Volume = value;
            }
            pictureBoxVolumeBar.Refresh();
        }
        private void pictureBoxVolumeBar_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float x = Bar(Default_value);
            int y = (int)(pictureBoxVolumeBar.Height * bar_size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.White, 0, y, pictureBoxVolumeBar.Width - 10, y / 2);
            e.Graphics.FillRectangle(Brushes.MediumPurple, 0, y, x, pictureBoxVolumeBar.Height - 2 * y + 2);

            using (Pen pen = new Pen(Color.White, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 3, pictureBoxVolumeBar.Height / 3, pictureBoxVolumeBar.Height / 3);
                e.Graphics.FillEllipse(Brushes.White, x + 4, y - 3, pictureBoxVolumeBar.Height / 3, pictureBoxVolumeBar.Height / 3);
            }
        }

        bool mouse = false;
        private void pictureBoxVolumeBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            thumb(sliderWidth(e.X));
        }


        private void pictureBoxVolumeBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            thumb(sliderWidth(e.X));
        }

        private void pictureBoxVolumeBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        float Default_value1 = 0.0f, Min1 = 0.0f, Max1 = 1.0f;
        public float Bar1(float value)
        {
            return (pictureBoxMusicBar.Width - 24) * (value - Min1) / (float)(Max1 - Min1);
        }
        public void thumb1(float value)
        {
            if (value < Min1)
            {
                value = Min1;
            }
            if (value > Max1)
            {
                value = Max1;
            }
            Default_value1 = value;
            pictureBoxMusicBar.Refresh();
        }
        private void pictureBoxMusicBar_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float x = Bar1(Default_value1);
            int y = (int)(pictureBoxMusicBar.Height * bar_size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.White, 0, y, pictureBoxMusicBar.Width - 10, y / 2);
            e.Graphics.FillRectangle(Brushes.MediumPurple, 0, y, x, pictureBoxMusicBar.Height - 2 * y + 2);

            using (Pen pen = new Pen(Color.White, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 3, pictureBoxMusicBar.Height / 3, pictureBoxMusicBar.Height / 3);
                e.Graphics.FillEllipse(Brushes.White, x + 4, y - 3, pictureBoxMusicBar.Height / 3, pictureBoxMusicBar.Height / 3);
            }
        }
        bool mouse1 = false;

        private void pictureBoxMusicBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (audioFile != null && outputDevice != null)
            {
                mouse1 = true;
                float newPoint = (float)e.X / pictureBoxMusicBar.Width;
                double newSeconds = newPoint * audioFile.TotalTime.TotalSeconds;
                audioFile.CurrentTime = TimeSpan.FromSeconds(newSeconds);
                UpdateMusicBar(newPoint);
            }
        }

        private void pictureBoxMusicBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse1 && audioFile != null && outputDevice != null)
            {
                float newPoint = (float)e.X / pictureBoxMusicBar.Width;
                double newSeconds = newPoint * audioFile.TotalTime.TotalSeconds;
                audioFile.CurrentTime = TimeSpan.FromSeconds(newSeconds);
                UpdateMusicBar(newPoint);
            }
        }

        private void pictureBoxMusicBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouse1 = false;
        }

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private PictureBox currentPlayingButton;
        private string currentPlayingFile;

        void ClickPlay(object sender, EventArgs e, string filename, PictureBox pictureBox)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Melodii", filename);
            if (startt && audioFile != null && filePath == currentPlayingFile)
            {
                outputDevice.Stop();
                pictureBox.Image = Properties.Resources.play_removebg_preview;
                pictureBoxSoundBarEqualizer.Enabled = false;
                startt = false;
                currentPlayingButton = null;
                currentPlayingFile = null;
            }
            else
            {
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    audioFile.Dispose();
                    if (currentPlayingButton != null)
                    {
                        currentPlayingButton.Image = Properties.Resources.play_removebg_preview;
                    }
                }
                outputDevice = new WaveOutEvent();
                audioFile = new AudioFileReader(filePath);
                outputDevice.Init(audioFile);
                audioFile.Volume = 0.25f;
                outputDevice.Play();
                TimeSpan totalTimeSpan = audioFile.TotalTime;
                labelMusicEnd.Text = string.Format("{0:D2}:{1:D2}", totalTimeSpan.Minutes, totalTimeSpan.Seconds);
                pictureBox.Image = Properties.Resources.stop1_removebg_preview;
                pictureBoxSoundBarEqualizer.Enabled = true;
                startt = true;
                currentPlayingButton = pictureBox;
                currentPlayingFile = filePath;
            }
        }
        private void StopMusic()
        {
            if (outputDevice != null)
            {
                if (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    outputDevice.Stop();
                }
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
            if (currentPlayingButton != null)
            {
                currentPlayingButton.Image = Properties.Resources.play_removebg_preview;
                currentPlayingButton = null;
            }
        }

        public FormInApp()
        {
            InitializeComponent();
            dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_songs.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";
            con = new OleDbConnection(connectionString);
            dbPath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db_artists.accdb");
            connectionString1 = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath1};";
            con1 = new OleDbConnection(connectionString1);
            int pas = 0;
            con.Open();
            string login = "SELECT * FROM tbl_songss";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            Label tit = new Label();
            tit.Text = "Title";
            tit.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            tit.Location = new Point(300, 30);
            tit.ForeColor = Color.White;
            panelCenter.Controls.Add(tit);
            Label art = new Label();
            art.Text = "Artist";
            art.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            art.Location = new Point(600, 30);
            art.ForeColor = Color.White;
            panelCenter.Controls.Add(art);
            i = 50;
            while (reader.Read())
            {
                songs[pas, 0] = new Label();
                songs[pas, 0].AutoSize = true;
                songs[pas, 0].Text = reader["Title"].ToString();
                songs[pas, 0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                songs[pas, 0].Location = new Point(300, 50 + i);
                songs[pas, 0].ForeColor = Color.White;
                panelCenter.Controls.Add(songs[pas, 0]);
                songs[pas, 1] = new Label();
                songs[pas, 1].AutoSize = true;
                songs[pas, 1].Text = reader["Artist"].ToString();
                songs[pas, 1].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                songs[pas, 1].Location = new Point(600, 50 + i);
                songs[pas, 1].ForeColor = Color.White;
                panelCenter.Controls.Add(songs[pas, 1]);
                var fileName = reader["FileName"].ToString();
                PictureBox pictureBoxPlayBut = new PictureBox();
                pictureBoxPlayBut.Cursor = Cursors.Hand;
                pictureBoxPlayBut.Image = Properties.Resources.play_removebg_preview;
                pictureBoxPlayBut.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxPlayBut.Location = new Point(50, 50 + i);
                pictureBoxPlayBut.Size = new Size(35, 35);
                pictureBoxPlayBut.Click += (sender, e) => ClickPlay(sender, e, fileName, pictureBoxPlayBut);
                panelCenter.Controls.Add(pictureBoxPlayBut);
                i = i + 110;
                pas++;
            }
            con.Close();
        }
        public void UpdateMusicBar(float progress)
        {
            if (progress < Min1)
            {
                progress = Min1;
            }
            if (progress > Max1)
            {
                progress = Max1;
            }
            Default_value1 = progress;
            pictureBoxMusicBar.Refresh();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (outputDevice != null && audioFile != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                double totalSeconds = audioFile.TotalTime.TotalSeconds;
                double currentSeconds = audioFile.CurrentTime.TotalSeconds;
                float progress = (float)(currentSeconds / totalSeconds);
                UpdateMusicBar(progress);
                TimeSpan currentTimeSpan = TimeSpan.FromSeconds(currentSeconds);
                labelMusicStart.Text = string.Format("{1:D2}:{2:D2}", currentTimeSpan.Hours, currentTimeSpan.Minutes, currentTimeSpan.Seconds);
            }
        }
        private void FormInApp_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();
            textBoxSearch.SelectionStart = 0;
            labelArtist.Parent = pictureBox1;
            labelListeners.Parent = pictureBox1;
            labelListeners.Location = new Point(100, 180);
            labelArtist.Location = new Point(100, 200);
            pictureBoxSoundBarEqualizer.Location = new Point(50, 230);
            pictureBoxSoundBarEqualizer.Parent = pictureBox1;
            pictureBoxSoundBarEqualizer.Enabled = false;
            panelCenter.AutoScroll = false;
            panelCenter.HorizontalScroll.Enabled = false;
            panelCenter.HorizontalScroll.Visible = false;
            panelCenter.HorizontalScroll.Maximum = 0;
            panelCenter.AutoScroll = true;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void textBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSearch.Text = " ";
            okClick = 1;
        }
        private void HighlightResults(string searchText)
        {
            bool matchFound = false;
            ResetHighlights();
            for (int i = 0; i < songs.GetLength(0); i++)
            {
                if (songs[i, 0] != null && songs[i, 0].Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 && searchText != "")
                {
                    songs[i, 0].BackColor = Color.MediumPurple;
                    if (!matchFound)
                    {
                        panelCenter.ScrollControlIntoView(songs[i, 0]);
                        matchFound = true;
                    }
                }
                if (songs[i, 1] != null && songs[i, 1].Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 && searchText != "")
                {
                    songs[i, 1].BackColor = Color.MediumPurple;
                    if (!matchFound)
                    {
                        panelCenter.ScrollControlIntoView(songs[i, 1]);
                        matchFound = true;
                    }
                }
            }
            for (int i = 0; i < artists.GetLength(0); i++)
            {
                if (artists[i, 0] != null && artists[i, 0].Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 && searchText != "")
                {
                    artists[i, 0].BackColor = Color.MediumPurple;
                    if (!matchFound)
                    {
                        panelCenter.ScrollControlIntoView(artists[i, 0]);
                        matchFound = true;
                    }
                }
            }
        }

        private void ResetHighlights()
        {
            for (int i = 0; i < songs.GetLength(0); i++)
            {
                if (songs[i, 0] != null)
                    songs[i, 0].BackColor = Color.Transparent;

                if (songs[i, 1] != null)
                    songs[i, 1].BackColor = Color.Transparent;
            }
            for (int i = 0; i < artists.GetLength(0); i++)
            {
                if (artists[i, 0] != null)
                    artists[i, 0].BackColor = Color.Transparent;
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (okClick == 0 && okChangeText == 1 && textBoxSearch.Text != "Ce dorești să asculți?")
            {
                okChangeText = 0;
                textBoxSearch.ForeColor = Color.White;
                textBoxSearch.Text = textBoxSearch.Text[0] + " ";
                textBoxSearch.SelectionStart = 1;
            }
            else
            {
                HighlightResults(textBoxSearch.Text.Trim());
            }

        }
        private void pictureBoxCloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimazeButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void labelLocalFiles_Click(object sender, EventArgs e)
        {
            StopMusic();
            FormAddASong formAdd = new FormAddASong();
            formAdd.Show();
            this.Close();
        }
        private void pictureBoxAddASong_Click(object sender, EventArgs e)
        {
            StopMusic();
            FormAddASong formAdd = new FormAddASong();
            formAdd.Show();
            this.Close();
        }

        public static bool okbk = false;
        private void labelLogOut_Click(object sender, EventArgs e)
        {
            okbk = true;
            StopMusic();
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            this.Close();
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            okbk = true;
            StopMusic();
            FormProfile formProfile = new FormProfile();
            formProfile.Show();
            this.Close();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void labelArtists_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            int pas = 0;
            con1.Open();
            string login = "SELECT * FROM tbl_artists";
            cmd1 = new OleDbCommand(login, con1);
            OleDbDataReader reader = cmd1.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                if (pas % 2 == 0)
                {
                    artists[pas, 0] = new Label();
                    artists[pas, 0].AutoSize = true;
                    artists[pas, 0].Text = reader["Name"].ToString();
                    artists[pas, 0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    artists[pas, 0].Location = new Point(200, 50 + i + 20);
                    artists[pas, 0].ForeColor = Color.White;
                    panelCenter.Controls.Add(artists[pas, 0]);
                    PictureBox pictureBoxArtistPicture = new PictureBox();
                    pictureBoxArtistPicture.ImageLocation = reader["Picture"].ToString();
                    pictureBoxArtistPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxArtistPicture.Size = new Size(90, 90);
                    System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                    gp.AddEllipse(0, 0, pictureBoxArtistPicture.Width - 3, pictureBoxArtistPicture.Height - 3);
                    Region rg = new Region(gp);
                    pictureBoxArtistPicture.Region = rg;
                    pictureBoxArtistPicture.Location = new Point(50, 50 + i);
                    panelCenter.Controls.Add(pictureBoxArtistPicture);

                }
                if (pas % 2 == 1)
                {
                    i = i - 150;
                    artists[pas, 0] = new Label();
                    artists[pas, 0].AutoSize = true;
                    artists[pas, 0].Text = reader["Name"].ToString();
                    artists[pas, 0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    artists[pas, 0].Location = new Point(650, 50 + i + 20);
                    artists[pas, 0].ForeColor = Color.White;
                    panelCenter.Controls.Add(artists[pas, 0]);
                    PictureBox pictureBoxArtistPicture = new PictureBox();
                    pictureBoxArtistPicture.ImageLocation = reader["Picture"].ToString();
                    pictureBoxArtistPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxArtistPicture.Size = new Size(90, 90);
                    System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                    gp.AddEllipse(0, 0, pictureBoxArtistPicture.Width - 3, pictureBoxArtistPicture.Height - 3);
                    Region rg = new Region(gp);
                    pictureBoxArtistPicture.Region = rg;
                    pictureBoxArtistPicture.Location = new Point(500, 50 + i);
                    panelCenter.Controls.Add(pictureBoxArtistPicture);
                }
                i = i + 150;
                pas++;
            }
            con1.Close();
        }

        private void labelAddAnArtist_Click(object sender, EventArgs e)
        {
            StopMusic();
            FormAddAnArtist formAddAnArtist = new FormAddAnArtist();
            formAddAnArtist.Show();
            this.Close();
        }
        private void labelSongs_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            int pas = 0;
            con.Open();
            string login = "SELECT * FROM tbl_songss";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            Label tit = new Label();
            tit.Text = "Title";
            tit.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            tit.Location = new Point(300, 30);
            tit.ForeColor = Color.White;
            panelCenter.Controls.Add(tit);
            Label art = new Label();
            art.Text = "Artist";
            art.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            art.Location = new Point(600, 30);
            art.ForeColor = Color.White;
            panelCenter.Controls.Add(art);
            i = 50;
            while (reader.Read())
            {
                songs[pas, 0] = new Label();
                songs[pas, 0].AutoSize = true;
                songs[pas, 0].Text = reader["Title"].ToString();
                songs[pas, 0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                songs[pas, 0].Location = new Point(300, 50 + i);
                songs[pas, 0].ForeColor = Color.White;
                panelCenter.Controls.Add(songs[pas, 0]);
                songs[pas, 1] = new Label();
                songs[pas, 1].AutoSize = true;
                songs[pas, 1].Text = reader["Artist"].ToString();
                songs[pas, 1].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                songs[pas, 1].Location = new Point(600, 50 + i);
                songs[pas, 1].ForeColor = Color.White;
                panelCenter.Controls.Add(songs[pas, 1]);
                var fileName = reader["FileName"].ToString();
                PictureBox pictureBoxPlayBut = new PictureBox();
                pictureBoxPlayBut.Cursor = Cursors.Hand;
                pictureBoxPlayBut.Image = Properties.Resources.play_removebg_preview;
                pictureBoxPlayBut.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxPlayBut.Location = new Point(50, 50 + i);
                pictureBoxPlayBut.Size = new Size(35, 35);
                pictureBoxPlayBut.Click += (sender, e) => ClickPlay(sender, e, fileName, pictureBoxPlayBut);
                panelCenter.Controls.Add(pictureBoxPlayBut);
                i = i + 110;
                pas++;
            }
            con.Close();
        }

        private void pictureBoxAddAnArtist_Click(object sender, EventArgs e)
        {
            StopMusic();
            FormAddAnArtist formAddAnArtist = new FormAddAnArtist();
            formAddAnArtist.Show();
            this.Close();
        }

        private void pictureBoxArtist_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            int pas = 0;
            con1.Open();
            string login = "SELECT * FROM tbl_artists";
            cmd1 = new OleDbCommand(login, con1);
            OleDbDataReader reader = cmd1.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                if (pas % 2 == 0)
                {
                    artists[pas, 0] = new Label();
                    artists[pas, 0].AutoSize = true;
                    artists[pas, 0].Text = reader["Name"].ToString();
                    artists[pas, 0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    artists[pas, 0].Location = new Point(200, 50 + i + 20);
                    artists[pas, 0].ForeColor = Color.White;
                    panelCenter.Controls.Add(artists[pas, 0]);
                    PictureBox pictureBoxArtistPicture = new PictureBox();
                    pictureBoxArtistPicture.ImageLocation = reader["Picture"].ToString();
                    pictureBoxArtistPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxArtistPicture.Size = new Size(90, 90);
                    System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                    gp.AddEllipse(0, 0, pictureBoxArtistPicture.Width - 3, pictureBoxArtistPicture.Height - 3);
                    Region rg = new Region(gp);
                    pictureBoxArtistPicture.Region = rg;
                    pictureBoxArtistPicture.Location = new Point(50, 50 + i);
                    panelCenter.Controls.Add(pictureBoxArtistPicture);

                }
                if (pas % 2 == 1)
                {
                    i = i - 150;
                    artists[pas, 0] = new Label();
                    artists[pas, 0].AutoSize = true;
                    artists[pas, 0].Text = reader["Name"].ToString();
                    artists[pas, 0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    artists[pas, 0].Location = new Point(650, 50 + i + 20);
                    artists[pas, 0].ForeColor = Color.White;
                    panelCenter.Controls.Add(artists[pas, 0]);
                    PictureBox pictureBoxArtistPicture = new PictureBox();
                    pictureBoxArtistPicture.ImageLocation = reader["Picture"].ToString();
                    pictureBoxArtistPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxArtistPicture.Size = new Size(90, 90);
                    System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                    gp.AddEllipse(0, 0, pictureBoxArtistPicture.Width - 3, pictureBoxArtistPicture.Height - 3);
                    Region rg = new Region(gp);
                    pictureBoxArtistPicture.Region = rg;
                    pictureBoxArtistPicture.Location = new Point(500, 50 + i);
                    panelCenter.Controls.Add(pictureBoxArtistPicture);
                }
                i = i + 150;
                pas++;
            }
            con1.Close();
        }

        private void pictureBoxSongs_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            int pas = 0;
            con.Open();
            string login = "SELECT * FROM tbl_songss";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            Label tit = new Label();
            tit.Text = "Title";
            tit.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            tit.Location = new Point(300, 30);
            tit.ForeColor = Color.White;
            panelCenter.Controls.Add(tit);
            Label art = new Label();
            art.Text = "Artist";
            art.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            art.Location = new Point(600, 30);
            art.ForeColor = Color.White;
            panelCenter.Controls.Add(art);
            i = 50;
            while (reader.Read())
            {
                songs[pas, 0] = new Label();
                songs[pas, 0].AutoSize = true;
                songs[pas, 0].Text = reader["Title"].ToString();
                songs[pas, 0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                songs[pas, 0].Location = new Point(300, 50 + i);
                songs[pas, 0].ForeColor = Color.White;
                panelCenter.Controls.Add(songs[pas, 0]);
                songs[pas, 1] = new Label();
                songs[pas, 1].AutoSize = true;
                songs[pas, 1].Text = reader["Artist"].ToString();
                songs[pas, 1].Font = new Font("Segoe UI", 12, FontStyle.Bold);
                songs[pas, 1].Location = new Point(600, 50 + i);
                songs[pas, 1].ForeColor = Color.White;
                panelCenter.Controls.Add(songs[pas, 1]);
                var fileName = reader["FileName"].ToString();
                PictureBox pictureBoxPlayBut = new PictureBox();
                pictureBoxPlayBut.Cursor = Cursors.Hand;
                pictureBoxPlayBut.Image = Properties.Resources.play_removebg_preview;
                pictureBoxPlayBut.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxPlayBut.Location = new Point(50, 50 + i);
                pictureBoxPlayBut.Size = new Size(35, 35);
                pictureBoxPlayBut.Click += (sender, e) => ClickPlay(sender, e, fileName, pictureBoxPlayBut);
                panelCenter.Controls.Add(pictureBoxPlayBut);
                i = i + 110;
                pas++;
            }
            con.Close();
        }


    }
}