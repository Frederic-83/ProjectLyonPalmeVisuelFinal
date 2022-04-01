namespace Forms_Test
{
    partial class Form2
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
            this.fdegaudemarDataSet1 = new Forms_Test.fdegaudemarDataSet1();
            this.gMPalmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gMPalmesTableAdapter = new Forms_Test.fdegaudemarDataSet1TableAdapters.GMPalmesTableAdapter();
            this.codeMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatMATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdegaudemarDataSet = new Forms_Test.fdegaudemarDataSet();
            this.fdegaudemarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMPalmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeMATDataGridViewTextBoxColumn,
            this.typeMATDataGridViewTextBoxColumn,
            this.marqueMATDataGridViewTextBoxColumn,
            this.etatMATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gMPalmesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(58, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // fdegaudemarDataSet1
            // 
            this.fdegaudemarDataSet1.DataSetName = "fdegaudemarDataSet1";
            this.fdegaudemarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gMPalmesBindingSource
            // 
            this.gMPalmesBindingSource.DataMember = "GMPalmes";
            this.gMPalmesBindingSource.DataSource = this.fdegaudemarDataSet1;
            // 
            // gMPalmesTableAdapter
            // 
            this.gMPalmesTableAdapter.ClearBeforeFill = true;
            // 
            // codeMATDataGridViewTextBoxColumn
            // 
            this.codeMATDataGridViewTextBoxColumn.DataPropertyName = "CodeMAT";
            this.codeMATDataGridViewTextBoxColumn.HeaderText = "CodeMAT";
            this.codeMATDataGridViewTextBoxColumn.Name = "codeMATDataGridViewTextBoxColumn";
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
            // fdegaudemarDataSet
            // 
            this.fdegaudemarDataSet.DataSetName = "fdegaudemarDataSet";
            this.fdegaudemarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fdegaudemarDataSetBindingSource
            // 
            this.fdegaudemarDataSetBindingSource.DataSource = this.fdegaudemarDataSet;
            this.fdegaudemarDataSetBindingSource.Position = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMPalmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private fdegaudemarDataSet1 fdegaudemarDataSet1;
        private System.Windows.Forms.BindingSource gMPalmesBindingSource;
        private fdegaudemarDataSet1TableAdapters.GMPalmesTableAdapter gMPalmesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatMATDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fdegaudemarDataSetBindingSource;
        private fdegaudemarDataSet fdegaudemarDataSet;
        private System.Windows.Forms.BindingSource fdegaudemarDataSet3BindingSource;
    }
}