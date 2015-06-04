namespace ProjetCSharp.View
{
    partial class FormHistory
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
            this.lbl_exit = new System.Windows.Forms.Label();
            this.listBox_journals = new System.Windows.Forms.ListBox();
            this.listBox_participants = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_history = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.Location = new System.Drawing.Point(466, 571);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(102, 30);
            this.lbl_exit.TabIndex = 11;
            this.lbl_exit.Text = "> Fermer";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // listBox_journals
            // 
            this.listBox_journals.BackColor = System.Drawing.Color.Orchid;
            this.listBox_journals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_journals.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_journals.FormattingEnabled = true;
            this.listBox_journals.ItemHeight = 28;
            this.listBox_journals.Location = new System.Drawing.Point(54, 153);
            this.listBox_journals.Name = "listBox_journals";
            this.listBox_journals.Size = new System.Drawing.Size(406, 420);
            this.listBox_journals.TabIndex = 12;
            this.listBox_journals.SelectedIndexChanged += new System.EventHandler(this.listBox_journals_SelectedIndexChanged);
            this.listBox_journals.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_journals_MouseDoubleClick);
            // 
            // listBox_participants
            // 
            this.listBox_participants.BackColor = System.Drawing.Color.Orchid;
            this.listBox_participants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_participants.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_participants.FormattingEnabled = true;
            this.listBox_participants.ItemHeight = 28;
            this.listBox_participants.Location = new System.Drawing.Point(605, 153);
            this.listBox_participants.Name = "listBox_participants";
            this.listBox_participants.Size = new System.Drawing.Size(406, 420);
            this.listBox_participants.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Journals:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Participants:";
            // 
            // lbl_history
            // 
            this.lbl_history.AutoSize = true;
            this.lbl_history.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_history.Location = new System.Drawing.Point(421, 19);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(169, 57);
            this.lbl_history.TabIndex = 16;
            this.lbl_history.Text = "Histoire";
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1069, 636);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_participants);
            this.Controls.Add(this.listBox_journals);
            this.Controls.Add(this.lbl_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.ListBox listBox_journals;
        private System.Windows.Forms.ListBox listBox_participants;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_history;
    }
}