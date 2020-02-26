using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace AirlineSystemPro
{
    public partial class ViewUser : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public ViewUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            string sql = "select * from userinfo;";
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvViewUser.AutoGenerateColumns = false;
            this.dgvViewUser.DataSource = this.Ds.Tables[0];
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from userinfo where username like '" + this.txtSearchUser.Text + "%' ;";
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvViewUser.AutoGenerateColumns = false;
                this.dgvViewUser.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
    }
}
