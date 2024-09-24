﻿namespace Pharmacy_Management_System
{
    partial class UC_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Profile));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuserRole = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(152, 545);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(273, 39);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Username";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(642, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Role";
            // 
            // txtuserRole
            // 
            this.txtuserRole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserRole.ForeColor = System.Drawing.Color.Black;
            this.txtuserRole.FormattingEnabled = true;
            this.txtuserRole.Items.AddRange(new object[] {
            "Adminstrator",
            "Pharmacist"});
            this.txtuserRole.Location = new System.Drawing.Point(645, 91);
            this.txtuserRole.Name = "txtuserRole";
            this.txtuserRole.Size = new System.Drawing.Size(340, 32);
            this.txtuserRole.TabIndex = 6;
            this.txtuserRole.SelectedIndexChanged += new System.EventHandler(this.txtuserRole_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(645, 182);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(340, 32);
            this.txtname.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.ForeColor = System.Drawing.Color.Black;
            this.txtDOB.Location = new System.Drawing.Point(645, 287);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(340, 32);
            this.txtDOB.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(642, 253);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(186, 23);
            this.label.TabIndex = 10;
            this.label.Text = "DOB(Date of Birth)";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.Color.Black;
            this.txtMobile.Location = new System.Drawing.Point(645, 400);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(340, 32);
            this.txtMobile.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(642, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mobile No";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(645, 492);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 32);
            this.txtEmail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(642, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(645, 579);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(340, 32);
            this.txtPassword.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(642, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(568, 663);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 43);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(839, 663);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(204, 43);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(606, 733);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(379, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "*Check details once again before click on update button";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtuserRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Profile";
            this.Size = new System.Drawing.Size(1077, 794);
            this.Load += new System.EventHandler(this.UC_Profile_Load);
            this.Enter += new System.EventHandler(this.UC_Profile_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtuserRole;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
