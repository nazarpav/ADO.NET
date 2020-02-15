using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._02._2020
{
    public partial class Form1 : Form
    {
        private Form2 form=null;
        private SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable table = null;
        string cs = "";
        public Form1()
        {
            InitializeComponent();
            form = new Form2();
            table = new DataTable();
            cs = ConfigurationManager.
                    ConnectionStrings["LibraryConnStr"].
                    ConnectionString;
            UpdateLitsBox();
        }
        private void UpdateLitsBox()
        {
            da = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(cs);
            da = new SqlDataAdapter("select * from Users", conn);
            listBox1.Items.Clear();
            da.Update(table);
            table.Clear();
            da.Fill(table);
            string tmp=string.Empty;
            foreach (DataRow row in table.Rows)
            {
                foreach(var i in row.ItemArray)
                {
                    tmp += i.ToString()+" ";
                }
                listBox1.Items.Add(tmp);
            }
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            form = new Form2();
            form.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateLB_Click(object sender, EventArgs e)
        {
            UpdateLitsBox();
        }
    }
}
