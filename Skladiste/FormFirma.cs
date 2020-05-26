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
    public partial class FormFirma : Form
    {
        //reference na objekte ds i dataAdapter moraju biti definirane globalno

        public FormFirma()
        {
            InitializeComponent();

        }

        private void FormFirma_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladisteDataSetFirme.Firme' table. You can move, or remove it, as needed.
            this.firmeTableAdapter.Fill(this.skladisteDataSetFirme.Firme);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                firmeTableAdapter.Update(skladisteDataSetFirme);
                MessageBox.Show("Database updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
