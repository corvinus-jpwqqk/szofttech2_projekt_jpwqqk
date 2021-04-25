
namespace szofttech2_projekt_jpwqqk
{
    partial class ConnectionsUC
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
            this.textBoxPersonFilter = new System.Windows.Forms.TextBox();
            this.listBoxPerson = new System.Windows.Forms.ListBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxContact = new System.Windows.Forms.ListBox();
            this.textBoxContactFilter = new System.Windows.Forms.TextBox();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPersonContacts = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPersonFilter
            // 
            this.textBoxPersonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPersonFilter.Location = new System.Drawing.Point(3, 33);
            this.textBoxPersonFilter.Name = "textBoxPersonFilter";
            this.textBoxPersonFilter.Size = new System.Drawing.Size(197, 22);
            this.textBoxPersonFilter.TabIndex = 0;
            this.textBoxPersonFilter.TextChanged += new System.EventHandler(this.textBoxPersonFilter_TextChanged);
            // 
            // listBoxPerson
            // 
            this.listBoxPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPerson.DataSource = this.personBindingSource;
            this.listBoxPerson.DisplayMember = "person_name";
            this.listBoxPerson.FormattingEnabled = true;
            this.listBoxPerson.ItemHeight = 16;
            this.listBoxPerson.Location = new System.Drawing.Point(4, 65);
            this.listBoxPerson.Name = "listBoxPerson";
            this.listBoxPerson.Size = new System.Drawing.Size(197, 452);
            this.listBoxPerson.TabIndex = 1;
            this.listBoxPerson.SelectedIndexChanged += new System.EventHandler(this.listBoxPerson_SelectedIndexChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Person);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search people";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search contacts";
            // 
            // listBoxContact
            // 
            this.listBoxContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxContact.FormattingEnabled = true;
            this.listBoxContact.ItemHeight = 16;
            this.listBoxContact.Location = new System.Drawing.Point(738, 65);
            this.listBoxContact.Name = "listBoxContact";
            this.listBoxContact.Size = new System.Drawing.Size(197, 452);
            this.listBoxContact.TabIndex = 7;
            // 
            // textBoxContactFilter
            // 
            this.textBoxContactFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactFilter.Location = new System.Drawing.Point(737, 33);
            this.textBoxContactFilter.Name = "textBoxContactFilter";
            this.textBoxContactFilter.Size = new System.Drawing.Size(197, 22);
            this.textBoxContactFilter.TabIndex = 6;
            this.textBoxContactFilter.TextChanged += new System.EventHandler(this.textBoxContactFilter_TextChanged);
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Contact);
            // 
            // listBoxPersonContacts
            // 
            this.listBoxPersonContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPersonContacts.FormattingEnabled = true;
            this.listBoxPersonContacts.ItemHeight = 16;
            this.listBoxPersonContacts.Location = new System.Drawing.Point(237, 65);
            this.listBoxPersonContacts.Name = "listBoxPersonContacts";
            this.listBoxPersonContacts.Size = new System.Drawing.Size(246, 452);
            this.listBoxPersonContacts.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(556, 189);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 47);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "< Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(556, 273);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(103, 47);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Remove >";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(489, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Funkció még nem működik";
            // 
            // ConnectionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxPersonContacts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxContact);
            this.Controls.Add(this.textBoxContactFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPerson);
            this.Controls.Add(this.textBoxPersonFilter);
            this.Name = "ConnectionsUC";
            this.Size = new System.Drawing.Size(938, 545);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersonFilter;
        private System.Windows.Forms.ListBox listBoxPerson;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxContact;
        private System.Windows.Forms.TextBox textBoxContactFilter;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.ListBox listBoxPersonContacts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label4;
    }
}
