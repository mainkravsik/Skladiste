namespace Skladiste
{
    partial class FormIzdatnica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.firmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladisteDataSet = new Skladiste.SkladisteDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDrobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivartiklaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.robaTableAdapter = new Skladiste.SkladisteDataSetTableAdapters.RobaTableAdapter();
            this.firmeTableAdapter = new Skladiste.SkladisteDataSetTableAdapters.FirmeTableAdapter();
            this.stavkaIzdatniceTableAdapter1 = new Skladiste.SkladisteDataSetTableAdapters.StavkaIzdatniceTableAdapter();
            this.izdatnicaTableAdapter1 = new Skladiste.SkladisteDataSetTableAdapters.IzdatnicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(911, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "kn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(911, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "kn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Odabrani artikli";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Odaberi artikl koji zelits izdati";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Odaberi datum izdavanja izdatnice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Odaberi poduzeće izdavanja izdatnice";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(384, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(809, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 55);
            this.button2.TabIndex = 46;
            this.button2.Text = "Stvori novu izdatnicu/stavku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.firmeBindingSource;
            this.comboBox1.DisplayMember = "NazivFirme";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(384, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.ValueMember = "IDFirme";
            // 
            // firmeBindingSource
            // 
            this.firmeBindingSource.DataMember = "Firme";
            this.firmeBindingSource.DataSource = this.skladisteDataSet;
            // 
            // skladisteDataSet
            // 
            this.skladisteDataSet.DataSetName = "SkladisteDataSet";
            this.skladisteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "TOTAL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 57);
            this.button1.TabIndex = 43;
            this.button1.Text = "Ucitaj bazu/osvjezi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(577, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Prvo upisi kolicinu pa odaberi artikl";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(831, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 20);
            this.textBox5.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Cijena";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDrobeDataGridViewTextBoxColumn,
            this.nazivartiklaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.jmjDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.robaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 127);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDrobeDataGridViewTextBoxColumn
            // 
            this.iDrobeDataGridViewTextBoxColumn.DataPropertyName = "IDrobe";
            this.iDrobeDataGridViewTextBoxColumn.HeaderText = "IDrobe";
            this.iDrobeDataGridViewTextBoxColumn.Name = "iDrobeDataGridViewTextBoxColumn";
            // 
            // nazivartiklaDataGridViewTextBoxColumn
            // 
            this.nazivartiklaDataGridViewTextBoxColumn.DataPropertyName = "Naziv_artikla";
            this.nazivartiklaDataGridViewTextBoxColumn.HeaderText = "Naziv_artikla";
            this.nazivartiklaDataGridViewTextBoxColumn.Name = "nazivartiklaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // jmjDataGridViewTextBoxColumn
            // 
            this.jmjDataGridViewTextBoxColumn.DataPropertyName = "Jmj";
            this.jmjDataGridViewTextBoxColumn.HeaderText = "Jmj";
            this.jmjDataGridViewTextBoxColumn.Name = "jmjDataGridViewTextBoxColumn";
            // 
            // robaBindingSource
            // 
            this.robaBindingSource.DataMember = "Roba";
            this.robaBindingSource.DataSource = this.skladisteDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Naziv Artikla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "IDRobe";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(805, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(805, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(805, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(805, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 33;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(14, 295);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(771, 157);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // robaTableAdapter
            // 
            this.robaTableAdapter.ClearBeforeFill = true;
            // 
            // firmeTableAdapter
            // 
            this.firmeTableAdapter.ClearBeforeFill = true;
            // 
            // stavkaIzdatniceTableAdapter1
            // 
            this.stavkaIzdatniceTableAdapter1.ClearBeforeFill = true;
            // 
            // izdatnicaTableAdapter1
            // 
            this.izdatnicaTableAdapter1.ClearBeforeFill = true;
            // 
            // FormIzdatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 482);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "FormIzdatnica";
            this.Text = "FormIzdatnica";
            this.Load += new System.EventHandler(this.FormIzdatnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private SkladisteDataSet skladisteDataSet;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private SkladisteDataSetTableAdapters.RobaTableAdapter robaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDrobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivartiklaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmjDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource firmeBindingSource;
        private SkladisteDataSetTableAdapters.FirmeTableAdapter firmeTableAdapter;
        private SkladisteDataSetTableAdapters.StavkaIzdatniceTableAdapter stavkaIzdatniceTableAdapter1;
        private SkladisteDataSetTableAdapters.IzdatnicaTableAdapter izdatnicaTableAdapter1;
    }
}