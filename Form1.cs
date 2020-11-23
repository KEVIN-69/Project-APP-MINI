using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*') ;
            {
                button3.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                button2.BringToFront();
                txtpassword.PasswordChar = '*';
            }
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtpassword.Clear();
            txtuser.Text = "";
            txtuser.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buat koneksi dengan database
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Database1.accdb");

            // buat database adapter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from login where username='" + txtuser.Text + "'and password='" + txtpassword.Text + "'", con);

            // buat data tabel
            DataTable dt = new DataTable();

            //fill data tabel
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                // means the username and password is correct
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();

            }
            else
            {
                //means the username or password is incorrect
                MessageBox.Show("username tidak ditemukan, Coba lagi");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
