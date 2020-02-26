using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_with_async_await
{
    public partial class Form1 : Form
    {
        DbConnection conn = null;
        string connectionString = null;
        List<int> AuthorsId;
        bool IsQueryNormal=false;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["LibraryConnStr"].ConnectionString;
            conn = new SqlConnection(connectionString);
            AuthorsId = new List<int>();
        }
        private async Task FillComboBox(List<int> AuthorsId_, DbConnection conn)
        {
            comboBox1.Items.Clear();
            DbCommand comm;
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            DataRow row = dt.NewRow();
            foreach (var i in AuthorsId_)
            {
                comm = conn.CreateCommand();
                comm.CommandText = "SELECT Author_Name FROM Authors WHERE Authors.Id=" + i.ToString();
                using (DbDataReader reader = await comm.ExecuteReaderAsync())
                {
                    await reader.ReadAsync();
                    row[0] = await reader.GetFieldValueAsync<object>(0);
                    comboBox1.Items.Add(row[0]);
                }
            }
        }
        void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckQuery();
        }
        private void CheckQuery()
        {
            if (textBox1.Text == "select * from Books")
            {
                IsQueryNormal = true;
            }
            else
            {
                IsQueryNormal = false;
            }
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsQueryNormal)
            {
                return;
            }
            Num.Text = comboBox1.Items[((ComboBox)sender).SelectedIndex].ToString();
            await conn.OpenAsync();
            DbCommand comm;
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            DataRow row = dt.NewRow();
            comm = conn.CreateCommand();
            comm.CommandText = "select count(id) from Books where Author_Id=" + ((ComboBox)sender).SelectedIndex;
            using (DbDataReader reader = await comm.ExecuteReaderAsync())
            {
                await reader.ReadAsync();
                Num.Text = reader.FieldCount.ToString();
                row[0] = await reader.GetFieldValueAsync<object>(0);

                Num.Text=row[0].ToString();
            }

            conn.Close();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            CheckQuery();
            await conn.OpenAsync(); // 1

            DbCommand comm = conn.CreateCommand();
            //comm.CommandText = "WAITFOR DELAY '00:00:02';";
            comm.CommandText += textBox1.Text.ToString();

            DataTable table = new DataTable();
            using (DbDataReader reader = await comm.ExecuteReaderAsync()) // 2
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    table.Columns.Add(reader.GetName(i));
                }
                do
                {
                    while (await reader.ReadAsync())    // 3
                    {
                        DataRow row = table.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[i] = await reader.GetFieldValueAsync<object>(i); // 4
                        }
                        if (!(AuthorsId.Contains(int.Parse((string)row[2]))))
                        {
                            AuthorsId.Add(int.Parse((string)row[2]));
                        }
                        table.Rows.Add(row);
                    }
                } while (await reader.NextResultAsync());
                reader.Close();
                if (IsQueryNormal)
                {
                    await FillComboBox(AuthorsId, conn);
                }
            }

            // show query result
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = table;

            conn.Close();
            button1.Enabled = true;
        }
    }
}