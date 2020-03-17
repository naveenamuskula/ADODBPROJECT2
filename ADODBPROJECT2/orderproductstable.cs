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
    public partial class orderproductstable : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public orderproductstable()
        {
            InitializeComponent();
        }

        private void orderproductstable_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");
            panel1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code for orderid
            adp = new SqlDataAdapter("select count(*) from Orderdetails", con);
            DataSet ds = new DataSet();
            adp.Fill(ds,"p");
            txtorderid.Text = (int.Parse(ds.Tables["p"].Rows[0][0].ToString())+1).ToString();
            //code to populate values into salesman id combobox
            adp = new SqlDataAdapter("select SalesmanId,SalesManName from Salesmandetails", con);
            adp.Fill(ds, "s");
            cbbsalesmanid.DataSource = ds.Tables["s"];
            cbbsalesmanid.DisplayMember = "SalesManName";
            cbbsalesmanid.ValueMember = "SalesmanId";
            //code to populate values into customer id combobox
            adp = new SqlDataAdapter("select CustomerID,Customername from Customerdetails", con);
            adp.Fill(ds, "c");
            cbbcustomerid.DataSource = ds.Tables["c"];
            cbbcustomerid.DisplayMember = "Customername";
            cbbcustomerid.ValueMember = "CustomerID";
            panel1.Visible = true;
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("SP_IOrderProducts", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@oid", txtorderid.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdesc", txtorderdesc.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdate",DateTime.Parse(dtpod.Text));
            adp.SelectCommand.Parameters.AddWithValue("@discount",int.Parse(txtdiscount.Text));
            adp.SelectCommand.Parameters.AddWithValue("@custid",cbbcustomerid.SelectedValue);
            adp.SelectCommand.Parameters.AddWithValue("@salesid",cbbsalesmanid.SelectedValue);
            DataTable MyTable = new DataTable();
            MyTable.Columns.Add("Orderid", typeof(string));
            MyTable.Columns.Add("ProductID", typeof(string));
            MyTable.Columns.Add("qty", typeof(Int32));
            MessageBox.Show(dgv.Rows.Count.ToString());
            for(int i=0;i<dgv.Rows.Count-1;i++)
            {
                MyTable.Rows.Add(txtorderid.Text, dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[2].Value.ToString());
            }
            SqlParameter P = new SqlParameter("@ord_pro", MyTable);//sending table to database
            P.SqlDbType = SqlDbType.Structured;//structured is used when we are sending TABLE
            adp.SelectCommand.Parameters.Add(P);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show("order placed");
            panel1.Visible = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.CurrentCell.ColumnIndex.Equals(0))
            {
                adp = new SqlDataAdapter("select ProductID from Productdetails", con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "PID");
                //to populate the combo box values in each row first column
                foreach(DataGridViewRow row in dgv.Rows)
                {
                    //to convert dgv cell to combobox cell
                    (row.Cells[0] as DataGridViewComboBoxCell).DataSource = ds.Tables["PID"];
                    (row.Cells[0] as DataGridViewComboBoxCell).DisplayMember = "ProductID";
                }
            }
        }

        //private void dgv_CellLeave(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Cells[0].Value!=null)
            {
                if (!dgv.CurrentCell.ColumnIndex.Equals(0))
                {
                    adp = new SqlDataAdapter("select * from Productdetails where ProductID=@P", con);
                    //to get the product details of current row productId  which is selected
                    adp.SelectCommand.Parameters.AddWithValue("@P", dgv.CurrentRow.Cells[0].Value);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "P");
                    dgv.CurrentRow.Cells[1].Value = ds.Tables["P"].Rows[0][1];
                    dgv.CurrentRow.Cells[3].Value = ds.Tables["P"].Rows[0][2];

                }
            }
        }

        private void dgv_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow.Cells[2].Value != null)
            {
                int Q = int.Parse(dgv.CurrentRow.Cells[2].Value.ToString());
                int P = int.Parse(dgv.CurrentRow.Cells[3].Value.ToString());
                dgv.CurrentRow.Cells[4].Value = Q * P;
            }
        }
    }
}
