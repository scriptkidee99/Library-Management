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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class studentSearchForm : Form
    {

        //SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\ashvi\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Database.mdf;Integrated Security = True");
        string connstring = "datasource=localhost;port=3307;user=root;password=toor";
        MySqlConnection conn;
        public studentSearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Reg No");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Caste");
            dt.Columns.Add("Date of Birth");
            dt.Columns.Add("Blood Group");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Mobile No");
            dt.Columns.Add("Stream");
            dt.Columns.Add("_class");
            dt.Columns.Add("Roll No");
            string field = comboBox1.Text;
            string gotquery = textBox1.Text.ToLower();
            try
            {
                conn = new MySqlConnection(connstring);
                string query = "SELECT * FROM journals.students;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (gotquery == "")
                {
                    while (reader.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["Reg No"] = reader.GetString(0);
                        dr["First Name"] = reader.GetString(1);
                        dr["Last Name"] = reader.GetString(2);
                        dr["Surname"] = reader.GetString(3);
                        dr["Caste"] = reader.GetString(4);
                        dr["Date of Birth"] = reader.GetString(5);
                        dr["Blood Group"] = reader.GetString(6);
                        dr["Gender"] = reader.GetString(7);
                        dr["Mobile No"] = reader.GetString(8);
                        dr["Stream"] = reader.GetString(9);
                        dr["_class"] = reader.GetString(10);
                        dr["Roll No"] = reader.GetString(11);
                        dt.Rows.Add(dr);
                    }
                    reader.Close();
                }
                else if (field == "First Name")
                {
                    
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(1).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }
                else if (field == "Last Name")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(2).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }
                else if (field == "Surname")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(3).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }

                else if (field == "Caste")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(4).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }

                else if(field=="Date of Birth")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(5).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }

                else if(field=="Blood Group")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(6).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }
                else if (field == "Gender")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(7).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }

                else if(field=="Mobile No")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(8).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }
                else if (field == "Stream")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(9).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }
                else if (field == "Class")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(10).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }
                else if(field=="Roll No")
                {
                    while (reader.Read())
                    {
                        string checkString = reader.GetString(11).ToLower();
                        if (checkString.Contains(gotquery))
                        {
                            DataRow dr = dt.NewRow();
                            dr["Reg No"] = reader.GetString(0);
                            dr["First Name"] = reader.GetString(1);
                            dr["Last Name"] = reader.GetString(2);
                            dr["Surname"] = reader.GetString(3);
                            dr["Caste"] = reader.GetString(4);
                            dr["Date of Birth"] = reader.GetString(5);
                            dr["Blood Group"] = reader.GetString(6);
                            dr["Gender"] = reader.GetString(7);
                            dr["Mobile No"] = reader.GetString(8);
                            dr["Stream"] = reader.GetString(9);
                            dr["_class"] = reader.GetString(10);
                            dr["Roll No"] = reader.GetString(11);
                            dt.Rows.Add(dr);
                        }
                    }
                    reader.Close();
                }


                conn.Close();
                dgv1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn.State != ConnectionState.Closed) conn.Close();
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentSearchForm_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "First Name";
        }
    }
}
