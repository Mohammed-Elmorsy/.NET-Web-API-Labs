namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_students = new System.Windows.Forms.Button();
            this.gv_stds = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stds)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_students
            // 
            this.btn_students.Location = new System.Drawing.Point(152, 129);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(108, 24);
            this.btn_students.TabIndex = 0;
            this.btn_students.Text = "Load Students";
            this.btn_students.UseVisualStyleBackColor = true;
            this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
            // 
            // gv_stds
            // 
            this.gv_stds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_stds.Location = new System.Drawing.Point(24, 177);
            this.gv_stds.Name = "gv_stds";
            this.gv_stds.Size = new System.Drawing.Size(388, 166);
            this.gv_stds.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(629, 177);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add Student";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(620, 54);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(620, 93);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 20);
            this.txt_address.TabIndex = 6;
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Location = new System.Drawing.Point(543, 57);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(49, 13);
            this.lbl_fullName.TabIndex = 7;
            this.lbl_fullName.Text = "full name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(543, 93);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(44, 13);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_fullName);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.gv_stds);
            this.Controls.Add(this.btn_students);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gv_stds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_students;
        private System.Windows.Forms.DataGridView gv_stds;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_fullName;
        private System.Windows.Forms.Label lbl_address;
    }
}

