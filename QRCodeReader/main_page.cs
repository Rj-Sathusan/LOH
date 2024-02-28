using ComponentFactory.Krypton.Toolkit;
using QRCodeReader;
using System;
using System.Windows.Forms;

namespace LOH
{

    public partial class main_page : KryptonForm
    {

        public main_page()
        {
            InitializeComponent();
        }


        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
             
        private void patient_btn_Click(object sender, EventArgs e)
        {
            QrScan qr = new QrScan();
            openChildForm(qr);

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if ((passcode_txt.Text) == "ruban")
            {
                btnproductos.Enabled = true;
                staff_details_btn.Enabled = true;
                resorce_btn.Enabled = true;
                patient_btn.Enabled = true;
                passcode_txt.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Check Your Password !");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            btnproductos.Enabled = false;
            staff_details_btn.Enabled = false;
            resorce_btn.Enabled = false;
            patient_btn.Enabled = false;
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page main_Page = new main_page();
            main_Page.Show();
        }














































        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void resorce_btn_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            openChildForm(attendence);
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            // showSubMenu(pay_panel);

        }

        private void d_btn_Click(object sender, EventArgs e)
        {
            // showSubMenu(d_panel);

        }
        private void CreateChart()
        {


        }
        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void sign_up_click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // showSubMenu(ItemPanel);

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //     showSubMenu(Categorypanel);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //    showSubMenu(Categorypanel);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //   showSubMenu(ItemPanel);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // showSubMenu(p_panel);

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patient_details_Click(object sender, EventArgs e)
        {

        }

        private void appoienment_Click(object sender, EventArgs e)
        {

        }

        private void medi_Click(object sender, EventArgs e)
        {

        }

        private void D_details_Click(object sender, EventArgs e)
        {

        }

        private void D_avilable_Click(object sender, EventArgs e)
        {

        }

        private void patient_book_Click(object sender, EventArgs e)
        {

        }

        private void payment_btn_Click(object sender, EventArgs e)
        {

        }

        private void price_btn_Click(object sender, EventArgs e)
        {

        }

        private void bill_btn_Click(object sender, EventArgs e)
        {

        }

        private void resource_btn_Click(object sender, EventArgs e)
        {

        }

        private void room_btn_Click(object sender, EventArgs e)
        {

        }

        private void staff_details_btn_Click(object sender, EventArgs e)
        {
            ChildDetailsForm childDetailsForm = new ChildDetailsForm();
            openChildForm(childDetailsForm);

        }
        private Form activeForm = null;
    }
}


