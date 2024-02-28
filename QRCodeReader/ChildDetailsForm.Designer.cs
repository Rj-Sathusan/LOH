using System.Drawing;
using System.Windows.Forms;

namespace LOH
{
    partial class ChildDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildDetailsForm));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.grid_view = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avilability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clear_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.delete_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.save_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.search_box = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fatherName_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.motherName_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.age_txt = new System.Windows.Forms.NumericUpDown();
            this.dateOfBirth_txt = new System.Windows.Forms.DateTimePicker();
            this.IndexNo = new System.Windows.Forms.Label();
            this.indexNo_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.imagePath_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gender_txt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Rounding = 20;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Width = 1;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 20;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 1;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.Rounding = 20;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateNormal.Border.Width = 1;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(136)))), ((int)(((byte)(187)))));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.Rounding = 20;
            this.kryptonPalette1.ButtonStyles.ButtonStandalone.StateTracking.Border.Width = 1;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "+  LOH";
            // 
            // grid_view
            // 
            this.grid_view.BackgroundColor = System.Drawing.Color.White;
            this.grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Type,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Capacity,
            this.Avilability,
            this.Column5,
            this.Column6});
            this.grid_view.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.grid_view.Location = new System.Drawing.Point(-5, 434);
            this.grid_view.Name = "grid_view";
            this.grid_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_view.Size = new System.Drawing.Size(805, 244);
            this.grid_view.TabIndex = 8;
            this.grid_view.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_view_CellMouseDoubleClick_1);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Name";
            this.Type.Name = "Type";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Index";
            this.Capacity.Name = "Capacity";
            // 
            // Avilability
            // 
            this.Avilability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Avilability.HeaderText = "DOB";
            this.Avilability.Name = "Avilability";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(15, 89);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(301, 31);
            this.name_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.name_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.name_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.name_txt.StateCommon.Border.Rounding = 20;
            this.name_txt.StateCommon.Border.Width = 1;
            this.name_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.name_txt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.name_txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(666, 376);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.clear_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.clear_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.clear_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.clear_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clear_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.clear_btn.OverrideDefault.Border.Rounding = 20;
            this.clear_btn.OverrideDefault.Border.Width = 1;
            this.clear_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.clear_btn.Size = new System.Drawing.Size(118, 43);
            this.clear_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.clear_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.clear_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.clear_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.clear_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clear_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.clear_btn.StateCommon.Border.Rounding = 20;
            this.clear_btn.StateCommon.Border.Width = 1;
            this.clear_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.clear_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.clear_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.clear_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.clear_btn.StatePressed.Back.ColorAngle = 135F;
            this.clear_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.clear_btn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.clear_btn.StatePressed.Border.ColorAngle = 135F;
            this.clear_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clear_btn.StatePressed.Border.Rounding = 20;
            this.clear_btn.StatePressed.Border.Width = 1;
            this.clear_btn.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.clear_btn.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.clear_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.clear_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.clear_btn.StateTracking.Back.ColorAngle = 135F;
            this.clear_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.clear_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.clear_btn.StateTracking.Border.ColorAngle = 135F;
            this.clear_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clear_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.clear_btn.StateTracking.Border.Rounding = 20;
            this.clear_btn.StateTracking.Border.Width = 1;
            this.clear_btn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.clear_btn.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.clear_btn.TabIndex = 34;
            this.clear_btn.Values.Text = "Clear";
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click_1);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(518, 376);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.delete_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.delete_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.delete_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.delete_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.delete_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.delete_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete_btn.OverrideDefault.Border.Rounding = 20;
            this.delete_btn.OverrideDefault.Border.Width = 1;
            this.delete_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.delete_btn.Size = new System.Drawing.Size(123, 43);
            this.delete_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.delete_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.delete_btn.StateCommon.Back.ColorAngle = 45F;
            this.delete_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.delete_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.delete_btn.StateCommon.Border.ColorAngle = 45F;
            this.delete_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete_btn.StateCommon.Border.Rounding = 20;
            this.delete_btn.StateCommon.Border.Width = 1;
            this.delete_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.delete_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.delete_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.delete_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.delete_btn.StatePressed.Back.ColorAngle = 135F;
            this.delete_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.delete_btn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.delete_btn.StatePressed.Border.ColorAngle = 135F;
            this.delete_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete_btn.StatePressed.Border.Rounding = 20;
            this.delete_btn.StatePressed.Border.Width = 1;
            this.delete_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.delete_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.delete_btn.StateTracking.Back.ColorAngle = 135F;
            this.delete_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.delete_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.delete_btn.StateTracking.Border.ColorAngle = 135F;
            this.delete_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.delete_btn.StateTracking.Border.Rounding = 20;
            this.delete_btn.StateTracking.Border.Width = 1;
            this.delete_btn.TabIndex = 32;
            this.delete_btn.Values.Text = "Delete";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click_1);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(363, 376);
            this.save_btn.Name = "save_btn";
            this.save_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.save_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.save_btn.OverrideDefault.Back.ColorAngle = 45F;
            this.save_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.save_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.save_btn.OverrideDefault.Border.ColorAngle = 45F;
            this.save_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.save_btn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.save_btn.OverrideDefault.Border.Rounding = 20;
            this.save_btn.OverrideDefault.Border.Width = 1;
            this.save_btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.save_btn.Size = new System.Drawing.Size(123, 43);
            this.save_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.save_btn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.save_btn.StateCommon.Back.ColorAngle = 45F;
            this.save_btn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.save_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.save_btn.StateCommon.Border.ColorAngle = 45F;
            this.save_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.save_btn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.save_btn.StateCommon.Border.Rounding = 20;
            this.save_btn.StateCommon.Border.Width = 1;
            this.save_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.save_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.save_btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.save_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.save_btn.StatePressed.Back.ColorAngle = 135F;
            this.save_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.save_btn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.save_btn.StatePressed.Border.ColorAngle = 135F;
            this.save_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.save_btn.StatePressed.Border.Rounding = 20;
            this.save_btn.StatePressed.Border.Width = 1;
            this.save_btn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.save_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.save_btn.StateTracking.Back.ColorAngle = 135F;
            this.save_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.save_btn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.save_btn.StateTracking.Border.ColorAngle = 135F;
            this.save_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.save_btn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.save_btn.StateTracking.Border.Rounding = 20;
            this.save_btn.StateTracking.Border.Width = 1;
            this.save_btn.TabIndex = 33;
            this.save_btn.Values.Text = "Save";
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(63, 397);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(278, 31);
            this.search_box.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.search_box.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_box.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_box.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_box.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.search_box.StateCommon.Border.Rounding = 20;
            this.search_box.StateCommon.Border.Width = 1;
            this.search_box.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.search_box.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.search_box.TabIndex = 30;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(4, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Search";
            // 
            // fatherName_txt
            // 
            this.fatherName_txt.Location = new System.Drawing.Point(15, 160);
            this.fatherName_txt.Name = "fatherName_txt";
            this.fatherName_txt.Size = new System.Drawing.Size(301, 31);
            this.fatherName_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.fatherName_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fatherName_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fatherName_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fatherName_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.fatherName_txt.StateCommon.Border.Rounding = 20;
            this.fatherName_txt.StateCommon.Border.Width = 1;
            this.fatherName_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.fatherName_txt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherName_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fatherName_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Father Name";
            // 
            // motherName_txt
            // 
            this.motherName_txt.Location = new System.Drawing.Point(15, 225);
            this.motherName_txt.Name = "motherName_txt";
            this.motherName_txt.Size = new System.Drawing.Size(301, 31);
            this.motherName_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.motherName_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.motherName_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.motherName_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.motherName_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.motherName_txt.StateCommon.Border.Rounding = 20;
            this.motherName_txt.StateCommon.Border.Width = 1;
            this.motherName_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.motherName_txt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherName_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.motherName_txt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(13, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mother Name";
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(398, 246);
            this.address_txt.Multiline = true;
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(366, 80);
            this.address_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.address_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.address_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.address_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.address_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.address_txt.StateCommon.Border.Rounding = 20;
            this.address_txt.StateCommon.Border.Width = 1;
            this.address_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.address_txt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.address_txt.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(402, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(402, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "DOB";
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(19, 298);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(126, 28);
            this.age_txt.TabIndex = 36;
            // 
            // dateOfBirth_txt
            // 
            this.dateOfBirth_txt.Location = new System.Drawing.Point(402, 163);
            this.dateOfBirth_txt.Name = "dateOfBirth_txt";
            this.dateOfBirth_txt.Size = new System.Drawing.Size(362, 28);
            this.dateOfBirth_txt.TabIndex = 37;
            // 
            // IndexNo
            // 
            this.IndexNo.AutoSize = true;
            this.IndexNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IndexNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IndexNo.Location = new System.Drawing.Point(399, 62);
            this.IndexNo.Name = "IndexNo";
            this.IndexNo.Size = new System.Drawing.Size(59, 17);
            this.IndexNo.TabIndex = 10;
            this.IndexNo.Text = "IndexNo";
            // 
            // indexNo_txt
            // 
            this.indexNo_txt.Location = new System.Drawing.Point(402, 89);
            this.indexNo_txt.Name = "indexNo_txt";
            this.indexNo_txt.Size = new System.Drawing.Size(128, 31);
            this.indexNo_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.indexNo_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.indexNo_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.indexNo_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.indexNo_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.indexNo_txt.StateCommon.Border.Rounding = 20;
            this.indexNo_txt.StateCommon.Border.Width = 1;
            this.indexNo_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.indexNo_txt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexNo_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.indexNo_txt.TabIndex = 1;
            // 
            // imagePath_txt
            // 
            this.imagePath_txt.Location = new System.Drawing.Point(552, 89);
            this.imagePath_txt.Multiline = true;
            this.imagePath_txt.Name = "imagePath_txt";
            this.imagePath_txt.Size = new System.Drawing.Size(212, 31);
            this.imagePath_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.imagePath_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imagePath_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imagePath_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.imagePath_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.imagePath_txt.StateCommon.Border.Rounding = 20;
            this.imagePath_txt.StateCommon.Border.Width = 1;
            this.imagePath_txt.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.imagePath_txt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePath_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.imagePath_txt.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(178, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Gender";
            // 
            // gender_txt
            // 
            this.gender_txt.FormattingEnabled = true;
            this.gender_txt.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.gender_txt.Location = new System.Drawing.Point(181, 298);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(135, 28);
            this.gender_txt.TabIndex = 39;
            this.gender_txt.Text = "Male";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(577, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Choose Image";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(559, 52);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(127, 34);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 20;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateTracking.Back.ColorAngle = 135F;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateTracking.Border.ColorAngle = 135F;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.Rounding = 20;
            this.kryptonButton1.StateTracking.Border.Width = 1;
            this.kryptonButton1.TabIndex = 33;
            this.kryptonButton1.Values.Text = "Save";
            this.kryptonButton1.Click += new System.EventHandler(this.choose);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(702, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ChildDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gender_txt);
            this.Controls.Add(this.dateOfBirth_txt);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.motherName_txt);
            this.Controls.Add(this.fatherName_txt);
            this.Controls.Add(this.imagePath_txt);
            this.Controls.Add(this.indexNo_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IndexNo);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kryptonButton1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChildDetailsForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ChildDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_view;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox name_txt;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton clear_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton delete_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton save_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox search_box;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox fatherName_txt;
        private Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox motherName_txt;
        private Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox address_txt;
        private Label label7;
        private Label label5;
        private Label label8;
        private NumericUpDown age_txt;
        private DateTimePicker dateOfBirth_txt;
        private Label IndexNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox indexNo_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox imagePath_txt;
        private Label label10;
        private ComboBox gender_txt;
        private Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn Avilability;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private PictureBox pictureBox1;
    }
}