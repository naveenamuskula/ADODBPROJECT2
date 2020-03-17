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
    public partial class cursorex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public cursorex1()
        {
            InitializeComponent();
        }

        private void cursorex1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                adp = new SqlDataAdapter("sp_cursorex", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
                SqlParameter s = new SqlParameter("@result", SqlDbType.NVarChar, 200);
                s.Direction = ParameterDirection.Output;
                adp.SelectCommand.Parameters.Add(s);
                ds = new DataSet();
                adp.Fill(ds);
                MessageBox.Show(s.Value.ToString());
            }
            catch(FormatException E)
            {
                MessageBox.Show("enter deptno");
            }
        }
    }
}
