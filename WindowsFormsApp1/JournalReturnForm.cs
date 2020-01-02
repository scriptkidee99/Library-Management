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
    public partial class JournalReturnForm : Form
    {

        string connstring = "datasource=localhost;port=3307;user=root;password=toor";
        MySqlConnection conn;


        string journalTitle;
        string volNo;
        string issueNo;
        string student;

        public JournalReturnForm()
        {
            InitializeComponent();
        }

        private void JournalReturnForm_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connstring);
            string query = "SELECT journal_title FROM journals.journal_details;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
        }

        public void searchAndFillData()
        {
            journalTitle = comboBox1.Text;
            volNo = textBox8.Text;
            issueNo = textBox9.Text;
            student = "";
            try
            {
                conn = new MySqlConnection(connstring);
                string query = "SELECT student_given FROM journals.journal_details WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student = reader["student_given"].ToString();
                    }
                    query = "SELECT * FROM journals.students WHERE reg_no='" + student + "';";
                    cmd.CommandText = query;
                    reader.Close();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {


                        while (reader.Read())
                        {
                            textBox1.Text = reader["reg_no"].ToString();
                            textBox2.Text = reader["roll_no"].ToString();
                            textBox3.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString() + " " + reader["surname"].ToString();
                            textBox4.Text = reader["stream"].ToString();
                            textBox5.Text = reader["class"].ToString();
                            textBox6.Text = reader["division"].ToString();
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("No journal Found");
                    }
                }
                       
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(conn.State != ConnectionState.Closed)
                conn.Close();
            }


            
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                searchAndFillData();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                searchAndFillData();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                searchAndFillData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new MySqlConnection(connstring);
                string query = "UPDATE journals._" + student + " SET return_date='" + DateTime.Today.ToString("dd-MM-yyyy") + "' WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "' AND return_date='null';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    query = "UPDATE journals.journal_details SET student_given='null' WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "';";
                    cmd.CommandText = query;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Journal Returned");
                    }
                    else
                    {
                        MessageBox.Show("Error Occured");
                    }
                }
                else
                {
                    MessageBox.Show("Error occured");
                }
            }
            catch(Exception ex)
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



            try
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("Sr No");
                dt.Columns.Add("Volume No");
                dt.Columns.Add("Issue No");
                dt.Columns.Add("Journal Title");
                dt.Columns.Add("Issue Date");
                dt.Columns.Add("Return Date");



                conn.Open();
                string query = "SELECT volume_no, issue_no, journal_title, given_date, return_date FROM journals._" + student + ";";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                int count = 1;
                while (reader.Read())
                {
                    dr = dt.NewRow();
                    dr["Sr No"] = count;
                    dr["Volume No"] = reader.GetString(0);
                    dr["Issue No"] = reader.GetString(1);
                    dr["Journal Title"] = reader.GetString(2);
                    dr["Issue Date"] = reader.GetString(3);
                    if (reader.GetString(4) != "null")
                    {
                        dr["Return Date"] = reader.GetString(4);
                    }
                    else
                    {
                        dr["Return Date"] = "";
                    }
                    dt.Rows.Add(dr);
                    count++;
                }
                dataGridView1.DataSource = dt;
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occured");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}
