using System.Drawing;

namespace QRCodeReader
{
    partial class resme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resme));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.mob = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(875, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // id
            // 
            this.id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(427, 29);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(197, 22);
            this.id.TabIndex = 1;
            this.id.Text = "00000";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(50, 131);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(46, 18);
            this.name.TabIndex = 2;
            this.name.Text = "label1";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.BackColor = System.Drawing.Color.Transparent;
            this.lastname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(50, 185);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(46, 18);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "label1";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.Color.Transparent;
            this.dob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(50, 235);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(46, 18);
            this.dob.TabIndex = 2;
            this.dob.Text = "label1";
            // 
            // mob
            // 
            this.mob.AutoSize = true;
            this.mob.BackColor = System.Drawing.Color.Transparent;
            this.mob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mob.Location = new System.Drawing.Point(50, 289);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(46, 18);
            this.mob.TabIndex = 2;
            this.mob.Text = "label1";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(50, 362);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(46, 18);
            this.address.TabIndex = 2;
            this.address.Text = "label1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(378, 324);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(483, 243);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(444, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 272);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(771, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "+  LOH";
            // 
            // resme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.pictureBox1);
            this.Name = "resme";
            this.Text = "resme";
            this.Load += new System.EventHandler(this.resme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label mob;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}