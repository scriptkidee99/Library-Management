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
            try
            {
                int issuecount = 0, returncount = 0;
                string allStudents = "";
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
                query = "SELECT reg_no,first_name, last_name, surname, class FROM journals.students;";
                MySqlCommand cmd1 = new MySqlCommand(query, conn);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    allStudents += (reader1.GetString(0) + "~");
                }
                reader1.Close();
                string[] studentList = allStudents.Split('~');
                /*for (int i=0;i<studentList.Count()-1;i++)
                {
                    MessageBox.Show("Student is"+studentList[i]);
                }*/
                for (int i = 0; i < studentList.Count() - 1; i++)
                {
                    //MessageBox.Show(studentList[i]);
                    query = "SELECT * FROM journals._" + studentList[i] + " WHERE given_date='" + DateTime.Today.ToString("dd-MM-yyyy") + "';";
                    //MessageBox.Show(query);
                    MySqlCommand cmd2 = new MySqlCommand(query, conn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        issuecount++;
                    }
                    reader2.Close();
                    query = "SELECT * FROM journals._" + studentList[i] + " WHERE return_date='" + DateTime.Today.ToString("dd-MM-yyyy") + "';";
                    MySqlCommand cmd3 = new MySqlCommand(query, conn);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();
                    while (reader3.Read()) returncount++;
                    reader3.Close();
                }
                label11.Text = "Journals Issued : " + issuecount.ToString();
                label12.Text = "Journals Returned : " + returncount.ToString();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                if (conn.State != ConnectionState.Closed) conn.Close();
            }
            
            
        }

        public string searchAndFillData(bool fill)
        {
            journalTitle = comboBox1.Text;
            volNo = textBox8.Text;
            issueNo = textBox9.Text;
            student = "";
            string retstudent = "";
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
                            retstudent = reader["reg_no"].ToString();
                            if (fill)
                            {
                                textBox1.Text = reader["reg_no"].ToString();
                                textBox2.Text = reader["roll_no"].ToString();
                                textBox3.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString() + " " + reader["surname"].ToString();
                                textBox4.Text = reader["stream"].ToString();
                                textBox5.Text = reader["class"].ToString();
                            }
                            
                            
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
            catch
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                if(conn.State != ConnectionState.Closed)
                conn.Close();
            }

            return retstudent;
            
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                searchAndFillData(true);
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                searchAndFillData(true);
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                searchAndFillData(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                conn = new MySqlConnection(connstring);
                string query = "UPDATE journals._" + searchAndFillData(false) + " SET return_date='" + DateTime.Today.ToString("dd-MM-yyyy") + "' WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "' AND return_date='null';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    query = "UPDATE journals.journal_details SET student_given='null' WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "';";
                    cmd.CommandText = query;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Journal Returned");
                        //searchAndFillData(true);
                        label12.Text = label12.Text.ToString().Split(':')[0] + (Int32.Parse(label12.Text.ToString().Split(':')[1]) + 1).ToString();
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
            catch
            {
                MessageBox.Show("Error occured");
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
                //conn.Open();
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("Sr No");
                dt.Columns.Add("Volume No");
                dt.Columns.Add("Issue No");
                dt.Columns.Add("Journal Title");
                dt.Columns.Add("Issue Date");
                dt.Columns.Add("Return Date");



                conn.Open();
                string query = "SELECT volume_no, issue_no, journal_title, given_date, return_date FROM journals._" + textBox1.Text + ";";
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
            catch 
            {

                MessageBox.Show("Error occured");
                MessageBox.Show("Error occured");
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
