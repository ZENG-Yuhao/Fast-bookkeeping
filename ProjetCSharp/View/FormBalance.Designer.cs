namespace ProjetCSharp.View
{
    partial class FormBalance
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
            this.listView_balance = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_balance
            // 
            this.listView_balance.BackColor = System.Drawing.Color.Green;
            this.listView_balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_balance.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_balance.Location = new System.Drawing.Point(105, 84);
            this.listView_balance.Name = "listView_balance";
            this.listView_balance.Size = new System.Drawing.Size(963, 507);
            this.listView_balance.TabIndex = 0;
            this.listView_balance.UseCompatibleStateImageBehavior = false;
            this.listView_balance.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Balance";
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.Location = new System.Drawing.Point(526, 611);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(102, 30);
            this.lbl_exit.TabIndex = 12;
            this.lbl_exit.Text = "> Fermer";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // FormBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1152, 665);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_balance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_exit;
    }
}