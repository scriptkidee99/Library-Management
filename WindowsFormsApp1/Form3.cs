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
    
    public partial class JournalIssueForm : Form
    {
        string connstring = "datasource=localhost;port=3307;user=root;password=toor";
        MySqlConnection conn;

        public JournalIssueForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F4)
            {
                string regNo = textBox1.Text;
                conn = new MySqlConnection(connstring);
                string query = "SELECT roll_no, first_name, last_name, surname, stream, class, division FROM journals.students WHERE reg_no='"+regNo+"';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                            string name = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                            textBox2.Text = reader.GetString(0);
                            textBox3.Text = name;
                            textBox4.Text = reader.GetString(4);
                            textBox5.Text = reader.GetString(5);
                            textBox6.Text = reader.GetString(6);
                        }
                    }
                    else
                    {

                        MessageBox.Show("No such student");
                    }
                    reader.Close();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }
                


            }
        }

        private void JournalIssueForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string regNo = textBox1.Text;
            string journalTitle = textBox7.Text;
            string volNo = textBox8.Text;
            string issueNo = textBox9.Text;
            
            try
            {
                string nogiv = "0";
                conn = new MySqlConnection(connstring);
                string query = "INSERT INTO journals._"+regNo+"(journal_title, volume_no, issue_no, given_date) VALUES('"+journalTitle+"','"+volNo+"','"+issueNo+"','"+DateTime.Today.ToString("dd-MM-yyyy")+"');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MessageBox.Show("ExecuteNonQuery returns "+cmd.ExecuteNonQuery().ToString());
                query = "SELECT no_of_issues FROM journals.journal_details WHERE journal_title='"+journalTitle+"' AND volume_no='"+volNo+"' AND issue_no='"+issueNo+"'";
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nogiv = reader.GetString(0);
                    MessageBox.Show("Earlier " + nogiv);
                    nogiv = (Int32.Parse(nogiv)+1).ToString();
                    MessageBox.Show("Later" + nogiv);
                    
                }
                reader.Close();
                query = "UPDATE journals.journal_details SET student_given='" + regNo + "', no_of_issues=" + nogiv + " WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "';";
                cmd = new MySqlCommand(query, conn);
                MessageBox.Show("journal updated is " + cmd.ExecuteNonQuery().ToString());

                conn.Close();
                MessageBox.Show("Journal Issued");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
    }
}
