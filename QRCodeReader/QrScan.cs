using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace LOH
{
    public partial class QrScan : Form
    {
        public ChildrenDetails _childrenDetails = new ChildrenDetails();
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        public QrScan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    comboBox1.Items.Add(filterInfo.Name);
                comboBox1.SelectedIndex = 0;
                video_cap();
                // Play first beep
                // Fr
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1 != null)
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                    {
                        Name.Text = result.ToString();
                        DateTime currentDate = DateTime.Today;

                        string name = _childrenDetails.RegisterAttendence(result.ToString(), currentDate);
                        // name = name.ToUpper();
                        Name.Text = (name + "\n\n" + result.ToString()).ToUpper();
                        Console.Beep(1500, 200); // Frequency: 1500 Hz, Duration: 200 milliseconds
                        Thread.Sleep(100); // Wait for 100 milliseconds between beeps
                        Console.Beep(1500, 200); // Play second beep
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDate = DateTime.Today;
                // var name=_childrenDetails.RegisterAttendence("LOH001", currentDate);
                //MessageBox.Show(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        public void video_cap()
        {
            try
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
