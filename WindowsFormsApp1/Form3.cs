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
            if (e.KeyCode == Keys.F4)
            {
                string regNo = textBox1.Text;
                conn = new MySqlConnection(connstring);
                string query = "SELECT roll_no, first_name, last_name, surname, stream, class, division FROM journals.students WHERE reg_no='" + regNo + "';";
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
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }

                try
                {
                    DataTable dt = new DataTable();
                    DataRow dr;
                    dt.Columns.Add("srno");
                    dt.Columns.Add("volno");
                    dt.Columns.Add("issueno");
                    dt.Columns.Add("journaltitle");
                    dt.Columns.Add("issuedate");
                    dt.Columns.Add("returndate");



                    conn.Open();
                    query = "SELECT volume_no, issue_no, journal_title, given_date, return_date FROM journals._" + regNo + ";";
                    cmd.CommandText = query;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int count = 1;
                    while (reader.Read())
                    {
                        dr = dt.NewRow();
                        dr["srno"] = count;
                        dr["volno"] = reader.GetString(0);
                        dr["issueno"] = reader.GetString(1);
                        dr["journaltitle"] = reader.GetString(2);
                        dr["issuedate"] = reader.GetString(3);
                        if (reader.GetString(4) != "null")
                        {
                            dr["returndate"] = reader.GetString(4);
                        }
                        else
                        {
                            dr["returndate"] = "";
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

        private void JournalIssueForm_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string regNo = textBox1.Text;
            string journalTitle = comboBox1.Text;
            string volNo = textBox8.Text;
            string issueNo = textBox9.Text;

            try
            {
                string nogiv = "0";
                string student = "";
                bool notissued = false;
                conn = new MySqlConnection(connstring);
                string query = "SELECT student_given FROM journals.journal_details WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == "null")
                        {
                            notissued = true;
                        }
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No journal found");
                }
                if (notissued)
                {

                    query = "INSERT INTO journals._" + regNo + "(journal_title, volume_no, issue_no, given_date, return_date) VALUES('" + journalTitle + "','" + volNo + "','" + issueNo + "','" + DateTime.Today.ToString("dd-MM-yyyy") + "','null');";
                    MySqlCommand cmdnew = new MySqlCommand(query, conn);
                    if (cmdnew.ExecuteNonQuery() == 1)
                    {
                        query = "SELECT no_of_issues, student_given FROM journals.journal_details WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "'";
                        cmdnew.CommandText = query;
                        reader.Close();
                        MySqlDataReader readernew = cmdnew.ExecuteReader();
                        while (readernew.Read())
                        {
                            nogiv = readernew.GetString(0);
                            nogiv = (Int32.Parse(nogiv) + 1).ToString();
                            student = readernew.GetString(1);
                        }
                        readernew.Close();
                        query = "UPDATE journals.journal_details SET student_given='" + regNo + "', no_of_issues=" + nogiv + " WHERE journal_title='" + journalTitle + "' AND volume_no='" + volNo + "' AND issue_no='" + issueNo + "';";
                        cmd.CommandText = query;
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Journal Issued");
                        }
                        else
                        {
                            MessageBox.Show("Error occured");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Incorrect student information");
                    }

                }
                else
                {
                    MessageBox.Show("Journal already issued");
                }
                




                

                conn.Close();
            }

        
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
{
    /*DataTable dt = new DataTable();
    dt.Columns.Add("srno");
    dt.Columns.Add("volno");
    dt.Columns.Add("issueno");
    dt.Columns.Add("journaltitle");
    dt.Columns.Add("issuedate");
    dt.Columns.Add("returndate");
    DataRow dr = dt.NewRow();
    dr["srno"] = 1;
    dr["volno"] = "9";
    dr["issueno"] = "8";
    dr["journaltitle"] = "Indian Journal of Computer Science";
    dr["issuedate"] = "25-12-19";
    dr["returndate"] = "27-12-19";
    dt.Rows.Add(dr);
    dataGridView1.DataSource = dt;*/

}

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}
    }
}
