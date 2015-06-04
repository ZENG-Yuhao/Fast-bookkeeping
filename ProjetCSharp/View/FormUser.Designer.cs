namespace ProjetCSharp.View
{
    partial class FormUser
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
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.lbl_history = new System.Windows.Forms.Label();
            this.lbl_new_journal = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.Location = new System.Drawing.Point(79, 156);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(302, 76);
            this.lbl_user_name.TabIndex = 0;
            this.lbl_user_name.Text = "User Name";
            // 
            // lbl_history
            // 
            this.lbl_history.AutoSize = true;
            this.lbl_history.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_history.Location = new System.Drawing.Point(491, 405);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(182, 55);
            this.lbl_history.TabIndex = 2;
            this.lbl_history.Text = "Histoires";
            this.lbl_history.Click += new System.EventHandler(this.lbl_history_Click);
            // 
            // lbl_new_journal
            // 
            this.lbl_new_journal.AutoSize = true;
            this.lbl_new_journal.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_journal.Location = new System.Drawing.Point(404, 291);
            this.lbl_new_journal.Name = "lbl_new_journal";
            this.lbl_new_journal.Size = new System.Drawing.Size(348, 55);
            this.lbl_new_journal.TabIndex = 3;
            this.lbl_new_journal.Text = "Nouveau Journal";
            this.lbl_new_journal.Click += new System.EventHandler(this.lbl_new_journal_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.Location = new System.Drawing.Point(1023, 25);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(102, 30);
            this.lbl_exit.TabIndex = 4;
            this.lbl_exit.Text = "> Fermer";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(844, 25);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(157, 30);
            this.lbl_logout.TabIndex = 5;
            this.lbl_logout.Text = "> Déconnecter";
            this.lbl_logout.Click += new System.EventHandler(this.lbl_logout_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1162, 667);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.lbl_new_journal);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.lbl_user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Label lbl_history;
        private System.Windows.Forms.Label lbl_new_journal;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_logout;



    }
}