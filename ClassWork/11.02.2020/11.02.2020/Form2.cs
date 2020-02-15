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
    public partial class Form2 : Form
    {
        private SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable table=  null;
        SqlCommandBuilder cmd = null;
        string cs = "";
        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection();
            cs = ConfigurationManager.
                    ConnectionStrings["LibraryConnStr"].
                    ConnectionString;
            conn.ConnectionString = cs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(
            //    String.IsNullOrEmpty(LoginTB.Text)&&String.IsNullOrEmpty(PasswordTB.Text)&&
            //    String.IsNullOrEmpty(AddressTB.Text)&&String.IsNullOrEmpty(PhoneTB.Text)
            //    )
            //{
                SqlConnection conn = new SqlConnection(cs);
                table = new DataTable();
                da = new SqlDataAdapter("select * from Users", conn);
                cmd = new SqlCommandBuilder(da);
                da.Fill(table);
                

                DataRow row = table.NewRow();
                row["Login"] = LoginTB.Text;
                row["Phone"] = PhoneTB.Text;
                row["Address"] = AddressTB.Text;
                row["Password"] = PasswordTB.Text;
                row["IsAdmin"] = IsAdmin.Checked;
                table.Rows.Add(row);

                da.Update(table);
            //}
        }
    }
}
