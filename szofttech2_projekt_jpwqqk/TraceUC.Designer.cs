
namespace szofttech2_projekt_jpwqqk
{
    partial class TraceUC
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
            this.numericUpDownWeek = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTrace = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeek)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
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
            this.listBoxPerson.Location = new System.Drawing.Point(3, 64);
            this.listBoxPerson.Name = "listBoxPerson";
            this.listBoxPerson.Size = new System.Drawing.Size(197, 436);
            this.listBoxPerson.TabIndex = 7;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(szofttech2_projekt_jpwqqk.Person);
            // 
            // textBoxPersonFilter
            // 
            this.textBoxPersonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPersonFilter.Location = new System.Drawing.Point(2, 32);
            this.textBoxPersonFilter.Name = "textBoxPersonFilter";
            this.textBoxPersonFilter.Size = new System.Drawing.Size(197, 22);
            this.textBoxPersonFilter.TabIndex = 6;
            this.textBoxPersonFilter.TextChanged += new System.EventHandler(this.textBoxPersonFilter_TextChanged);
            // 
            // numericUpDownWeek
            // 
            this.numericUpDownWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownWeek.Location = new System.Drawing.Point(3, 27);
            this.numericUpDownWeek.Name = "numericUpDownWeek";
            this.numericUpDownWeek.Size = new System.Drawing.Size(194, 22);
            this.numericUpDownWeek.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.DisplayMember = "person_name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(695, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 436);
            this.listBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Trace connections within ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTrace
            // 
            this.buttonTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTrace.Location = new System.Drawing.Point(3, 73);
            this.buttonTrace.Name = "buttonTrace";
            this.buttonTrace.Size = new System.Drawing.Size(194, 55);
            this.buttonTrace.TabIndex = 13;
            this.buttonTrace.Text = "Trace";
            this.buttonTrace.UseVisualStyleBackColor = true;
            this.buttonTrace.Click += new System.EventHandler(this.buttonTrace_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonTrace, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownWeek, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(350, 178);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.2963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.7037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 131);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "weeks recursively";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(346, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Funkció még nem működik";
            // 
            // TraceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPerson);
            this.Controls.Add(this.textBoxPersonFilter);
            this.Name = "TraceUC";
            this.Size = new System.Drawing.Size(895, 522);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeek)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPerson;
        private System.Windows.Forms.TextBox textBoxPersonFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownWeek;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTrace;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
