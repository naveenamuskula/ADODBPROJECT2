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

namespace ADODBPROJECT2
{
    public partial class ageex : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public ageex()
        {
            InitializeComponent();
        }

        private void ageex_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select  empno,ename,dbo.fn_age(@hd) from EMPDATA where HIREDATE=@hd ", con);
            adp.SelectCommand.Parameters.AddWithValue("@hd",DateTime.Parse(dtphiredate.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            dgv1.DataSource = ds.Tables["E"];
        }
    }
}
