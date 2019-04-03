using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoConverter;
using System.Net;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        string InputFile;
        string OutputFile;


        public Form1()
        {
            InitializeComponent();
        }

        


        private void button_Openfile_Click(object sender, EventArgs e)
        {


           if (OpenFileVideo.ShowDialog() == DialogResult.OK)
            {
                InputFile = OpenFileVideo.FileName;
                OutputFile = InputFile.Substring(0, InputFile.IndexOf("."));

            }

    
        }


        private void button_audio_Click(object sender, EventArgs e)
        {
            var ConvertVideo = new NReco.VideoConverter.FFMpegConverter();
            ConvertVideo.ConvertMedia(InputFile, OutputFile + ".mp3", "mp3");



        }



        private void button_kadr_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbVideo.Text = ofd.FileName;
            }
        }

        private void mesto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tboutdir.Text = fbd.SelectedPath;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            string inputPath = tbVideo.Text;
            string outputPath = tboutdir.Text;

            try
            {

                if (inputPath != null && outputPath != null)
                {
                    float duration = GetVideoDuration(inputPath);
                    FFMpegConverter ffmegc = new FFMpegConverter();
                    float frameTime = 2.9f;
                    int counter = 1;
                    while (frameTime <= duration)
                    {
                        string img = Path.Combine(outputPath, string.Format("frame{0}.jpg", counter));
                        ffmegc.GetVideoThumbnail(inputPath, img, frameTime);
                        counter++;
                        frameTime += 2.9f;
                        
                        
                    }
                }
            }
            catch (FFMpegException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private float GetVideoDuration(string videosource)
        {
            var ffProbe = new NReco.VideoInfo.FFProbe();
            var videoInfo = ffProbe.GetMediaInfo(videosource);
            double duration = videoInfo.Duration.TotalSeconds;
            float f_duration = (float)duration;
            return f_duration;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void tbVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboutdir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
