namespace ProjetCSharp.View
{
    partial class FormAddJournal
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
            this.checkedListBox_all_users = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_chosen_users = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_journal_name = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_add = new System.Windows.Forms.Label();
            this.lbl_remove = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_current_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox_all_users
            // 
            this.checkedListBox_all_users.BackColor = System.Drawing.Color.Green;
            this.checkedListBox_all_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_all_users.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_all_users.FormattingEnabled = true;
            this.checkedListBox_all_users.Location = new System.Drawing.Point(50, 137);
            this.checkedListBox_all_users.Name = "checkedListBox_all_users";
            this.checkedListBox_all_users.Size = new System.Drawing.Size(425, 496);
            this.checkedListBox_all_users.TabIndex = 1;
            // 
            // checkedListBox_chosen_users
            // 
            this.checkedListBox_chosen_users.BackColor = System.Drawing.Color.Green;
            this.checkedListBox_chosen_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_chosen_users.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_chosen_users.FormattingEnabled = true;
            this.checkedListBox_chosen_users.Location = new System.Drawing.Point(700, 137);
            this.checkedListBox_chosen_users.Name = "checkedListBox_chosen_users";
            this.checkedListBox_chosen_users.Size = new System.Drawing.Size(407, 496);
            this.checkedListBox_chosen_users.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du journal";
            // 
            // txtbox_journal_name
            // 
            this.txtbox_journal_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_journal_name.Location = new System.Drawing.Point(50, 72);
            this.txtbox_journal_name.Name = "txtbox_journal_name";
            this.txtbox_journal_name.Size = new System.Drawing.Size(224, 26);
            this.txtbox_journal_name.TabIndex = 0;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(342, 52);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(53, 22);
            this.lbl_date.TabIndex = 4;
            this.lbl_date.Text = "DATE";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(342, 81);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(26, 22);
            this.lbl_ID.TabIndex = 5;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add.Location = new System.Drawing.Point(533, 277);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(90, 25);
            this.lbl_add.TabIndex = 6;
            this.lbl_add.Text = "> Ajouter";
            this.lbl_add.Click += new System.EventHandler(this.lbl_add_Click);
            // 
            // lbl_remove
            // 
            this.lbl_remove.AutoSize = true;
            this.lbl_remove.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remove.Location = new System.Drawing.Point(533, 373);
            this.lbl_remove.Name = "lbl_remove";
            this.lbl_remove.Size = new System.Drawing.Size(93, 25);
            this.lbl_remove.TabIndex = 7;
            this.lbl_remove.Text = "Enlever <";
            this.lbl_remove.Click += new System.EventHandler(this.lbl_remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choisissez des participants:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Participants:";
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.Location = new System.Drawing.Point(1023, 9);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(84, 31);
            this.lbl_exit.TabIndex = 10;
            this.lbl_exit.Text = "Fermer";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(533, 587);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(120, 38);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Valider";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_current_user
            // 
            this.lbl_current_user.AutoSize = true;
            this.lbl_current_user.Font = new System.Drawing.Font("Segoe Print", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_user.Location = new System.Drawing.Point(832, 110);
            this.lbl_current_user.Name = "lbl_current_user";
            this.lbl_current_user.Size = new System.Drawing.Size(155, 24);
            this.lbl_current_user.TabIndex = 11;
            this.lbl_current_user.Text = "-Utilisateur présent:";
            // 
            // FormAddJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1171, 672);
            this.Controls.Add(this.lbl_current_user);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_remove);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txtbox_journal_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox_chosen_users);
            this.Controls.Add(this.checkedListBox_all_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddJournal";
            this.Text = "FormAddJournal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_all_users;
        private System.Windows.Forms.CheckedListBox checkedListBox_chosen_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_journal_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Label lbl_remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_current_user;
    }
}