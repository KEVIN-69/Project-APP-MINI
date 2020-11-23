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
    public partial class FormCRUD : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Documents\Database1.accdb");
        
        public FormCRUD()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox3.Text = row.Cells[1].Value.ToString();
        }

        private void FormCRUD_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Hide();
            FormDelete dt = new FormDelete();
            dt.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vsql = string.Format("insert into menu values('{0}','{1}')", textBox2.Text, textBox3.Text);
            OleDbCommand vcom = new OleDbCommand(vsql, con);
            vcom.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Ditambahkan");
            vcom.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            this.Hide();
            FormUpdate update = new FormUpdate();
            update.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from menu";
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

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
