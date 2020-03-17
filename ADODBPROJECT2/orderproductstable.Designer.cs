namespace ADODBPROJECT2
{
    partial class orderproductstable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbcustomerid = new System.Windows.Forms.ComboBox();
            this.cbbsalesmanid = new System.Windows.Forms.ComboBox();
            this.dtpod = new System.Windows.Forms.DateTimePicker();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.txtorderdesc = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Productdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "orderid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "orderdesc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "order date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "customerid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "salesmanid";
            // 
            // cbbcustomerid
            // 
            this.cbbcustomerid.FormattingEnabled = true;
            this.cbbcustomerid.Location = new System.Drawing.Point(481, 59);
            this.cbbcustomerid.Name = "cbbcustomerid";
            this.cbbcustomerid.Size = new System.Drawing.Size(121, 21);
            this.cbbcustomerid.TabIndex = 6;
            // 
            // cbbsalesmanid
            // 
            this.cbbsalesmanid.FormattingEnabled = true;
            this.cbbsalesmanid.Location = new System.Drawing.Point(481, 117);
            this.cbbsalesmanid.Name = "cbbsalesmanid";
            this.cbbsalesmanid.Size = new System.Drawing.Size(121, 21);
            this.cbbsalesmanid.TabIndex = 7;
            // 
            // dtpod
            // 
            this.dtpod.Location = new System.Drawing.Point(149, 117);
            this.dtpod.Name = "dtpod";
            this.dtpod.Size = new System.Drawing.Size(200, 20);
            this.dtpod.TabIndex = 8;
            // 
            // txtorderid
            // 
            this.txtorderid.Enabled = false;
            this.txtorderid.Location = new System.Drawing.Point(149, 16);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(100, 20);
            this.txtorderid.TabIndex = 9;
            // 
            // txtorderdesc
            // 
            this.txtorderdesc.Location = new System.Drawing.Point(149, 69);
            this.txtorderdesc.Name = "txtorderdesc";
            this.txtorderdesc.Size = new System.Drawing.Size(100, 20);
            this.txtorderdesc.TabIndex = 10;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(481, 16);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 20);
            this.txtdiscount.TabIndex = 11;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Productdesc,
            this.quantity,
            this.unitprice,
            this.totalcost});
            this.dgv.Location = new System.Drawing.Point(72, 229);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(523, 150);
            this.dgv.TabIndex = 12;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowLeave);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Productdesc
            // 
            this.Productdesc.HeaderText = "description";
            this.Productdesc.Name = "Productdesc";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "qty";
            this.quantity.Name = "quantity";
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "unit price";
            this.unitprice.Name = "unitprice";
            // 
            // totalcost
            // 
            this.totalcost.HeaderText = "total cost of item";
            this.totalcost.Name = "totalcost";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(281, 180);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 13;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsubmit);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.txtorderdesc);
            this.panel1.Controls.Add(this.txtorderid);
            this.panel1.Controls.Add(this.dtpod);
            this.panel1.Controls.Add(this.cbbsalesmanid);
            this.panel1.Controls.Add(this.cbbcustomerid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 400);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "add bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderproductstable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "orderproductstable";
            this.Text = "orderproductstable";
            this.Load += new System.EventHandler(this.orderproductstable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbcustomerid;
        private System.Windows.Forms.ComboBox cbbsalesmanid;
        private System.Windows.Forms.DateTimePicker dtpod;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.TextBox txtorderdesc;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcost;
    }
}