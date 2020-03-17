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
    public partial class spex1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp= null;
        public spex1()
        {
            InitializeComponent();
        }

        private void spex1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ADODB;Data Source=DESKTOP-3TBUP87");
            
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_Insertemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno",int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@g", cbbgender.Text);
            adp.SelectCommand.Parameters.AddWithValue("@Db", DateTime.Parse(dtpdob.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            //input parameters
            SqlParameter p = new SqlParameter("@result", SqlDbType.NVarChar,200);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
            Console.Read();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_Updateemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@en", txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@Db", DateTime.Parse(dtpdob.Text));
            //output parameter
            SqlParameter p = new SqlParameter("@result", SqlDbType.NVarChar, 200);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());
            Console.Read();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_Deleteemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            //output parameter
            SqlParameter s= new SqlParameter("@result", SqlDbType.NVarChar, 200);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(s.Value.ToString());
            Console.Read();

        }
    }
}
