namespace AirlineSystemPro
{
    partial class ViewUser
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
            this.dgvViewUser = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useremail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usercontactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewUser
            // 
            this.dgvViewUser.AllowUserToAddRows = false;
            this.dgvViewUser.AllowUserToDeleteRows = false;
            this.dgvViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.username,
            this.useremail,
            this.usercontactno});
            this.dgvViewUser.Location = new System.Drawing.Point(12, 90);
            this.dgvViewUser.Name = "dgvViewUser";
            this.dgvViewUser.ReadOnly = true;
            this.dgvViewUser.Size = new System.Drawing.Size(591, 188);
            this.dgvViewUser.TabIndex = 0;
            // 
            // userid
            // 
            this.userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "user ID";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // useremail
            // 
            this.useremail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.useremail.DataPropertyName = "useremail";
            this.useremail.HeaderText = "Email";
            this.useremail.Name = "useremail";
            this.useremail.ReadOnly = true;
            // 
            // usercontactno
            // 
            this.usercontactno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usercontactno.DataPropertyName = "usercontactno";
            this.usercontactno.HeaderText = "Contact No.";
            this.usercontactno.Name = "usercontactno";
            this.usercontactno.ReadOnly = true;
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(98, 32);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(100, 20);
            this.txtSearchUser.TabIndex = 1;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.dgvViewUser);
            this.Name = "ViewUser";
            this.Text = "ViewUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn useremail;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercontactno;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label label1;
    }
}