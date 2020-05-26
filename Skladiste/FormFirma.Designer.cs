namespace Skladiste
{
    partial class FormFirma
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
            this.ID_wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skladisteDataSetFirme = new Skladiste.SkladisteDataSet();
            this.firmeTableAdapter = new Skladiste.SkladisteDataSetTableAdapters.FirmeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteDataSetFirme)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_wDataGridViewTextBoxColumn,
            this.BEDataGridViewTextBoxColumn,
            this.FactoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(162, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 132);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.FactoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // firmeBindingSource
            // 
            this.firmeBindingSource.DataMember = "Firme";
            this.firmeBindingSource.DataSource = this.skladisteDataSetFirme;
            // 
            // skladisteDataSetFirme
            // 
            this.skladisteDataSetFirme.DataSetName = "SkladisteDataSetFirme";
            this.skladisteDataSetFirme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmeTableAdapter
            // 
            this.firmeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ucitaj bazu/osvjezi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "UPDATE Baze";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 166);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFirma";
            this.Text = "FormFirma";
            this.Load += new System.EventHandler(this.FormFirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladisteDataSetFirme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SkladisteDataSet skladisteDataSetFirme;
        private System.Windows.Forms.BindingSource firmeBindingSource;
        private SkladisteDataSetTableAdapters.FirmeTableAdapter firmeTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}