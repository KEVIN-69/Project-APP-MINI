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
    public partial class FormSupplier : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Database1.accdb");
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void txtsimpan_Click(object sender, EventArgs e)
        {
            con.Open();
            String printah = "INSERT INTO supplier(nama,alamat,notelp,piutang) values ('" + txtnama.Text + "', '" + txtalamat.Text + "', '" + txtno.Text + "', '" + txtpiutang.Text + "')";
            OleDbCommand cmd = new OleDbCommand(printah, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Supplier Berhasil Ditambahkan");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //textBox3.Text = row.Cells[0].Value.ToString();
            //textBox5.Text = row.Cells[1].Value.ToString();
            //textBox4.Text = row.Cells[2].Value.ToString();
            //textBox2.Text = row.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Hide();
            FormDeleteSupplier dt = new FormDeleteSupplier();
            dt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtnama.Text = "";
            txtalamat.Text = "";
            txtno.Text = "";
            txtpiutang.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from supplier";
                OleDbCommand perintah = new OleDbCommand(query, con);
                DataSet ds = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter(perintah);
                adapter.Fill(ds, "res");
                dataGridView1.DataSource = ds.Tables["res"];
                adapter.Dispose();
                perintah.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Gagal Menampilkan Data");
            }
        }
    }
}
