
namespace szofttech2_projekt_jpwqqk
{
    partial class VaccinesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vaccineidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonEditSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(63, 346);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 50);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(63, 202);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 50);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccineidDataGridViewTextBoxColumn,
            this.vaccinenameDataGridViewTextBoxColumn,
            this.vaccinationsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vaccineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(255, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 532);
            this.dataGridView1.TabIndex = 22;
            // 
            // vaccineidDataGridViewTextBoxColumn
            // 
            this.vaccineidDataGridViewTextBoxColumn.DataPropertyName = "vaccine_id";
            this.vaccineidDataGridViewTextBoxColumn.HeaderText = "vaccine_id";
            this.vaccineidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaccineidDataGridViewTextBoxColumn.Name = "vaccineidDataGridViewTextBoxColumn";
            this.vaccineidDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccineidDataGridViewTextBoxColumn.Width = 125;
            // 
            // vaccinenameDataGridViewTextBoxColumn
            // 
            this.vaccinenameDataGridViewTextBoxColumn.DataPropertyName = "vaccine_name";
            this.vaccinenameDataGridViewTextBoxColumn.HeaderText = "vaccine_name";
            this.vaccinenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaccinenameDataGridViewTextBoxColumn.Name = "vaccinenameDataGridViewTextBoxColumn";
            this.vaccinenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccinenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // vaccinationsDataGridViewTextBoxColumn
            // 
            this.vaccinationsDataGridViewTextBoxColumn.DataPropertyName = "Vaccinations";
            this.vaccinationsDataGridViewTextBoxColumn.HeaderText = "Vaccinations";
            this.vaccinationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaccinationsDataGridViewTextBoxColumn.Name = "vaccinationsDataGridViewTextBoxColumn";
            this.vaccinationsDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccinationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // vaccineBindingSource
            // 
            this.vaccineBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Vaccine);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(31, 100);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(189, 22);
            this.textBoxName.TabIndex = 18;
            // 
            // buttonEditSave
            // 
            this.buttonEditSave.Location = new System.Drawing.Point(63, 272);
            this.buttonEditSave.Name = "buttonEditSave";
            this.buttonEditSave.Size = new System.Drawing.Size(117, 50);
            this.buttonEditSave.TabIndex = 25;
            this.buttonEditSave.Text = "Edit";
            this.buttonEditSave.UseVisualStyleBackColor = true;
            this.buttonEditSave.Click += new System.EventHandler(this.buttonEditSave_Click);
            // 
            // VaccinesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "VaccinesUC";
            this.Size = new System.Drawing.Size(943, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vaccineBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonEditSave;
    }
}
