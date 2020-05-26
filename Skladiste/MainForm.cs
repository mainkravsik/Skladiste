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

namespace Skladiste
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //omogućenje pristup podacima iz baze
            int rowIndex = e.RowIndex;
           
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            richTextBox1.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();   
        }

        //metoda button kontrola za UPDATE BAZE
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                robaTableAdapter.Update(skladisteDataSet);
                MessageBox.Show("Database updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFirma formaFirma = new FormFirma();
            formaFirma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIzdatnica formaIzdatnica = new FormIzdatnica();
            formaIzdatnica.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPrimka formaPrimka = new FormPrimka();
            formaPrimka.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladisteDataSetRoba.Roba' table. You can move, or remove it, as needed.
            this.robaTableAdapter.Fill(this.skladisteDataSet.Roba);
        }
    }
}
