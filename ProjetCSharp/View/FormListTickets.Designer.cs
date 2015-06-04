namespace ProjetCSharp.View
{
    partial class FormListTickets
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
            this.listView_tickets = new System.Windows.Forms.ListView();
            this.lbl_addTicket = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_tickets
            // 
            this.listView_tickets.BackColor = System.Drawing.Color.SteelBlue;
            this.listView_tickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_tickets.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_tickets.Location = new System.Drawing.Point(50, 89);
            this.listView_tickets.Name = "listView_tickets";
            this.listView_tickets.Size = new System.Drawing.Size(1076, 505);
            this.listView_tickets.TabIndex = 0;
            this.listView_tickets.UseCompatibleStateImageBehavior = false;
            this.listView_tickets.View = System.Windows.Forms.View.Details;
            this.listView_tickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_tickets_MouseDoubleClick);
            // 
            // lbl_addTicket
            // 
            this.lbl_addTicket.AutoSize = true;
            this.lbl_addTicket.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addTicket.Location = new System.Drawing.Point(518, 617);
            this.lbl_addTicket.Name = "lbl_addTicket";
            this.lbl_addTicket.Size = new System.Drawing.Size(108, 30);
            this.lbl_addTicket.TabIndex = 1;
            this.lbl_addTicket.Text = "> Ajouter";
            this.lbl_addTicket.Click += new System.EventHandler(this.lbl_addTicket_Click);
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(318, 617);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(110, 30);
            this.lbl_balance.TabIndex = 2;
            this.lbl_balance.Text = "> Balance";
            this.lbl_balance.Click += new System.EventHandler(this.lbl_balance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste des tickets";
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.Location = new System.Drawing.Point(721, 617);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(102, 30);
            this.lbl_exit.TabIndex = 5;
            this.lbl_exit.Text = "> Fermer";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // FormListTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1184, 680);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.lbl_addTicket);
            this.Controls.Add(this.listView_tickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListTickets";
            this.Text = "FormListTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_tickets;
        private System.Windows.Forms.Label lbl_addTicket;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_exit;
    }
}