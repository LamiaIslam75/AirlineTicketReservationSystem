namespace AirlineSystemPro
{
    partial class ViewDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStop3 = new System.Windows.Forms.Label();
            this.lblStop2 = new System.Windows.Forms.Label();
            this.lblStop1 = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblStop3);
            this.panel1.Controls.Add(this.lblStop2);
            this.panel1.Controls.Add(this.lblStop1);
            this.panel1.Controls.Add(this.lblEnd);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 507);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 495);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblStop3
            // 
            this.lblStop3.AutoSize = true;
            this.lblStop3.Location = new System.Drawing.Point(45, 131);
            this.lblStop3.Name = "lblStop3";
            this.lblStop3.Size = new System.Drawing.Size(30, 13);
            this.lblStop3.TabIndex = 11;
            this.lblStop3.Text = "From";
            this.lblStop3.Click += new System.EventHandler(this.lblStop3_Click);
            // 
            // lblStop2
            // 
            this.lblStop2.AutoSize = true;
            this.lblStop2.Location = new System.Drawing.Point(45, 93);
            this.lblStop2.Name = "lblStop2";
            this.lblStop2.Size = new System.Drawing.Size(30, 13);
            this.lblStop2.TabIndex = 10;
            this.lblStop2.Text = "From";
            this.lblStop2.Click += new System.EventHandler(this.lblStop2_Click);
            // 
            // lblStop1
            // 
            this.lblStop1.AutoSize = true;
            this.lblStop1.Location = new System.Drawing.Point(45, 52);
            this.lblStop1.Name = "lblStop1";
            this.lblStop1.Size = new System.Drawing.Size(30, 13);
            this.lblStop1.TabIndex = 9;
            this.lblStop1.Text = "From";
            this.lblStop1.Click += new System.EventHandler(this.lblStop1_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(155, 8);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(30, 13);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.Text = "From";
            this.lblEnd.Click += new System.EventHandler(this.lblEnd_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(45, 8);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(35, 13);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "label1";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 507);
            this.Controls.Add(this.panel1);
            this.Name = "ViewDetails";
            this.Text = "ViewDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewDetails_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStop3;
        private System.Windows.Forms.Label lblStop2;
        private System.Windows.Forms.Label lblStop1;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
    }
}