namespace Forms_Test
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fdegaudemarDataSet1 = new Forms_Test.fdegaudemarDataSet1();
            this.vAdherentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vAdherentsTableAdapter = new Forms_Test.fdegaudemarDataSet1TableAdapters.vAdherentsTableAdapter();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseRueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseVilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAdherentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseRueDataGridViewTextBoxColumn,
            this.adresseCPDataGridViewTextBoxColumn,
            this.adresseVilleDataGridViewTextBoxColumn,
            this.pointureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vAdherentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // fdegaudemarDataSet1
            // 
            this.fdegaudemarDataSet1.DataSetName = "fdegaudemarDataSet1";
            this.fdegaudemarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vAdherentsBindingSource
            // 
            this.vAdherentsBindingSource.DataMember = "vAdherents";
            this.vAdherentsBindingSource.DataSource = this.fdegaudemarDataSet1;
            // 
            // vAdherentsTableAdapter
            // 
            this.vAdherentsTableAdapter.ClearBeforeFill = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // adresseRueDataGridViewTextBoxColumn
            // 
            this.adresseRueDataGridViewTextBoxColumn.DataPropertyName = "AdresseRue";
            this.adresseRueDataGridViewTextBoxColumn.HeaderText = "AdresseRue";
            this.adresseRueDataGridViewTextBoxColumn.Name = "adresseRueDataGridViewTextBoxColumn";
            // 
            // adresseCPDataGridViewTextBoxColumn
            // 
            this.adresseCPDataGridViewTextBoxColumn.DataPropertyName = "AdresseCP";
            this.adresseCPDataGridViewTextBoxColumn.HeaderText = "AdresseCP";
            this.adresseCPDataGridViewTextBoxColumn.Name = "adresseCPDataGridViewTextBoxColumn";
            // 
            // adresseVilleDataGridViewTextBoxColumn
            // 
            this.adresseVilleDataGridViewTextBoxColumn.DataPropertyName = "AdresseVille";
            this.adresseVilleDataGridViewTextBoxColumn.HeaderText = "AdresseVille";
            this.adresseVilleDataGridViewTextBoxColumn.Name = "adresseVilleDataGridViewTextBoxColumn";
            // 
            // pointureDataGridViewTextBoxColumn
            // 
            this.pointureDataGridViewTextBoxColumn.DataPropertyName = "Pointure";
            this.pointureDataGridViewTextBoxColumn.HeaderText = "Pointure";
            this.pointureDataGridViewTextBoxColumn.Name = "pointureDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fdegaudemarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAdherentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private fdegaudemarDataSet1 fdegaudemarDataSet1;
        private System.Windows.Forms.BindingSource vAdherentsBindingSource;
        private fdegaudemarDataSet1TableAdapters.vAdherentsTableAdapter vAdherentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseRueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseVilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointureDataGridViewTextBoxColumn;
    }
}

