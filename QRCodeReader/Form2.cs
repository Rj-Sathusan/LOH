using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QRCodeReader
{
    public partial class Form2 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                comboBox1.Items.Add(filterInfo.Name);
            comboBox1.SelectedIndex = 0;
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                string folderPath = @"C:\CapturedImages\"; // Change the path as needed
                if (!System.IO.Directory.Exists(folderPath))
                    System.IO.Directory.CreateDirectory(folderPath);

                string fileName = $"captured_image_{DateTime.Now:yyyyMMddHHmmss}.jpg";
                string filePath = System.IO.Path.Combine(folderPath, fileName);

                pictureBox1.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show($"Image saved to: {filePath}", "Image Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Display the captured image in pictureBoxCapturedImage
                pictureBox2.Image = Image.FromFile(filePath);
            }
            else
            {
                MessageBox.Show("No image available to capture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
    }
}
