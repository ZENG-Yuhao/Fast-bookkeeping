namespace ProjetCSharp.View
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
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtBox_last_name = new System.Windows.Forms.TextBox();
            this.txtBox_first_name = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_error2 = new System.Windows.Forms.Label();
            this.lbl_error3 = new System.Windows.Forms.Label();
            this.lbl_error1 = new System.Windows.Forms.Label();
            this.lbl_error4 = new System.Windows.Forms.Label();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_error5 = new System.Windows.Forms.Label();
            this.txtBox_password2 = new System.Windows.Forms.TextBox();
            this.lbl_password2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_last_name.Location = new System.Drawing.Point(32, 98);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(61, 30);
            this.lbl_last_name.TabIndex = 0;
            this.lbl_last_name.Text = "Nom";
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_first_name.Location = new System.Drawing.Point(32, 165);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(93, 30);
            this.lbl_first_name.TabIndex = 1;
            this.lbl_first_name.Text = "Prénom";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(31, 31);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(174, 30);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email (Compte)";
            // 
            // txtBox_last_name
            // 
            this.txtBox_last_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_last_name.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_last_name.Location = new System.Drawing.Point(36, 124);
            this.txtBox_last_name.Name = "txtBox_last_name";
            this.txtBox_last_name.Size = new System.Drawing.Size(279, 29);
            this.txtBox_last_name.TabIndex = 1;
            // 
            // txtBox_first_name
            // 
            this.txtBox_first_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_first_name.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_first_name.Location = new System.Drawing.Point(36, 191);
            this.txtBox_first_name.Name = "txtBox_first_name";
            this.txtBox_first_name.Size = new System.Drawing.Size(279, 29);
            this.txtBox_first_name.TabIndex = 2;
            // 
            // txtBox_email
            // 
            this.txtBox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_email.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_email.Location = new System.Drawing.Point(36, 59);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(279, 29);
            this.txtBox_email.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(116, 392);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(106, 28);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Valider";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(116, 426);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(106, 28);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_error2
            // 
            this.lbl_error2.AutoSize = true;
            this.lbl_error2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error2.ForeColor = System.Drawing.Color.Red;
            this.lbl_error2.Location = new System.Drawing.Point(99, 104);
            this.lbl_error2.Name = "lbl_error2";
            this.lbl_error2.Size = new System.Drawing.Size(92, 17);
            this.lbl_error2.TabIndex = 8;
            this.lbl_error2.Text = "error message";
            // 
            // lbl_error3
            // 
            this.lbl_error3.AutoSize = true;
            this.lbl_error3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error3.ForeColor = System.Drawing.Color.Red;
            this.lbl_error3.Location = new System.Drawing.Point(130, 173);
            this.lbl_error3.Name = "lbl_error3";
            this.lbl_error3.Size = new System.Drawing.Size(92, 17);
            this.lbl_error3.TabIndex = 9;
            this.lbl_error3.Text = "error message";
            // 
            // lbl_error1
            // 
            this.lbl_error1.AutoSize = true;
            this.lbl_error1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error1.ForeColor = System.Drawing.Color.Red;
            this.lbl_error1.Location = new System.Drawing.Point(204, 39);
            this.lbl_error1.Name = "lbl_error1";
            this.lbl_error1.Size = new System.Drawing.Size(92, 17);
            this.lbl_error1.TabIndex = 10;
            this.lbl_error1.Text = "error message";
            // 
            // lbl_error4
            // 
            this.lbl_error4.AutoSize = true;
            this.lbl_error4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error4.ForeColor = System.Drawing.Color.Red;
            this.lbl_error4.Location = new System.Drawing.Point(178, 239);
            this.lbl_error4.Name = "lbl_error4";
            this.lbl_error4.Size = new System.Drawing.Size(92, 17);
            this.lbl_error4.TabIndex = 13;
            this.lbl_error4.Text = "error message";
            // 
            // txtBox_password
            // 
            this.txtBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_password.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_password.Location = new System.Drawing.Point(36, 257);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(279, 29);
            this.txtBox_password.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(32, 231);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(141, 30);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Mot de passe";
            // 
            // lbl_error5
            // 
            this.lbl_error5.AutoSize = true;
            this.lbl_error5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error5.ForeColor = System.Drawing.Color.Red;
            this.lbl_error5.Location = new System.Drawing.Point(34, 352);
            this.lbl_error5.Name = "lbl_error5";
            this.lbl_error5.Size = new System.Drawing.Size(92, 17);
            this.lbl_error5.TabIndex = 16;
            this.lbl_error5.Text = "error message";
            // 
            // txtBox_password2
            // 
            this.txtBox_password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_password2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_password2.Location = new System.Drawing.Point(36, 323);
            this.txtBox_password2.Name = "txtBox_password2";
            this.txtBox_password2.Size = new System.Drawing.Size(279, 29);
            this.txtBox_password2.TabIndex = 4;
            // 
            // lbl_password2
            // 
            this.lbl_password2.AutoSize = true;
            this.lbl_password2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password2.ForeColor = System.Drawing.Color.Black;
            this.lbl_password2.Location = new System.Drawing.Point(32, 297);
            this.lbl_password2.Name = "lbl_password2";
            this.lbl_password2.Size = new System.Drawing.Size(287, 30);
            this.lbl_password2.TabIndex = 14;
            this.lbl_password2.Text = "Confirmation mot de passe";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(353, 469);
            this.Controls.Add(this.lbl_error5);
            this.Controls.Add(this.txtBox_password2);
            this.Controls.Add(this.lbl_password2);
            this.Controls.Add(this.lbl_error4);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_error1);
            this.Controls.Add(this.lbl_error3);
            this.Controls.Add(this.lbl_error2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.txtBox_first_name);
            this.Controls.Add(this.txtBox_last_name);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_first_name);
            this.Controls.Add(this.lbl_last_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Text = "Nouvel Utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_last_name;
        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtBox_last_name;
        private System.Windows.Forms.TextBox txtBox_first_name;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_error2;
        private System.Windows.Forms.Label lbl_error3;
        private System.Windows.Forms.Label lbl_error1;
        private System.Windows.Forms.Label lbl_error4;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_error5;
        private System.Windows.Forms.TextBox txtBox_password2;
        private System.Windows.Forms.Label lbl_password2;
    }
}