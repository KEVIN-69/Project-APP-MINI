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
    
    public partial class FormDelete : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Database1.accdb");
        public FormDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String printah = "DELETE FROM menu WHERE NAMABARANG='" + txtbarang.Text + "'";
            OleDbCommand cmd = new OleDbCommand(printah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Dihapus");

            //back to FromCRUD
            con.Dispose();
            this.Hide();
            FormCRUD book = new FormCRUD();
            book.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Hide();
            FormCRUD back = new FormCRUD();
            back.ShowDialog();
        }
    }
}
