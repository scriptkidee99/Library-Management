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
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class AddJournals : Form
    {

        string connstring = "datasource=localhost;port=3307;user=root;password=toor";
        MySqlConnection conn;


        public AddJournals()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string journalName = textBox1.Text;
            string volNo = textBox2.Text;
            string issueNo = textBox6.Text;
            string monthYear = comboBox1.Text + "-" + comboBox2.Text + " " + dateTimePicker3.Value.ToString("yyyy");
            string period = comboBox3.Text;
            string rackNo = textBox4.Text;
            string shelfNo = textBox8.Text;
            string accDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string receivedDate = dateTimePicker2.Value.ToString("dd-MM-yyyy");

            try
            {

                conn = new MySqlConnection(connstring);
                string query = "INSERT INTO journals.journal_details(journal_title, volume_no, issue_no, month_year, period, rack_no, shelf_no, acc_date, received_date, no_of_issues, student_given) VALUES('" + journalName + "','" + volNo + "','" + issueNo + "','" + monthYear + "','"+period+"','" + rackNo + "','" + shelfNo + "','" + accDate + "','" + receivedDate + "',0,'null');";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Journal Added");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error occured");
            }



        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                try
                {
                    string volNo = textBox2.Text;
                    conn = new MySqlConnection(connstring);
                    conn.Open();
                    string query = "SELECT * FROM journals.journal_details WHERE volume_no='" + volNo + "';";


                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {

                        textBox1.Text = reader.GetValue(0).ToString();
                        textBox2.Text = reader.GetValue(1).ToString();
                        textBox6.Text = reader.GetValue(2).ToString();
                        textBox4.Text = reader.GetValue(5).ToString();
                        textBox8.Text = reader.GetValue(6).ToString();
                        count++;
                    }
                    conn.Close();
                    if (count == 0) MessageBox.Show("No such entry");
                }
                catch
                {
                    MessageBox.Show("Error occured");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string volNo = textBox2.Text;
            string journalTitle = textBox1.Text;
            string issueNo = textBox6.Text;
            string rackNo = textBox4.Text;
            string shelfNo = textBox8.Text;
            Console.WriteLine(journalTitle);
            Console.WriteLine(issueNo);
            Console.WriteLine(rackNo);
            Console.WriteLine(shelfNo);
            try
            {
                conn = new MySqlConnection(connstring);
                string query = "UPDATE journals.journal_details SET journal_title='" + journalTitle + "',issue_no='" + issueNo + "',rack_no='" + rackNo + "',shelf_no='" + shelfNo + "' WHERE volume_no='" + volNo + "';";
                //query = "UPDATE journals.journal_details SET journal_title='abcd' WHERE volume_no='vol1';";
                Console.WriteLine(query);
                //MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Journal details updated");
            }
            catch
            {
                MessageBox.Show("Error occured");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string volNo = textBox2.Text;
            try
            {
                conn = new MySqlConnection(connstring);
                conn.Open();
                string query = "DELETE FROM journals.journal_details WHERE volume_no='" + volNo + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result != 0)
                {
                    MessageBox.Show("Journal deleted");
                }
                else
                {
                    MessageBox.Show("Error occured. Journal not deleted");
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error occured");
            }


        }

        private void AddJournals_Load(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy";
            dateTimePicker3.ShowUpDown = true;

            try
            {
                conn = new MySqlConnection(connstring);
                string query = "SELECT * FROM journals.period";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) comboBox3.Items.Add(reader.GetString(0));
            }
            catch
            {
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

        private void newCasteInp_Click(object sender, EventArgs e)
        {
            string newPeriod = Prompt.ShowDialog("Period", "Enter period", "Add Periocmd.exd");
            if (!String.IsNullOrWhiteSpace(newPeriod))
            {
                try
                {
                    conn = new MySqlConnection(connstring);
                    string query = "INSERT INTO journals.period(period) VALUES('" + newPeriod + "');";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("New period added");
                        comboBox3.Items.Add(newPeriod);
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
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                string filename = "";
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    filename = ofd.FileName;
                    //MessageBox.Show(filename);
                    _Application excel = new _Excel.Application();
                    Workbook wb = excel.Workbooks.Open(filename);
                    Worksheet ws = wb.Worksheets[1];
                    int i = 3;
                    bool allEntered = true;

                    while (true)
                    {
                        if (ws.Cells[i, 2].Value2 != null && ws.Cells[i, 3].Value2 != null && ws.Cells[i, 4].Value2 != null)
                        {
                            string jtitle = (ws.Cells[i, 2].Value2 != null) ? ws.Cells[i, 2].Value2.ToString() : "";
                            string vno = (ws.Cells[i, 3].Value2 != null) ? ws.Cells[i, 3].Value2.ToString() : "";
                            string issueno = (ws.Cells[i, 4].Value2 != null) ? ws.Cells[i, 4].Value2.ToString() : "";
                            string monthstart = (ws.Cells[i, 5].Value2 != null) ? ws.Cells[i, 5].Value2.ToString() : "";
                            string monthend = (ws.Cells[i, 6].Value2 != null) ? ws.Cells[i, 6].Value2.ToString() : "";
                            string year = (ws.Cells[i, 7].Value2 != null) ? ws.Cells[i, 7].Value2.ToString() : "";
                            string period = (ws.Cells[i, 8].Value2 != null) ? ws.Cells[i, 8].Value2.ToString() : "";
                            string rackno = (ws.Cells[i, 9].Value2 != null) ? ws.Cells[i, 9].Value2.ToString() : "";
                            string shelfno = (ws.Cells[i, 10].Value2 != null) ? ws.Cells[i, 10].Value2.ToString() : "";
                            string accDate = (ws.Cells[i, 11].Value2 != null) ? ws.Cells[i, 11].Value2.ToString() : "";
                            string receivedDate = (ws.Cells[i, 12].Value2 != null) ? ws.Cells[i, 12].Value2.ToString() : "";
                            string monthYear = getStringMonth(monthstart) + "-" + getStringMonth(monthend) + " " + year;

                            MessageBox.Show(jtitle);


                            conn = new MySqlConnection(connstring);
                            string query = "SELECT journal_title, volume_no, issue_no FROM journals.journal_details;";
                            conn.Open();
                            bool notEntered = true;
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            MySqlDataReader reader1 = cmd.ExecuteReader();
                            while (reader1.Read())
                            {
                                if (reader1.GetString(0) == jtitle && reader1.GetString(2) == vno && reader1.GetString(2) == issueno)
                                {
                                    notEntered = false;
                                    break;
                                }
                            }
                            reader1.Close();
                            if (notEntered)
                            {
                                query = "INSERT INTO journals.journal_details(journal_title, volume_no, issue_no, month_year, period, rack_no, shelf_no, acc_date, received_date, no_of_issues, student_given) VALUES('" + jtitle + "','" + vno + "','" + issueno + "','" + monthYear + "','"+period+"','" + rackno + "','" + shelfno + "','" + accDate + "','" + receivedDate + "',0,'null');";
                                
                                MySqlCommand cmd2 = new MySqlCommand(query, conn);
                                cmd2.ExecuteNonQuery();

                                //MessageBox.Show("Journal Added");
                            }
                            else
                            {
                                allEntered = false;
                                //MessageBox.Show("Journal already present");
                            }


                            conn.Close();
                        }
                        else
                        {
                            break;
                        }

                        i++;
                    }
                    if (allEntered)
                    {
                        MessageBox.Show("All entries added successfuly");
                    }
                    else
                    {
                        MessageBox.Show("Error occured. All entries not registered.Try Checking Manually");
                    }






                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured");
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


        private string getStringMonth(string month)
        {
            switch (Int32.Parse(month))
            {
                case 1:
                    return "January";
                    

                case 2:
                    return "February";

                case 3:
                    return "March";
                    

                case 4:
                    return "April";

                case 5:
                    return "May";
                    

                case 6:
                    return "June";

                case 7:
                    return "July";
                    

                case 8:
                    return "August";

                case 9:
                    return "September";
                    

                case 10:
                    return "October";

                case 11:
                    return "November";
                    

                case 12:
                    return "December";

                default:
                    return "";
            }
        }
    }

    
}
