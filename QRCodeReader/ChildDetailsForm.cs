using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using LOH.DAL;
using QRCodeReader;

namespace LOH
{
    public partial class ChildDetailsForm : KryptonForm  
    {
        private int _id;
        public function_ dalFunctions = new function_();
        public ChildrenDetails _childrenDetails = new ChildrenDetails();

        public ChildDetailsForm()
        {
            InitializeComponent();
            BindChildrenDetails();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            _ = save_btn.Text == "Save" ? CreateChildAndSaveOrEditOrDelete("save") : CreateChildAndSaveOrEditOrDelete("edit");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            CreateChildAndSaveOrEditOrDelete("delete");
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            dalFunctions.SearchGridView(grid_view, search_box.Text);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void grid_view_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private bool ValidateInput()
        {
            if (function_.IsNumeric(age_txt, "Age")) return false;
            // Add more validation if needed
            return true;
        }

        private bool CreateChildAndSaveOrEditOrDelete(string actionType)
        {
            try
            {
                if (ValidateInput())
                {
                    ChildrenDetails newChild = new ChildrenDetails(_id, name_txt.Text, fatherName_txt.Text, motherName_txt.Text, int.Parse(age_txt.Text), gender_txt.Text, indexNo_txt.Text, dateOfBirth_txt.Value, imagePath_txt.Text, address_txt.Text);
                    bool action = newChild.Save(actionType);
                    if (action)
                    {
                        RefreshForm();
                    }
                    return action;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                return false;
            }
        }

        private void RefreshForm()
        {
            try
            {
                dalFunctions.ClearTextBoxes(this);
                BindChildrenDetails();
                save_btn.Text = "Save";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }

        private void BindChildrenDetails()
        {
            _childrenDetails.BindChildrenDetails(grid_view);
        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            _ = save_btn.Text == "Save" ? CreateChildAndSaveOrEditOrDelete("save") : CreateChildAndSaveOrEditOrDelete("edit");

        }

        private void ChildDetailsForm_Load(object sender, EventArgs e)
        {
            BindChildrenDetails();
        }

        private void grid_view_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                List<Control> controlsToUpdate = new List<Control> { name_txt, fatherName_txt, motherName_txt, age_txt, gender_txt, indexNo_txt, dateOfBirth_txt, imagePath_txt, address_txt };
                // Call the function
                dalFunctions.SetTextBoxesFromSelectedRow(grid_view, controlsToUpdate, ref _id);
                save_btn.Text = "Edit";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");

            }
        }

        private void choose(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path and display it in the TextBox
                    imagePath_txt.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

        }

        private void search_box_TextChanged_1(object sender, EventArgs e)
        {
            dalFunctions.SearchGridView(grid_view, search_box.Text);
        }

        private void delete_btn_Click_1(object sender, EventArgs e)
        {
            CreateChildAndSaveOrEditOrDelete("delete");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //  var id2 = Convert.ToString(_id);
                resme resme = new resme(name_txt.Text, dateOfBirth_txt.Text, fatherName_txt.Text, address_txt.Text, motherName_txt.Text, indexNo_txt.Text, imagePath_txt.Text);
                resme.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }

        }

        private void clear_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                function_ dalFunctions = new function_();
                dalFunctions.ClearTextBoxes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");

            }

        }
    }
}
