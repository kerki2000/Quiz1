namespace TestExam
{
    partial class FormRegister
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCountUsers = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(560, 447);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 42);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(805, 447);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(163, 42);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCountUsers
            // 
            this.btnCountUsers.Location = new System.Drawing.Point(560, 542);
            this.btnCountUsers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCountUsers.Name = "btnCountUsers";
            this.btnCountUsers.Size = new System.Drawing.Size(170, 42);
            this.btnCountUsers.TabIndex = 2;
            this.btnCountUsers.Text = "Count of Users";
            this.btnCountUsers.UseVisualStyleBackColor = true;
            this.btnCountUsers.Click += new System.EventHandler(this.btnCountUsers_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Location = new System.Drawing.Point(818, 542);
            this.btnDeleteUsers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(150, 42);
            this.btnDeleteUsers.TabIndex = 3;
            this.btnDeleteUsers.Text = "Delete Users";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(548, 111);
            this.txtFname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(456, 29);
            this.txtFname.TabIndex = 4;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(548, 216);
            this.txtLname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(456, 29);
            this.txtLname.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(548, 323);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(456, 29);
            this.txtPhone.TabIndex = 6;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(310, 116);
            this.lblFname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(123, 24);
            this.lblFname.TabIndex = 7;
            this.lblFname.Text = "First Name :";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(310, 230);
            this.lblLname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(120, 24);
            this.lblLname.TabIndex = 8;
            this.lblLname.Text = "Last Name :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(310, 328);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(193, 24);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Telephon Number :";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 831);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.btnDeleteUsers);
            this.Controls.Add(this.btnCountUsers);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnClear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCountUsers;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblPhone;
    }
}

