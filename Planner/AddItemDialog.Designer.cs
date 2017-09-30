namespace Planner
{
    partial class AddItemDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextAssignment = new System.Windows.Forms.TextBox();
            this.TextDescription = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TextFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class:";
            // 
            // TextClass
            // 
            this.TextClass.BackColor = System.Drawing.SystemColors.Control;
            this.TextClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextClass.FormattingEnabled = true;
            this.TextClass.Items.AddRange(new object[] {
            "Data",
            "Discrete",
            "Circuits",
            "Signals",
            "Diff Eq"});
            this.TextClass.Location = new System.Drawing.Point(104, 9);
            this.TextClass.Name = "TextClass";
            this.TextClass.Size = new System.Drawing.Size(363, 24);
            this.TextClass.TabIndex = 1;
            this.TextClass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assignment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description:";
            // 
            // TextAssignment
            // 
            this.TextAssignment.Location = new System.Drawing.Point(105, 36);
            this.TextAssignment.Name = "TextAssignment";
            this.TextAssignment.Size = new System.Drawing.Size(362, 22);
            this.TextAssignment.TabIndex = 2;
            // 
            // TextDescription
            // 
            this.TextDescription.Location = new System.Drawing.Point(16, 136);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(451, 171);
            this.TextDescription.TabIndex = 6;
            this.TextDescription.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(367, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(261, 313);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 23);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(362, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "File:";
            // 
            // TextFile
            // 
            this.TextFile.Location = new System.Drawing.Point(105, 91);
            this.TextFile.Name = "TextFile";
            this.TextFile.Size = new System.Drawing.Size(284, 22);
            this.TextFile.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddItemDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.TextAssignment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextClass);
            this.Controls.Add(this.label1);
            this.Name = "AddItemDialog";
            this.Text = "AddItemDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TextClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextAssignment;
        private System.Windows.Forms.RichTextBox TextDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextFile;
        private System.Windows.Forms.Button button1;
    }
}