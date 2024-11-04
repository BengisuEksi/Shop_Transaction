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

namespace Transaction_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=RelationalDatabase;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute RelationalDatabase", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Product ComboBox
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Product", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            product_combobox.ValueMember = "ID";
            product_combobox.DisplayMember = "Name";
            product_combobox.DataSource = dt1;

            // Customer ComboBox
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Customer", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            customer_combobox.ValueMember = "ID";
            customer_combobox.DisplayMember = "FullName";
            customer_combobox.DataSource = dt2;

            // Personnel ComboBox
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from Tbl_Personnel", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            personnel_combobox.ValueMember = "ID";
            personnel_combobox.DisplayMember = "Name";
            personnel_combobox.DataSource = dt3;

            personnel_combobox.SelectedIndex = -1;
            customer_combobox.SelectedIndex = -1;
            product_combobox.SelectedIndex = -1;
        }

        private void list_bttn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute RelationalDatabase", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void sell_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Transaction (Product,Customer,Personnel,Price) values (@p1,@p2,@p3,@p4)", conn);
            cmd.Parameters.AddWithValue("@p1", product_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p2",customer_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p3", personnel_combobox.SelectedValue);
            cmd.Parameters.AddWithValue("@p4",price_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sales transaction is completed.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productadd_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Product (Name,Stock,PurchasePrice,SellingPrice) values (@p1,@p2,@p3,@p4)", conn);
            cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", stock_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", purchasePrice_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", sellingPrice_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New product is added.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updatelist_bttn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Product", conn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            product_combobox.ValueMember = "ID";
            product_combobox.DisplayMember = "Name";
            product_combobox.DataSource = dt1;
            product_combobox.SelectedIndex = -1;
        }

        private void updateCustomer_bttn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Customer", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            customer_combobox.ValueMember = "ID";
            customer_combobox.DisplayMember = "FullName";
            customer_combobox.DataSource = dt2;
            customer_combobox.SelectedIndex = -1;
        }

        private void updatePersonnel_bttn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from Tbl_Personnel", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            personnel_combobox.ValueMember = "ID";
            personnel_combobox.DisplayMember = "Name";
            personnel_combobox.DataSource = dt3;
            personnel_combobox.SelectedIndex = -1;
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            product_combobox.SelectedIndex = -1;
            customer_combobox.SelectedIndex = -1;
            personnel_combobox.SelectedIndex = -1;
            price_txtbox.Text = "";
            name_txtbox.Text = "";
            stock_txtbox.Text = "";
            purchasePrice_txtbox.Text = "";
            sellingPrice_txtbox.Text = "";
            personnelname_txtbox.Text = "";
            customername_txtbox.Text = "";

        }

        private void customeradd_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Customer (FullName) values (@p1)", conn);
            cmd.Parameters.AddWithValue("@p1", customername_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New customer is added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void personneladd_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Personnel (Name) values (@p1)", conn);
            cmd.Parameters.AddWithValue("@p1", personnelname_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New personnel is added.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
