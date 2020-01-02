using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class StudentDueForm : Form
    {

        string connstring = "datasource=localhost;port=3307;user=root;password=toor";
        MySqlConnection conn;



        public StudentDueForm()
        {
            InitializeComponent();
        }

        private void StudentDueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void StudentDueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void StudentDueForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string regNo = textBox2.Text;
                conn = new MySqlConnection(connstring);
                string query = "SELECT first_name, last_name, surname, class, roll_no FROM journals.students WHERE reg_no='" + regNo + "';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox3.Text = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2);
                        textBox1.Text = reader.GetString(3);
                        textBox4.Text = reader.GetString(4);
                    }
                    reader.Close();
                    query = "SELECT * FROM journals._"+regNo+" WHERE return_date='null';";
                    cmd.CommandText = query;
                    reader = cmd.ExecuteReader();
                    int count = 1;
                    DataTable dt = new DataTable();
                    dt = new DataTable();
                    dt.Columns.Add("srno");
                    dt.Columns.Add("jtitle");
                    dt.Columns.Add("volno");
                    dt.Columns.Add("issueno");
                    dt.Columns.Add("issuedate");
                    dt.Columns.Add("returndate");
                    DataRow dr = dt.NewRow();
                    while (reader.Read())
                    {
                        dr["srno"] = count;
                        dr["jtitle"] = reader.GetString(0);
                        dr["volno"] = reader.GetString(1);
                        dr["issueno"] = reader.GetString(2);
                        dr["issuedate"] = reader.GetString(3);
                        dr["returndate"] = "";
                        dt.Rows.Add(dr);
                        count++;
                    }
                    reader.Close();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Incorrect student details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            
        }
    }
}
