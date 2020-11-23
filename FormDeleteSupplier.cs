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
    public partial class FormDeleteSupplier : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Database1.accdb");
        public FormDeleteSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String printah = "DELETE FROM supplier WHERE nama='" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(printah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Dihapus");

            //back to FromCRUD
            con.Dispose();
            this.Hide();
            FormSupplier book = new FormSupplier();
            book.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.Show();
            this.Hide();
        }
    }
}
