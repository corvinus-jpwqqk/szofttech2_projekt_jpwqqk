
namespace szofttech2_projekt_jpwqqk
{
    partial class ContactsUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.buttonEditSave = new System.Windows.Forms.Button();
            this.contactidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(61, 356);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 50);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(61, 224);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 50);
            this.buttonAdd.TabIndex = 16;
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
            this.contactidDataGridViewTextBoxColumn,
            this.contactdateDataGridViewTextBoxColumn,
            this.contactplaceDataGridViewTextBoxColumn,
            this.connectionsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(253, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 542);
            this.dataGridView1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Location";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(26, 124);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(189, 22);
            this.textBoxLocation.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(26, 60);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(189, 22);
            this.textBoxDate.TabIndex = 9;
            this.textBoxDate.Text = "yyyy.mm.dd";
            // 
            // buttonEditSave
            // 
            this.buttonEditSave.Location = new System.Drawing.Point(61, 289);
            this.buttonEditSave.Name = "buttonEditSave";
            this.buttonEditSave.Size = new System.Drawing.Size(117, 50);
            this.buttonEditSave.TabIndex = 18;
            this.buttonEditSave.Text = "Edit";
            this.buttonEditSave.UseVisualStyleBackColor = true;
            this.buttonEditSave.Click += new System.EventHandler(this.buttonEditSave_Click);
            // 
            // contactidDataGridViewTextBoxColumn
            // 
            this.contactidDataGridViewTextBoxColumn.DataPropertyName = "contact_id";
            this.contactidDataGridViewTextBoxColumn.HeaderText = "contact_id";
            this.contactidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactidDataGridViewTextBoxColumn.Name = "contactidDataGridViewTextBoxColumn";
            this.contactidDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactidDataGridViewTextBoxColumn.Visible = false;
            this.contactidDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactdateDataGridViewTextBoxColumn
            // 
            this.contactdateDataGridViewTextBoxColumn.DataPropertyName = "contact_date";
            this.contactdateDataGridViewTextBoxColumn.HeaderText = "contact_date";
            this.contactdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactdateDataGridViewTextBoxColumn.Name = "contactdateDataGridViewTextBoxColumn";
            this.contactdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactplaceDataGridViewTextBoxColumn
            // 
            this.contactplaceDataGridViewTextBoxColumn.DataPropertyName = "contact_place";
            this.contactplaceDataGridViewTextBoxColumn.HeaderText = "contact_place";
            this.contactplaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactplaceDataGridViewTextBoxColumn.Name = "contactplaceDataGridViewTextBoxColumn";
            this.contactplaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactplaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // connectionsDataGridViewTextBoxColumn
            // 
            this.connectionsDataGridViewTextBoxColumn.DataPropertyName = "Connections";
            this.connectionsDataGridViewTextBoxColumn.HeaderText = "Connections";
            this.connectionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.connectionsDataGridViewTextBoxColumn.Name = "connectionsDataGridViewTextBoxColumn";
            this.connectionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.connectionsDataGridViewTextBoxColumn.Visible = false;
            this.connectionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Contact);
            // 
            // ContactsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDate);
            this.Name = "ContactsUC";
            this.Size = new System.Drawing.Size(887, 548);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.Button buttonEditSave;
    }
}
