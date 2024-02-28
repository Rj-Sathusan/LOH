using LOH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QRCodeReader
{
    public partial class resme : Form
    {
        public resme(string pass1,string pass2,string pass3,string pass4,string pass5,string pass6,string pass7)
        {
            try
            {
                InitializeComponent();
                name.Text = pass1;
                dob.Text = pass2;
                lastname.Text = pass3;
                address.Text = pass4;
                mob.Text = pass5;
                id.Text = pass6;
                pictureBox2.ImageLocation = pass7;
            }
            catch { }

        }

        private void resme_Load(object sender, EventArgs e)
        {
            try
            {
                ChildrenDetails childrenDetails = new ChildrenDetails();
                // Retrieve attendance count and total days count from the database
                Tuple<int, int> data = childrenDetails.GetAttendanceCountAndTotalDays(id.Text, 2024);

                if (data != null)
                {
                    int attendanceCount = data.Item1;
                    int totalDaysCount = data.Item2;

                    // Clear existing data in the chart
                    chart1.Series.Clear();

                    // Add series to the chart
                    Series series = new Series("Data");
                    series.ChartType = SeriesChartType.Pie;

                    // Add attendance count data point
                    DataPoint attendancePoint = new DataPoint();
                    attendancePoint.SetValueY(attendanceCount);
                    attendancePoint.Label = "Attendance: " + attendanceCount;
                    attendancePoint.Color = Color.Green; // Set color for attendance data point
                    series.Points.Add(attendancePoint);

                    // Add total days count data point
                    DataPoint totalDaysPoint = new DataPoint();
                    totalDaysPoint.SetValueY(totalDaysCount);
                    totalDaysPoint.Label = "Total Days: " + totalDaysCount;
                    totalDaysPoint.Color = Color.Black; // Set color for total days data point
                    series.Points.Add(totalDaysPoint);

                    // Add series to the chart
                    chart1.Series.Add(series);
                }
                else
                {
                    MessageBox.Show("Failed to retrieve data from the database.", "Error");
                }
            }
            catch { }
        }
    }
}
