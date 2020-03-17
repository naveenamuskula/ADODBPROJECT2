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
    public partial class Assignment : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        string PID;
        public Assignment()
        {
            InitializeComponent();
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
           
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");
            adp = new SqlDataAdapter("select * from Productdetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "PID");
            dgv.DataSource = ds.Tables["PID"];
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Formex F = new Formex(PID);
            F.Show();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.CurrentCell.ColumnIndex==0)
            {
                for(int i=0;i<dgv.Rows.Count-1;i++)
                {
                    dgv.Rows[i].Cells[0].Value = false;
                }
                dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value = true;
            }
            for(int i=0;i<dgv.Rows.Count-1;i++)
            {
                bool isChecked = (bool)dgv.Rows[i].Cells[0].Value;
                if(isChecked==true)
                {
                    PID = dgv.CurrentRow.Cells[1].Value.ToString();
                }
            }
        }
    }
}
