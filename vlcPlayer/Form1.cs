using System;
using System.IO;
using System.Reflection;
using System.Windows;
using NAudio;
using NAudio.Wave;
namespace vlcPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "( *.mp3 | *.mp3";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = openFileDialog.FileName;
                
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(txtSource.Text));

        }
        
        private void btnPause_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        private void sbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            int nuevoValor = sbVolumen.Value;
            vlcControl1.Audio.Volume = nuevoValor;
            
        }
    }
}