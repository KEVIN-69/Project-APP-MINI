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
    public partial class FormUpdate : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Database1.accdb");
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String printah = "UPDATE menu SET kode= '" + txtkode.Text + "'WHERE namabarang ='" + txtnama.Text + "'";
            OleDbCommand cmd = new OleDbCommand(printah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Barang telah di Perbarui");
        }
    
        


        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Hide();
            FormCRUD back = new FormCRUD();
            back.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            
        }
    }
}
