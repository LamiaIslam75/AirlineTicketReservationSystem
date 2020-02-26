using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AirlineSystemPro
{
    public partial class SignUp : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }

        public SignUp()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }
        

        private void btnSignUpSubmit_Click(object sender, EventArgs e)
        {
            
            if (this.txtSignUpUserName.Text != null || this.txtSignUpPassword != null || this.txtSignUpEmail != null)
            {
                if (this.txtSignUpReEnterPassword.Text != this.txtSignUpPassword.Text)
                {
                    MessageBox.Show("Please Re enter password correctly.");
                }
                else
                {
                    string sql="insert into userinfo values('"+txtSignUpUserId.Text+"','"+txtSignUpUserName.Text+"','"+txtSignUpPassword.Text+"','"+txtSignUpContactNo.Text+"','"+txtSignUpEmail.Text+"');";
                    this.da.ExecuteUpdateQuery(sql);
                    

                    this.Visible = false;
                    new Login().Visible = true;
                }
            }
            
        }

        private void btnSignUpReset_Click(object sender, EventArgs e)
        {
            this.txtSignUpUserName.Text = null;
            this.txtSignUpPassword.Text = null;
            this.txtSignUpReEnterPassword.Text = null;
            this.txtSignUpEmail.Clear();
            this.txtSignUpContactNo.Clear();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
