
namespace szofttech2_projekt_jpwqqk
{
    partial class VaccinationsUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPerson = new System.Windows.Forms.ListBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPersonFilter = new System.Windows.Forms.TextBox();
            this.listBoxPersonVaccinations = new System.Windows.Forms.ListBox();
            this.vaccinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxVaccine = new System.Windows.Forms.ListBox();
            this.vaccineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxVaccineFilter = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search people";
            // 
            // listBoxPerson
            // 
            this.listBoxPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPerson.DataSource = this.personBindingSource;
            this.listBoxPerson.DisplayMember = "person_name";
            this.listBoxPerson.FormattingEnabled = true;
            this.listBoxPerson.ItemHeight = 16;
            this.listBoxPerson.Location = new System.Drawing.Point(3, 63);
            this.listBoxPerson.Name = "listBoxPerson";
            this.listBoxPerson.Size = new System.Drawing.Size(197, 452);
            this.listBoxPerson.TabIndex = 7;
            this.listBoxPerson.SelectedIndexChanged += new System.EventHandler(this.listBoxPerson_SelectedIndexChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Person);
            // 
            // textBoxPersonFilter
            // 
            this.textBoxPersonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPersonFilter.Location = new System.Drawing.Point(2, 31);
            this.textBoxPersonFilter.Name = "textBoxPersonFilter";
            this.textBoxPersonFilter.Size = new System.Drawing.Size(197, 22);
            this.textBoxPersonFilter.TabIndex = 6;
            this.textBoxPersonFilter.TextChanged += new System.EventHandler(this.textBoxPersonFilter_TextChanged);
            // 
            // listBoxPersonVaccinations
            // 
            this.listBoxPersonVaccinations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPersonVaccinations.FormattingEnabled = true;
            this.listBoxPersonVaccinations.ItemHeight = 16;
            this.listBoxPersonVaccinations.Location = new System.Drawing.Point(233, 63);
            this.listBoxPersonVaccinations.Name = "listBoxPersonVaccinations";
            this.listBoxPersonVaccinations.Size = new System.Drawing.Size(219, 452);
            this.listBoxPersonVaccinations.TabIndex = 10;
            // 
            // vaccinationBindingSource
            // 
            this.vaccinationBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Vaccination);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search vaccines";
            // 
            // listBoxVaccine
            // 
            this.listBoxVaccine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxVaccine.DataSource = this.vaccineBindingSource;
            this.listBoxVaccine.DisplayMember = "vaccine_name";
            this.listBoxVaccine.FormattingEnabled = true;
            this.listBoxVaccine.ItemHeight = 16;
            this.listBoxVaccine.Location = new System.Drawing.Point(684, 63);
            this.listBoxVaccine.Name = "listBoxVaccine";
            this.listBoxVaccine.Size = new System.Drawing.Size(197, 452);
            this.listBoxVaccine.TabIndex = 12;
            // 
            // vaccineBindingSource
            // 
            this.vaccineBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Vaccine);
            // 
            // textBoxVaccineFilter
            // 
            this.textBoxVaccineFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVaccineFilter.Location = new System.Drawing.Point(683, 31);
            this.textBoxVaccineFilter.Name = "textBoxVaccineFilter";
            this.textBoxVaccineFilter.Size = new System.Drawing.Size(197, 22);
            this.textBoxVaccineFilter.TabIndex = 11;
            this.textBoxVaccineFilter.TextChanged += new System.EventHandler(this.textBoxVaccineFilter_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDate.Location = new System.Drawing.Point(501, 185);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(133, 22);
            this.textBoxDate.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(520, 213);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 37);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(520, 277);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(91, 37);
            this.buttonRemove.TabIndex = 17;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // VaccinationsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxVaccine);
            this.Controls.Add(this.textBoxVaccineFilter);
            this.Controls.Add(this.listBoxPersonVaccinations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPerson);
            this.Controls.Add(this.textBoxPersonFilter);
            this.Name = "VaccinationsUC";
            this.Size = new System.Drawing.Size(884, 541);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccinationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaccineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPerson;
        private System.Windows.Forms.TextBox textBoxPersonFilter;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.ListBox listBoxPersonVaccinations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxVaccine;
        private System.Windows.Forms.TextBox textBoxVaccineFilter;
        private System.Windows.Forms.BindingSource vaccineBindingSource;
        private System.Windows.Forms.BindingSource vaccinationBindingSource;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
    }
}
