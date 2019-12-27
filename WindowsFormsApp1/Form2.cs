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
    public partial class addStudentForm : Form
    {
        public addStudentForm()
        {
            InitializeComponent();
        }


        string connstring = "datasource=localhost;port=3307;user=root;password=toor";
        MySqlConnection conn;


        string reg_no;
        string fname;
        string lname;
        string surname;
        string caste;
        string dob;
        string bloodGroup;
        string gender;
        string mobNo;
        string stream;
        string _class;
        string division;
        string rollNo;
        string address;

        protected void getDataFromView()
        {
            reg_no = regNoInp.Text;
            fname = fnameInp.Text;
            lname = lnameInp.Text;
            surname = surnameInp.Text;
            caste = casteInp.Text;
            dob = dobInp.Value.ToString("yyyy-MM-dd");
            bloodGroup = bloodGroupInp.Text;
            gender = genderInp.Text;
            mobNo = mobileNoInp.Text;
            stream = streamInp.Text;
            _class = classInp.Text;
            division = divisionInp.Text;
            rollNo = rollInp.Text;
            address = addressInp.Text;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
  
            getDataFromView();


            



            

            bool notFound = true;
            try
            {
                conn = new MySqlConnection(connstring);
                string query = "SELECT * FROM journals.students;";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if(reader["reg_no"].ToString() == reg_no)
                    {
                        notFound = false;
                        break;
                    }
                }
                reader.Close();

                if (notFound)
                {
                    query = "INSERT INTO journals.students(reg_no,first_name,last_name,surname,caste,date_of_birth,blood_group,gender,mobile_no,stream,class,division,roll_no,address) VALUES('" + reg_no + "','" + fname + "','" + lname + "','" + surname + "','" + caste + "','" + dob + "','" + bloodGroup + "','" + gender + "','" + mobNo + "','" + stream + "','" + _class + "','" + division + "','" + rollNo + "','" + address + "');";
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    query = "CREATE TABLE journals._"+reg_no+"(journal_title varchar(200), vloume_no varchar(10), issue_no varchar(10), given_date varchar(10), return_date varchar(10));";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student added");

                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void regNoInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                //MessageBox.Show("Sweet");
                string reg = regNoInp.Text;

                try
                {
                    conn = new MySqlConnection(connstring);
                    conn.Open();
                    string query = "SELECT * FROM journals.students WHERE reg_no='" + reg + "';";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        fnameInp.Text = reader.GetValue(1).ToString();
                        lnameInp.Text = reader.GetValue(2).ToString();
                        surnameInp.Text = reader.GetValue(3).ToString();
                        casteInp.Text = reader.GetValue(4).ToString();
                        dobInp.Value = Convert.ToDateTime(reader.GetValue(5));
                        bloodGroupInp.Text = reader.GetValue(6).ToString();
                        genderInp.Text = reader.GetValue(7).ToString();
                        mobileNoInp.Text = reader.GetValue(8).ToString();
                        streamInp.Text = reader.GetValue(9).ToString();
                        classInp.Text = reader.GetValue(10).ToString();
                        divisionInp.Text = reader.GetValue(11).ToString();
                        rollInp.Text = reader.GetValue(12).ToString();
                        addressInp.Text = reader.GetValue(13).ToString();
                        count++;
                    }
                    if (count == 0) MessageBox.Show("No such entry");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                conn.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                surnameInp.Focus();
                //e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE journals.students SET first_name='"+fnameInp.Text+"',last_name='"+lnameInp.Text+"',surname='"+surnameInp.Text+"',caste='"+casteInp.Text+"',date_of_birth='"+dobInp.Value.Date.ToString()+"',blood_group='"+bloodGroupInp.Text+"',gender='"+genderInp.Text+"',mobile_no='"+mobileNoInp.Text+"',stream='"+streamInp.Text+"',class='"+classInp.Text+"',division='"+divisionInp.Text+"',roll_no='"+rollInp.Text+"',full_address='"+addressInp.Text+"' WHERE reg_no='"+regNoInp.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            //cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student entry updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string reg = regNoInp.Text;
            conn.Open();
            string query = "DELETE FROM journals.students WHERE reg_no='" + reg + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            
            try
            {
                //if (cmd.ExecuteNonQuery() != 0) MessageBox.Show("Entry deleted");
                //else MessageBox.Show("Error occured. Entry not deleted");

                int result = cmd.ExecuteNonQuery();
                if(result != 0)
                {
                    MessageBox.Show("Entry deleted");
                    query = "DROP TABLE journals._"+reg+";";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Error occured. Entry not deleted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void surnameInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fnameInp.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void fnameInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lnameInp.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void lnameInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                casteInp.Focus();
                casteInp.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void addStudentForm_Load(object sender, EventArgs e)
        {
            //regNoInp.Focus();
            //MessageBox.Show("Form loded");
        }

        private void addStudentForm_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Form activated");
            regNoInp.Focus();
        }

        private void casteInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dobInp.Focus();
                //casteInp.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dobInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bloodGroupInp.Focus();
                bloodGroupInp.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void bloodGroupInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                genderInp.Focus();
                genderInp.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void genderInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mobileNoInp.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void mobileNoInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                streamInp.Focus();
                streamInp.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void streamInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                classInp.Focus();
                classInp.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void classInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                divisionInp.Focus();
                divisionInp.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void divisionInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rollInp.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void rollInp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addressInp.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
