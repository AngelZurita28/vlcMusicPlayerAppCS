using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
namespace vlcPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] rutas, archivos;
        private void btnGet_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio|*.mp3;*.wmv;*.wav;*.flac;*.m4a;*.jpg*;";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //txtSource.Text = openFileDialog.FileName;
                //play();
                archivos = openFileDialog.SafeFileNames;
                rutas = openFileDialog.FileNames;
                for (int x = 0; x < archivos.Length; x++)
                { trackList.Items.Add(archivos[x]); }
            }
        }
        private void aleatorio()
        {
            trackList.Items.Clear();
            Random rand1 = new Random();
            try
            {rutas = rutas.OrderBy(x => rand1.Next()).ToArray(); }
            catch (Exception)
            { }

            for (int y = 0; y < rutas.Length; y++)
            {
                archivos[y] = Path.GetFileName(rutas[y]);
                trackList.Items.Add(archivos[y]);
            }
        }
        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {vlcControl1.Play(new Uri(rutas[trackList.SelectedIndex])); }
            catch (Exception)
            { }
            timer1.Start();
        }
        private void play()
        {
            try
            {
                vlcControl1.Play(new Uri(txtSource.Text));
            }
            catch (Exception)
            {
            }
            vlcControl1.Audio.Volume = 50;
            timer1.Start();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {play();}
        private void btnPause_Click(object sender, EventArgs e)
        {vlcControl1.Pause();}
        private void sbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            int nuevoValor = sbVolumen.Value;
            vlcControl1.Audio.Volume = nuevoValor;
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        { vlcControl1.Time = hScrollBar2.Value*1000;}
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying)
            {
                hScrollBar2.Maximum = (int)vlcControl1.Length/1000;
                hScrollBar2.Value = (int)vlcControl1.Time/1000;
            }
            
            TimeSpan t = TimeSpan.FromMilliseconds(vlcControl1.Time);
            string time = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
            lbTime.Text = time;
            TimeSpan t2 = TimeSpan.FromMilliseconds(vlcControl1.Length);
            string totalTime = string.Format("{0:D2}:{1:D2}", t2.Minutes, t2.Seconds);
            lbTotalTime.Text = totalTime;
            if (hScrollBar2.Value >= hScrollBar2.Maximum - 2)
            {
                siguiente();
            }
        }

        bool toggleMute = true;
        private void btnMute_Click(object sender, EventArgs e)
        {
            if (toggleMute)
            {
                sbVolumen.Value = 0;
                vlcControl1.Audio.Volume = 0;
            }
            else
            {
                sbVolumen.Value = 70;
                vlcControl1.Audio.Volume = 70;
            }
            toggleMute = !toggleMute;
        }

        //bool toggleFS = true;
        //private void btnFullScreen_Click(object sender, EventArgs e)
        //{
        //    if (toggleFS)
        //    {maximizarVideo();}
        //    else
        //    {minimizarVideo();}
        //    toggleFS = !toggleFS;
        //}
        private void maximizarVideo()
        {
            vlcControl1.Dock = DockStyle.Fill;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized; 
        }
        private void minimizarVideo()
        {
            vlcControl1.Dock = DockStyle.None;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            aleatorio();
        }
        private void siguiente()
        {
            if (trackList.SelectedIndex < trackList.Items.Count)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + 1;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        { siguiente(); }

        private void librarySetVlc()
        { this.vlcControl1.VlcLibDirectory = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "libvlc\\win-x64")); }
    }
}