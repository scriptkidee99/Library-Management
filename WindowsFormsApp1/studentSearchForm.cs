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
            string text = comboBox1.Text;
            try
            {
                conn = new MySqlConnection(connstring);
                MySqlDataAdapter adapter;
                conn.Open();
                if (text == "")
                {
                     adapter = new MySqlDataAdapter("SELECT * FROM journals.students", conn);
                }
                else
                {
                     adapter = new MySqlDataAdapter("SELECT * FROM journals.students WHERE first_name='"+text+"'", conn);
                }
                DataTable dtb1 = new DataTable();
                adapter.Fill(dtb1);
                dgv1.DataSource = dtb1;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
