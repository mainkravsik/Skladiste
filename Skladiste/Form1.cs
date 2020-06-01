﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using PathFinding;

namespace Skladiste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static String name_w = " ";
        


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladisteDataSet.Warehouse". При необходимости она может быть перемещена или удалена.
            this.warehouseTableAdapter.Fill(this.skladisteDataSet.Warehouse);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skladisteDataSet.Firme". При необходимости она может быть перемещена или удалена.
            this.firmeTableAdapter.Fill(this.skladisteDataSet.Firme);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //omogućenje pristup podacima iz baze
            
            //richTextBox1.Text = row.Cells[4].Value.ToString();
            //textBox5.Text = row.Cells[5].Value.ToString();   
        }

        //metoda button kontrola za UPDATE BAZE
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //robaTableAdapter.Update(skladisteDataSet);
                firmeTableAdapter.Update(skladisteDataSet);
                MessageBox.Show("Database updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        

        

        private void button5_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skladisteDataSetRoba.Roba' table. You can move, or remove it, as needed.
            //this.robaTableAdapter.Fill(this.skladisteDataSet.Roba);
            this.firmeTableAdapter.Fill(this.skladisteDataSet.Firme);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_path_edit forma_path_edit = new Form_path_edit();
            forma_path_edit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_path forma_path = new Form_path();
            
            forma_path.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            name_w = row.Cells[3].Value.ToString();

        }
    }
}
