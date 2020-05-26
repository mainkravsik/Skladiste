namespace Skladiste
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.firmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladisteDataSet = new Skladiste.SkladisteDataSet();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.robaTableAdapter = new Skladiste.SkladisteDataSetTableAdapters.RobaTableAdapter();
            this.firmeTableAdapter = new Skladiste.SkladisteDataSetTableAdapters.FirmeTableAdapter();
            this.ID_wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_wDataGridViewTextBoxColumn,
            this.BEDataGridViewTextBoxColumn,
            this.FactoryDataGridViewTextBoxColumn,
            this.Warehouse});
            this.dataGridView1.DataSource = this.firmeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(403, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 102);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 141);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(231, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 233);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(231, 22);
            this.textBox5.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 252);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(376, 114);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "БЕ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Завод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID склада";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Склад";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 389);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 63);
            this.button2.TabIndex = 15;
            this.button2.Text = "Firme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(817, 388);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 64);
            this.button3.TabIndex = 16;
            this.button3.Text = "Izdatnica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1084, 388);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 64);
            this.button4.TabIndex = 17;
            this.button4.Text = "Primka";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 389);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(196, 63);
            this.button5.TabIndex = 18;
            this.button5.Text = "Ucitaj bazu/osvjezi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            // robaBindingSource
            // 
            this.robaBindingSource.DataMember = "Roba";
            this.robaBindingSource.DataSource = this.skladisteDataSet;
            // 
            // robaTableAdapter
            // 
            this.robaTableAdapter.ClearBeforeFill = true;
            // 
            // firmeTableAdapter
            // 
            this.firmeTableAdapter.ClearBeforeFill = true;
            // 
            // ID_wDataGridViewTextBoxColumn
            // 
            this.ID_wDataGridViewTextBoxColumn.DataPropertyName = "ID_w";
            this.ID_wDataGridViewTextBoxColumn.HeaderText = "ID_w";
            this.ID_wDataGridViewTextBoxColumn.Name = "ID_wDataGridViewTextBoxColumn";
            // 
            // BEDataGridViewTextBoxColumn
            // 
            this.BEDataGridViewTextBoxColumn.DataPropertyName = "BE";
            this.BEDataGridViewTextBoxColumn.HeaderText = "BE";
            this.BEDataGridViewTextBoxColumn.Name = "BEDataGridViewTextBoxColumn";
            // 
            // FactoryDataGridViewTextBoxColumn
            // 
            this.FactoryDataGridViewTextBoxColumn.DataPropertyName = "Factory";
            this.FactoryDataGridViewTextBoxColumn.HeaderText = "Factory";
            this.FactoryDataGridViewTextBoxColumn.Name = "FactoryDataGridViewTextBoxColumn";
            // 
            // Warehouse
            // 
            this.Warehouse.DataPropertyName = "Warehouse";
            this.Warehouse.HeaderText = "Warehouse";
            this.Warehouse.Name = "Warehouse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 470);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private SkladisteDataSet skladisteDataSet;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private SkladisteDataSetTableAdapters.RobaTableAdapter robaTableAdapter;
        private System.Windows.Forms.BindingSource firmeBindingSource;
        private SkladisteDataSetTableAdapters.FirmeTableAdapter firmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse;
    }
}

