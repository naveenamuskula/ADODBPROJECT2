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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ADODBPROJECT2
{
    public partial class assignment1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public assignment1()
        {
            InitializeComponent();
        }

        private void assignment1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-3TBUP87");
            adp = new SqlDataAdapter("select * from EMPDATA", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            dgv.DataSource = ds.Tables["E"];
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("d:\\Test1.pdf", FileMode.Create));
            doc.Open();//Open Document to write
            Paragraph paragraph = new Paragraph("data Exported From DataGridview!");
            DataTable Emp = new DataTable();
            Emp.Columns.Add("empno", typeof(Int32));
            Emp.Columns.Add("ename", typeof(string));
            Emp.Columns.Add("job", typeof(string));
            Emp.Columns.Add("mgr", typeof(Int32));
            Emp.Columns.Add("hiredate", typeof(DateTime));
            Emp.Columns.Add("sal", typeof(Int32));
            Emp.Columns.Add("comm", typeof(Int32));
            Emp.Columns.Add("deptno", typeof(Int32));
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (dgv.Rows[i].Cells[0].Value!=null)
                {
                    bool isChecked = (bool)dgv.Rows[i].Cells[0].Value;
                    if (isChecked == true)
                    {
                        DataRow r = Emp.NewRow();
                        r["empno"] = dgv.Rows[i].Cells[1].Value.ToString();
                        r["ename"] = dgv.Rows[i].Cells[2].Value.ToString();
                        r["job"] = dgv.Rows[i].Cells[3].Value.ToString();
                        r["mgr"] = dgv.Rows[i].Cells[4].Value.ToString();
                        r["hiredate"] = dgv.Rows[i].Cells[5].Value.ToString();
                        r["sal"] = dgv.Rows[i].Cells[6].Value.ToString();
                        r["comm"] = dgv.Rows[i].Cells[7].Value.ToString();
                        r["deptno"] = dgv.Rows[i].Cells[8].Value.ToString();
                        Emp.Rows.Add(r);
                    }
                }
            }
            PdfPTable table = new PdfPTable(Emp.Columns.Count);
            //foreach(DataGridViewColumn column in dgv.Columns)
            //{
            //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            //    table.AddCell(cell);
            //}
            for (int j=1;j<=Emp.Columns.Count; j++)
            {
                table.AddCell(dgv.Columns[j].HeaderText);
            }
            for (int i=0;i<Emp.Rows.Count;i++)
            {
                for(int j=0;j<Emp.Columns.Count;j++)
                {
                    table.AddCell(Emp.Rows[i][j].ToString());
                }
            }
            doc.Add(table);
            MessageBox.Show("file generated");
            doc.Close();
        }
    }
}

