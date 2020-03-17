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
    public partial class fnEmpLocex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public fnEmpLocex1()
        {
            InitializeComponent();
        }

        private void fnEmpLocex1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //using stored procedure
            adp = new SqlDataAdapter("sp_gross", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            
            //using multistmt table valued fn
            //adp = new SqlDataAdapter("select  * from dbo.fn_multistmt()", con);

            //using inline table valued fn
            //adp = new SqlDataAdapter("select  * from dbo.fn_first(@dno)", con);
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            ds = new DataSet();
            adp.Fill(ds, "E");
            dgv1.DataSource = ds.Tables["E"];
        }
    }
}
