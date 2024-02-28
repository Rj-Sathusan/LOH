using LOH.DAL;
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

namespace QRCodeReader
{
    public partial class Attendence : Form
    {
        public function_ dalFunctions = new function_();
        public ChildrenDetails _childrenDetails = new ChildrenDetails();
        public Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            _childrenDetails.BindAttendenceDetails(grid_view);
        }

        private void Attendence_Load_1(object sender, EventArgs e)
        {
            _childrenDetails.BindAttendenceDetails(grid_view);

        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            dalFunctions.SearchGridView(grid_view, search_box.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dalFunctions.SearchGridView(grid_view, dateTimePicker1.Text);
        }
    }
}
