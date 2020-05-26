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
    public partial class FormPrimka : Form
    {
        double kolicina;
        double suma = 0.0;
        double rbr = 0;

        public FormPrimka()
        {
            InitializeComponent();
           
            //list view izgled
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //dodavanje hedera kolona sirina kolone je u pixelima
            listView1.Columns.Add("Rbr", 50);
            listView1.Columns.Add("IDRobe", 50);
            listView1.Columns.Add("Naziv Artikla", 140);
            listView1.Columns.Add("Kolicina", 50);
            listView1.Columns.Add("Cijena", 80);
            listView1.Columns.Add("Ukupna cijena",100);
            listView1.Columns.Add("Naziv Firme", 110);
            listView1.Columns.Add("Datum", 180);

        }

        private void FormPrimka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladisteDataSet.Firme' table. You can move, or remove it, as needed.
            this.firmeTableAdapter.Fill(this.skladisteDataSet.Firme);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladisteDataSetRobaKodPrimke.Roba' table. You can move, or remove it, as needed.
            this.robaTableAdapter.Fill(this.skladisteDataSet.Roba);
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double cijena;
            double cijena_artikala;
            double reset = 0.0;

           


            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                kolicina = double.Parse(textBox5.Text);
                if (kolicina != 0)
                {
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();

                    if (double.Parse(row.Cells[2].Value.ToString()) == 0.0)
                    {
                        cijena = 0.0;
                        textBox5.Text = reset.ToString();
                    }
                    else
                    {
                        cijena = double.Parse(row.Cells[3].Value.ToString());
                        textBox3.Text = cijena.ToString();
                        suma = suma + cijena * kolicina;
                        textBox4.Text = suma.ToString();
                        dataGridView1[2, rowIndex].Value =
                        double.Parse(row.Cells[2].Value.ToString()) + kolicina;
                        rbr += 1;

                        // dodavanje podataka u ListView kontrolu
                        string[] arr = new string[9];
                        ListViewItem itm;

                        //Add first item
                        arr[0] = rbr.ToString();
                        arr[1] = row.Cells[0].Value.ToString();
                        arr[2] = row.Cells[1].Value.ToString();
                        arr[3] = kolicina.ToString();
                        arr[4] = cijena.ToString();
                        cijena_artikala = cijena * kolicina;
                        arr[5] = cijena_artikala.ToString();
                        arr[6] = comboBox1.Text;
                        arr[7] = dateTimePicker1.Value.ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                        textBox5.Text = reset.ToString();
                    }
                }
                else MessageBox.Show("prvo morate upisati količinu zaprimanja robe");
            }
            catch(Exception ex)
            {
                MessageBox.Show("prvo morate odabrati poduzece, datum i upisati količinu zaprimanja robe", ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SkladisteDataSet.PrimkaDataTable dt = new SkladisteDataSet.PrimkaDataTable();
            var newRow = dt.NewPrimkaRow();
            newRow.NazivFirme = (int)comboBox1.SelectedValue;
            newRow.Datum = dateTimePicker1.Value;
            dt.AddPrimkaRow(newRow);
            primkaTableAdapter1.Update(dt);

            primkaTableAdapter1.Fill(dt);
            var id = (int)dt.Rows[dt.Rows.Count - 1][0];
            //var idPrimka = primkaTableAdapter1.Insert((int)comboBox1.SelectedValue, DateTime.Now);

            SkladisteDataSet.RobaDataTable robaDt = new SkladisteDataSet.RobaDataTable();
            robaTableAdapter.Fill(robaDt);
            foreach (ListViewItem item in listView1.Items)
            {
                //stvori novu stavku primke
                int idRobe = Convert.ToInt32(item.SubItems[1].Text);
                int kolicina = Convert.ToInt32(item.SubItems[3].Text);
                stavkaPrimkeTableAdapter1.Insert(id, idRobe, kolicina);

                //povecaj kolicinu od robe 
                var robaDataRow = (SkladisteDataSet.RobaRow)robaDt.Select("IDrobe = " + idRobe.ToString()).FirstOrDefault();
                robaDataRow.Kolicina += kolicina;
                robaTableAdapter.Update(robaDt);
            }
            MessageBox.Show("Nova stavka i primka uspješno stvorene");
            listView1.Clear();
        }
    }
}
