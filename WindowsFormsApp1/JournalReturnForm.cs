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
        }
    }
}
