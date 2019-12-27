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
        public JournalReturnForm()
        {
            InitializeComponent();
        }

        private void JournalReturnForm_Load(object sender, EventArgs e)
        {

        }

        public void searchAndFillData()
        {
            string journalTitle = textBox7.Text;
            string volNo = textBox8.Text;
            string issueNo = textBox9.Text;
            string student = "";
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
                    query = "SELECT * FROM journals.students WHERE reg_no='"+student+"';";
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
                        query = "UPDATE journals.journal_details SET student_given='null';";
                        cmd.CommandText = query;
                        if(cmd.ExecuteNonQuery() == 1)
                        {
                            
                            query = "UPDATE _" + student + " SET return_date='" + DateTime.Today.ToString("dd-MM-yyyy") + "' WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "' AND return_date='null';";
                            cmd.CommandText = query;
                            if(cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Journal returned");
                            }
                            else
                            {
                                MessageBox.Show("Error occured");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error occured");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Journal not issued");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Journal not found");
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
    }
}
