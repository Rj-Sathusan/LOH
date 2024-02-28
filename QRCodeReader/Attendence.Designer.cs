namespace QRCodeReader
{
    partial class Attendence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search_box = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grid_view = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(69, 86);
            this.search_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(446, 31);
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
            this.search_box.TabIndex = 32;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Search";
            // 
            // grid_view
            // 
            this.grid_view.AllowUserToAddRows = false;
            this.grid_view.AllowUserToDeleteRows = false;
            this.grid_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_view.BackgroundColor = System.Drawing.Color.White;
            this.grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Type,
            this.Column1,
            this.Column2});
            this.grid_view.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.grid_view.Location = new System.Drawing.Point(26, 148);
            this.grid_view.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid_view.Name = "grid_view";
            this.grid_view.ReadOnly = true;
            this.grid_view.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.grid_view.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grid_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_view.Size = new System.Drawing.Size(817, 375);
            this.grid_view.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "+  LOH";
            // 
            // id
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            this.id.DefaultCellStyle = dataGridViewCellStyle9;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            this.Type.DefaultCellStyle = dataGridViewCellStyle10;
            this.Type.HeaderText = "Name";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 200;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(584, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 528);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_view);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Attendence";
            this.Text = "Attendence";
            this.Load += new System.EventHandler(this.Attendence_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox search_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid_view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}