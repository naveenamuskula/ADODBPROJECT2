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
    public partial class triggerex2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public triggerex2()
        {
            InitializeComponent();
        }

        private void triggerex2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_exemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            SqlParameter s = new SqlParameter("@status", SqlDbType.NVarChar, 200);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(s.Value.ToString());
        }
    }
}
