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
    public partial class spextractex : Form
    {

        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public spextractex()
        {
            InitializeComponent();
        }

        private void spextractex_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");

        }
        private void txtempno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_Extract", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            SqlParameter s = new SqlParameter("@status", SqlDbType.NVarChar, 200);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            ds = new DataSet();
            adp.Fill(ds, "E");
            DataRow R =null;
            try
            {
                R = ds.Tables["E"].Rows[0];
                txtempname.Text = R[1].ToString();
                txtjob.Text = R[2].ToString();
                txtmgr.Text = R[3].ToString();
                dtphiredate.Text = R[4].ToString();
                txtsalary.Text = R[5].ToString();
                txtcommission.Text = R[6].ToString();
                cbbdeptno.Text = R[7].ToString();
                
                
            }
            catch(NullReferenceException E)
            {
                clear();
                MessageBox.Show("empno does not exist");
            }
        }
        private void clear()
        {
            
            txtempname.Text = "";
            txtjob.Text = "";
            txtmgr.Text = "";
            dtphiredate.Text = "";
            txtsalary.Text = "";
            txtcommission.Text = "";
            cbbdeptno.Text = "";

        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_updatedata", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@newjob", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@incrper",txtincrement.Text);
            SqlParameter p = new SqlParameter("@status", SqlDbType.NVarChar, 100);
            p.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(p);
            ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(p.Value.ToString());

        }

    }
}
