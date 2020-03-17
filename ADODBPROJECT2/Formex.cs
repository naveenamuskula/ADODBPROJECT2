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
    public partial class Formex : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        string PID;
        public Formex(string PID)
        {
            this.PID = PID;
            InitializeComponent();

        }

        private void Formex_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");
            adp = new SqlDataAdapter("select * from Productdetails where ProductID=@PID ", con);
            adp.SelectCommand.Parameters.AddWithValue("@PID", PID);
            DataSet ds = new DataSet();
            adp.Fill(ds,"p");
            label4.Text = ds.Tables[0].Rows[0][0].ToString();
            label5.Text = ds.Tables[0].Rows[0][1].ToString();
            label6.Text = ds.Tables[0].Rows[0][2].ToString();
            
        }
    }
}
