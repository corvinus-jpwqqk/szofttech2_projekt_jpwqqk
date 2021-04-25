
namespace szofttech2_projekt_jpwqqk
{
    partial class PeopleUC
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBirthdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.personidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personbirthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(27, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(189, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birthdate";
            // 
            // textBoxBirthdate
            // 
            this.textBoxBirthdate.Location = new System.Drawing.Point(27, 91);
            this.textBoxBirthdate.Name = "textBoxBirthdate";
            this.textBoxBirthdate.Size = new System.Drawing.Size(189, 22);
            this.textBoxBirthdate.TabIndex = 2;
            this.textBoxBirthdate.Text = "yyyy.mm.dd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone number";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(27, 154);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(189, 22);
            this.textBoxPhoneNumber.TabIndex = 4;
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
            this.personidDataGridViewTextBoxColumn,
            this.personnameDataGridViewTextBoxColumn,
            this.personbirthdateDataGridViewTextBoxColumn,
            this.personnumberDataGridViewTextBoxColumn,
            this.connectionsDataGridViewTextBoxColumn,
            this.vaccinationsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(251, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 521);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(62, 239);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 50);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(62, 357);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 50);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // personidDataGridViewTextBoxColumn
            // 
            this.personidDataGridViewTextBoxColumn.DataPropertyName = "person_id";
            this.personidDataGridViewTextBoxColumn.HeaderText = "person_id";
            this.personidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personidDataGridViewTextBoxColumn.Name = "personidDataGridViewTextBoxColumn";
            this.personidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personidDataGridViewTextBoxColumn.Visible = false;
            this.personidDataGridViewTextBoxColumn.Width = 125;
            // 
            // personnameDataGridViewTextBoxColumn
            // 
            this.personnameDataGridViewTextBoxColumn.DataPropertyName = "person_name";
            this.personnameDataGridViewTextBoxColumn.HeaderText = "person_name";
            this.personnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personnameDataGridViewTextBoxColumn.Name = "personnameDataGridViewTextBoxColumn";
            this.personnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // personbirthdateDataGridViewTextBoxColumn
            // 
            this.personbirthdateDataGridViewTextBoxColumn.DataPropertyName = "person_birthdate";
            this.personbirthdateDataGridViewTextBoxColumn.HeaderText = "person_birthdate";
            this.personbirthdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personbirthdateDataGridViewTextBoxColumn.Name = "personbirthdateDataGridViewTextBoxColumn";
            this.personbirthdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.personbirthdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // personnumberDataGridViewTextBoxColumn
            // 
            this.personnumberDataGridViewTextBoxColumn.DataPropertyName = "person_number";
            this.personnumberDataGridViewTextBoxColumn.HeaderText = "person_number";
            this.personnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personnumberDataGridViewTextBoxColumn.Name = "personnumberDataGridViewTextBoxColumn";
            this.personnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnumberDataGridViewTextBoxColumn.Width = 125;
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
            // vaccinationsDataGridViewTextBoxColumn
            // 
            this.vaccinationsDataGridViewTextBoxColumn.DataPropertyName = "Vaccinations";
            this.vaccinationsDataGridViewTextBoxColumn.HeaderText = "Vaccinations";
            this.vaccinationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaccinationsDataGridViewTextBoxColumn.Name = "vaccinationsDataGridViewTextBoxColumn";
            this.vaccinationsDataGridViewTextBoxColumn.ReadOnly = true;
            this.vaccinationsDataGridViewTextBoxColumn.Visible = false;
            this.vaccinationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Person);
            // 
            // PeopleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBirthdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "PeopleUC";
            this.Size = new System.Drawing.Size(888, 528);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBirthdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn personidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personbirthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationsDataGridViewTextBoxColumn;
    }
}
