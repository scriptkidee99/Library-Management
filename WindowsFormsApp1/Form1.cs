﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string password;
            do
            {
                password = Prompt.ShowDialog("Login", "Enter password","OK");
                if (password != "mgm@2020")
                {
                    MessageBox.Show("Incorrect password!!");
                }
            } while (password != "mgm@2020");
            

        }

        addStudentForm addNew;
        studentSearchForm searchForm;
        StudentDueForm dueForm;
        JournalIssueForm issueform;
        JournalReturnForm returnForm;
        AddJournals addJournalsForm;
        reportsForm reportsFormGetInfo;
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //addStudentForm addNew = new addStudentForm();
            //addNew.Show();

            if(addNew == null)
            {
                addNew = new addStudentForm();
                addNew.Show();
            }
            else
            {
                addNew.Close();
                addNew = new addStudentForm();
                addNew.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void studentSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchForm == null)
            {
                searchForm = new studentSearchForm();
                searchForm.Show();
            }
            else
            {
                searchForm.Close();
                searchForm = new studentSearchForm();
                searchForm.Show();
            }
        }

        private void studentDueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dueForm == null)
            {
                dueForm = new StudentDueForm();
                dueForm.Show();
                
            }
            else
            {
                dueForm.Close();
                dueForm = new StudentDueForm();
                dueForm.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void readingJournalIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (issueform == null)
            {
                issueform = new JournalIssueForm();
                issueform.Show();
            }
            else
            {
                issueform.Close();
                issueform = new JournalIssueForm();
                issueform.Show();
            }
        }

        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void readingJournalReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (returnForm == null)
            {
                returnForm = new JournalReturnForm();
                returnForm.Show();
            }
            else
            {
                returnForm.Close();
                returnForm = new JournalReturnForm();
                returnForm.Show();
            }
        }

        private void addJournalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addJournalsForm == null)
            {
                addJournalsForm = new AddJournals();
                addJournalsForm.Show();
            }
            else
            {
                addJournalsForm.Close();
                addJournalsForm = new AddJournals();
                addJournalsForm.Show();
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportsFormGetInfo == null)
            {
                reportsFormGetInfo = new reportsForm();
                reportsFormGetInfo.Show();
            }
            else
            {
                reportsFormGetInfo.Close();
                reportsFormGetInfo = new reportsForm();
                reportsFormGetInfo.Show();
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi Mihir");
        }
    }



    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string btText)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = text,
                StartPosition = FormStartPosition.CenterScreen,
                ControlBox = false
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = caption };
            TextBox textBox = new TextBox() { Left = 30, Top = 50, Width = 100 };
            Button cancel = new Button();
            Button confirmation = new Button() { Text = btText, Left = 30, Width = 100, Top = 100, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            //return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            DialogResult dr = prompt.ShowDialog();
            if (dr == DialogResult.OK) return textBox.Text;
            else if (dr == DialogResult.Cancel) return "##null##";
            else return "";
            

        }
    }
}
