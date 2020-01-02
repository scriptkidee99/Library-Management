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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class reportsForm : Form
    {

        string connstring = "datasource=localhost;port=3307;user=root;password=toor";
        MySqlConnection conn;

        DataTable dt;



        public reportsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;

            dt = new DataTable();
            dt.Columns.Add("srno");
            dt.Columns.Add("jtitle");
            dt.Columns.Add("volno");
            dt.Columns.Add("issueno");
            dt.Columns.Add("stdname");
            dt.Columns.Add("_class");
            dt.Columns.Add("issuedate");
            dt.Columns.Add("returndate");
            int choice = 0;
            if (radioButton1.Checked) choice = 3; else if (radioButton2.Checked) choice = 4;
            string fromDate = fromDatePicker.Value.ToString("dd-MM-yyyy");
            string toDate = toDatePicker.Value.ToString("dd-MM-yyyy");
            int count = 1;
            string allStudents = "";
            string allNames = "";
            string allClasses = "";
            try
            {
                conn = new MySqlConnection(connstring);
                conn.Open();
                string query = "SELECT reg_no,first_name, last_name, surname, class FROM journals.students;";
                MySqlCommand cmd1 = new MySqlCommand(query, conn);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    allStudents += (reader1.GetString(0) + "~");
                    allNames += (reader1.GetString(1)+" "+reader1.GetString(2)+" "+reader1.GetString(3) +"~");
                    allClasses += (reader1.GetString(4)+"~");
                }
                reader1.Close();
                string[] studentList = allStudents.Split('~');
                string[] studentNameList = allNames.Split('~');
                string[] studentClassList = allClasses.Split('~');
                /*for (int i=0;i<studentList.Count()-1;i++)
                {
                    MessageBox.Show("Student is"+studentList[i]);
                }*/
                for (i=0;i<studentList.Count()-1;i++)
                {
                    //MessageBox.Show(studentList[i]);
                    query = "SELECT * FROM journals._"+studentList[i]+";";
                    //MessageBox.Show(query);
                    MySqlCommand cmd2 = new MySqlCommand(query, conn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        if (tellDate(fromDate, reader2.GetString(choice), toDate)){
                            DataRow dr = dt.NewRow();
                            dr["srno"] = count;
                            dr["jtitle"] = reader2.GetString(0);
                            dr["volno"] = reader2.GetString(1);
                            dr["issueno"] = reader2.GetString(2);
                            dr["stdname"] = studentNameList[i];
                            dr["_class"] = studentClassList[i];
                            dr["issuedate"] = reader2.GetString(3);
                            dr["returndate"] = reader2.GetString(4);
                            dt.Rows.Add(dr);
                            count++;
                        }
                    }
                    reader2.Close();
                }
                //reader1.Close();
                conn.Close();
                dataGridView1.DataSource = dt;
                panel2.Hide();
                panel3.Hide();
                dataGridView1.Show();
                /*foreach(DataRow ddd in dt.Select())
                {
                    MessageBox.Show(ddd["stdname"].ToString());
                }*/
                foreach(DataRow ddd in dt.Select())
                {
                    //MessageBox.Show(ddd["srno"].ToString());
                }

                button3.Show();
                button4.Show();
                

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void reportsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            button3.Hide();
            button4.Hide();
            
        }


        private bool tellDate(string startDate, string gotDate, string endDate)
        {
            if (DateTime.Parse(gotDate) >= DateTime.Parse(startDate) && DateTime.Parse(gotDate) <= DateTime.Parse(endDate))
            {
                return true;
            }
            else return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 2, j = 1;
            string filename = "";
            SaveFileDialog sv1 = new SaveFileDialog();
            sv1.DefaultExt = "xls";
            if(sv1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(sv1.FileName);
                filename = sv1.FileName;
                Workbook workbook = new Workbook();
                Worksheet worksheet = new Worksheet("abcdname");
                worksheet.Cells[1, 1] = new Cell("Sr No");
                worksheet.Cells[1, 2] = new Cell("Journal Title");
                worksheet.Cells[1, 3] = new Cell("Volume No");
                worksheet.Cells[1, 4] = new Cell("Issue No");
                worksheet.Cells[1, 5] = new Cell("Student Name");
                worksheet.Cells[1, 6] = new Cell("Class");
                worksheet.Cells[1, 7] = new Cell("Issue Date");
                worksheet.Cells[1, 8] = new Cell("Return Date");


                foreach(DataRow dr in dt.Select())
                {
                    worksheet.Cells[i, j] = new Cell(dr["srno"]);
                    j++;
                    worksheet.Cells[i, j] = new Cell(dr["jtitle"]);
                    j++;
                    worksheet.Cells[i, j] = new Cell(dr["volno"]);
                    j++;
                    worksheet.Cells[i, j] = new Cell(dr["issueno"]);
                    j++;
                    worksheet.Cells[i, j] = new Cell(dr["stdname"]);
                    j++;
                    worksheet.Cells[i, j] = new Cell(dr["_class"]);
                    j++;
                    worksheet.Cells[i, j] = new Cell(dr["issuedate"]);
                    j++;
                    worksheet.Cells[i, j] = new Cell(dr["returndate"]);
                    i++;
                    j = 1;
                }

                worksheet.Cells.ColumnWidth[2,2] = 10000;
                worksheet.Cells.ColumnWidth[5, 5] = 6000;
                workbook.Worksheets.Add(worksheet);
                workbook.Save(filename);
            }

        }
    }
}
