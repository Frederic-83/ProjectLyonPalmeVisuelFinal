namespace Forms_Test
{
    partial class Form3
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
            this.fdegaudemarDataSet2 = new Forms_Test.fdegaudemarDataSet2();
            this.fdegaudemarDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPalmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPalmesTableAdapter = new Forms_Test.fdegaudemarDataSet2TableAdapters.VPalmesTableAdapter();
            this.codeMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vMatTableAdapter = new Forms_Test.fdegaudemarDataSet2TableAdapters.VMatTableAdapter();
            this.aIletteONDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pointurePalmesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matierePalmesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vMatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codeMATDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPalmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeMATDataGridViewTextBoxColumn,
            this.matierePalmesDataGridViewTextBoxColumn,
            this.pointurePalmesDataGridViewTextBoxColumn,
            this.aIletteONDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.vPalmesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fdegaudemarDataSet2
            // 
            this.fdegaudemarDataSet2.DataSetName = "fdegaudemarDataSet2";
            this.fdegaudemarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fdegaudemarDataSet2BindingSource
            // 
            this.fdegaudemarDataSet2BindingSource.DataSource = this.fdegaudemarDataSet2;
            this.fdegaudemarDataSet2BindingSource.Position = 0;
            // 
            // vPalmesBindingSource
            // 
            this.vPalmesBindingSource.DataMember = "VPalmes";
            this.vPalmesBindingSource.DataSource = this.fdegaudemarDataSet2BindingSource;
            // 
            // vPalmesTableAdapter
            // 
            this.vPalmesTableAdapter.ClearBeforeFill = true;
            // 
            // codeMATDataGridViewTextBoxColumn
            // 
            this.codeMATDataGridViewTextBoxColumn.DataPropertyName = "CodeMAT";
            this.codeMATDataGridViewTextBoxColumn.HeaderText = "CodeMAT";
            this.codeMATDataGridViewTextBoxColumn.Name = "codeMATDataGridViewTextBoxColumn";
            // 
            // vMatBindingSource
            // 
            this.vMatBindingSource.DataMember = "VMat";
            this.vMatBindingSource.DataSource = this.fdegaudemarDataSet2BindingSource;
            // 
            // vMatTableAdapter
            // 
            this.vMatTableAdapter.ClearBeforeFill = true;
            // 
            // aIletteONDataGridViewCheckBoxColumn
            // 
            this.aIletteONDataGridViewCheckBoxColumn.DataPropertyName = "AIletteON";
            this.aIletteONDataGridViewCheckBoxColumn.HeaderText = "AIletteON";
            this.aIletteONDataGridViewCheckBoxColumn.Name = "aIletteONDataGridViewCheckBoxColumn";
            // 
            // pointurePalmesDataGridViewTextBoxColumn
            // 
            this.pointurePalmesDataGridViewTextBoxColumn.DataPropertyName = "PointurePalmes";
            this.pointurePalmesDataGridViewTextBoxColumn.HeaderText = "PointurePalmes";
            this.pointurePalmesDataGridViewTextBoxColumn.Name = "pointurePalmesDataGridViewTextBoxColumn";
            // 
            // matierePalmesDataGridViewTextBoxColumn
            // 
            this.matierePalmesDataGridViewTextBoxColumn.DataPropertyName = "MatierePalmes";
            this.matierePalmesDataGridViewTextBoxColumn.HeaderText = "MatierePalmes";
            this.matierePalmesDataGridViewTextBoxColumn.Name = "matierePalmesDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeMATDataGridViewTextBoxColumn1,
            this.typeMATDataGridViewTextBoxColumn,
            this.marqueMATDataGridViewTextBoxColumn,
            this.etatMATDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vMatBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(445, 289);
            this.dataGridView2.TabIndex = 1;
            // 
            // vMatBindingSource1
            // 
            this.vMatBindingSource1.DataMember = "VMat";
            this.vMatBindingSource1.DataSource = this.fdegaudemarDataSet2BindingSource;
            // 
            // codeMATDataGridViewTextBoxColumn1
            // 
            this.codeMATDataGridViewTextBoxColumn1.DataPropertyName = "CodeMAT";
            this.codeMATDataGridViewTextBoxColumn1.HeaderText = "CodeMAT";
            this.codeMATDataGridViewTextBoxColumn1.Name = "codeMATDataGridViewTextBoxColumn1";
            // 
            // typeMATDataGridViewTextBoxColumn
            // 
            this.typeMATDataGridViewTextBoxColumn.DataPropertyName = "TypeMAT";
            this.typeMATDataGridViewTextBoxColumn.HeaderText = "TypeMAT";
            this.typeMATDataGridViewTextBoxColumn.Name = "typeMATDataGridViewTextBoxColumn";
            // 
            // marqueMATDataGridViewTextBoxColumn
            // 
            this.marqueMATDataGridViewTextBoxColumn.DataPropertyName = "MarqueMAT";
            this.marqueMATDataGridViewTextBoxColumn.HeaderText = "MarqueMAT";
            this.marqueMATDataGridViewTextBoxColumn.Name = "marqueMATDataGridViewTextBoxColumn";
            // 
            // etatMATDataGridViewTextBoxColumn
            // 
            this.etatMATDataGridViewTextBoxColumn.DataPropertyName = "EtatMAT";
            this.etatMATDataGridViewTextBoxColumn.HeaderText = "EtatMAT";
            this.etatMATDataGridViewTextBoxColumn.Name = "etatMATDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 550);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPalmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMatBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fdegaudemarDataSet2BindingSource;
        private fdegaudemarDataSet2 fdegaudemarDataSet2;
        private System.Windows.Forms.BindingSource vPalmesBindingSource;
        private fdegaudemarDataSet2TableAdapters.VPalmesTableAdapter vPalmesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vMatBindingSource;
        private fdegaudemarDataSet2TableAdapters.VMatTableAdapter vMatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matierePalmesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointurePalmesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aIletteONDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMATDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vMatBindingSource1;
    }
}