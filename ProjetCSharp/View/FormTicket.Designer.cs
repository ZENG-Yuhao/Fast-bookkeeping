namespace ProjetCSharp.View
{
    partial class FormTicket
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
            this.chckLBox_articles = new System.Windows.Forms.CheckedListBox();
            this.txtbox_ticketName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_path = new System.Windows.Forms.TextBox();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.txtbox_modify_content = new System.Windows.Forms.TextBox();
            this.txtbox_modify_price = new System.Windows.Forms.TextBox();
            this.checkbox_modify = new System.Windows.Forms.CheckBox();
            this.chchLBox_payors = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_submit = new System.Windows.Forms.Label();
            this.checkbox_add = new System.Windows.Forms.CheckBox();
            this.txtbox_add_price = new System.Windows.Forms.TextBox();
            this.txtbox_add_content = new System.Windows.Forms.TextBox();
            this.btn_verify_add = new System.Windows.Forms.Button();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chckLBox_articles
            // 
            this.chckLBox_articles.BackColor = System.Drawing.Color.Orange;
            this.chckLBox_articles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chckLBox_articles.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckLBox_articles.FormattingEnabled = true;
            this.chckLBox_articles.Location = new System.Drawing.Point(505, 79);
            this.chckLBox_articles.Name = "chckLBox_articles";
            this.chckLBox_articles.Size = new System.Drawing.Size(469, 546);
            this.chckLBox_articles.TabIndex = 1;
            this.chckLBox_articles.SelectedIndexChanged += new System.EventHandler(this.chckLBox_articles_SelectedIndexChanged);
            // 
            // txtbox_ticketName
            // 
            this.txtbox_ticketName.BackColor = System.Drawing.Color.Orange;
            this.txtbox_ticketName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_ticketName.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ticketName.Location = new System.Drawing.Point(55, 71);
            this.txtbox_ticketName.Name = "txtbox_ticketName";
            this.txtbox_ticketName.Size = new System.Drawing.Size(224, 33);
            this.txtbox_ticketName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom du Ticket";
            // 
            // txtbox_path
            // 
            this.txtbox_path.BackColor = System.Drawing.Color.Orange;
            this.txtbox_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_path.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_path.Location = new System.Drawing.Point(55, 110);
            this.txtbox_path.Name = "txtbox_path";
            this.txtbox_path.ReadOnly = true;
            this.txtbox_path.Size = new System.Drawing.Size(296, 30);
            this.txtbox_path.TabIndex = 5;
            // 
            // btn_openFile
            // 
            this.btn_openFile.BackColor = System.Drawing.Color.Orange;
            this.btn_openFile.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.Location = new System.Drawing.Point(357, 110);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(87, 28);
            this.btn_openFile.TabIndex = 6;
            this.btn_openFile.Text = "Ouvrir";
            this.btn_openFile.UseVisualStyleBackColor = false;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // txtbox_modify_content
            // 
            this.txtbox_modify_content.BackColor = System.Drawing.Color.Orange;
            this.txtbox_modify_content.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_modify_content.Location = new System.Drawing.Point(597, 656);
            this.txtbox_modify_content.Name = "txtbox_modify_content";
            this.txtbox_modify_content.ReadOnly = true;
            this.txtbox_modify_content.Size = new System.Drawing.Size(154, 23);
            this.txtbox_modify_content.TabIndex = 9;
            this.txtbox_modify_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbox_modify_price
            // 
            this.txtbox_modify_price.BackColor = System.Drawing.Color.Orange;
            this.txtbox_modify_price.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_modify_price.Location = new System.Drawing.Point(770, 656);
            this.txtbox_modify_price.Name = "txtbox_modify_price";
            this.txtbox_modify_price.ReadOnly = true;
            this.txtbox_modify_price.Size = new System.Drawing.Size(154, 23);
            this.txtbox_modify_price.TabIndex = 10;
            this.txtbox_modify_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkbox_modify
            // 
            this.checkbox_modify.AutoSize = true;
            this.checkbox_modify.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_modify.Location = new System.Drawing.Point(499, 656);
            this.checkbox_modify.Name = "checkbox_modify";
            this.checkbox_modify.Size = new System.Drawing.Size(92, 26);
            this.checkbox_modify.TabIndex = 11;
            this.checkbox_modify.Text = "Modifier";
            this.checkbox_modify.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkbox_modify.UseVisualStyleBackColor = true;
            this.checkbox_modify.CheckStateChanged += new System.EventHandler(this.checkbox_modify_CheckStateChanged);
            // 
            // chchLBox_payors
            // 
            this.chchLBox_payors.BackColor = System.Drawing.Color.Orange;
            this.chchLBox_payors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chchLBox_payors.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chchLBox_payors.ForeColor = System.Drawing.Color.Black;
            this.chchLBox_payors.FormattingEnabled = true;
            this.chchLBox_payors.Location = new System.Drawing.Point(1026, 79);
            this.chchLBox_payors.Name = "chchLBox_payors";
            this.chchLBox_payors.Size = new System.Drawing.Size(387, 558);
            this.chchLBox_payors.TabIndex = 12;
            this.chchLBox_payors.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chckLBox_payors_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Articles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1020, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Propriétaire(s)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Orange;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 30);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lbl_submit
            // 
            this.lbl_submit.AutoSize = true;
            this.lbl_submit.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_submit.Location = new System.Drawing.Point(1241, 656);
            this.lbl_submit.Name = "lbl_submit";
            this.lbl_submit.Size = new System.Drawing.Size(143, 30);
            this.lbl_submit.TabIndex = 19;
            this.lbl_submit.Text = "> Enregistrer";
            this.lbl_submit.Click += new System.EventHandler(this.lbl_submit_Click);
            // 
            // checkbox_add
            // 
            this.checkbox_add.AutoSize = true;
            this.checkbox_add.Font = new System.Drawing.Font("Segoe Script", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_add.Location = new System.Drawing.Point(499, 682);
            this.checkbox_add.Name = "checkbox_add";
            this.checkbox_add.Size = new System.Drawing.Size(85, 26);
            this.checkbox_add.TabIndex = 22;
            this.checkbox_add.Text = "Ajouter";
            this.checkbox_add.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkbox_add.UseVisualStyleBackColor = true;
            this.checkbox_add.CheckStateChanged += new System.EventHandler(this.checkbox_add_CheckStateChanged);
            // 
            // txtbox_add_price
            // 
            this.txtbox_add_price.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_add_price.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_add_price.Location = new System.Drawing.Point(770, 682);
            this.txtbox_add_price.Name = "txtbox_add_price";
            this.txtbox_add_price.Size = new System.Drawing.Size(154, 23);
            this.txtbox_add_price.TabIndex = 21;
            this.txtbox_add_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbox_add_price.Visible = false;
            // 
            // txtbox_add_content
            // 
            this.txtbox_add_content.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_add_content.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_add_content.Location = new System.Drawing.Point(597, 682);
            this.txtbox_add_content.Name = "txtbox_add_content";
            this.txtbox_add_content.Size = new System.Drawing.Size(154, 23);
            this.txtbox_add_content.TabIndex = 20;
            this.txtbox_add_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbox_add_content.Visible = false;
            // 
            // btn_verify_add
            // 
            this.btn_verify_add.Font = new System.Drawing.Font("Segoe Print", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verify_add.Location = new System.Drawing.Point(930, 676);
            this.btn_verify_add.Name = "btn_verify_add";
            this.btn_verify_add.Size = new System.Drawing.Size(92, 28);
            this.btn_verify_add.TabIndex = 23;
            this.btn_verify_add.Text = "Valider";
            this.btn_verify_add.UseVisualStyleBackColor = true;
            this.btn_verify_add.Visible = false;
            this.btn_verify_add.Click += new System.EventHandler(this.btn_verify_add_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.Location = new System.Drawing.Point(1241, 696);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(102, 30);
            this.lbl_exit.TabIndex = 24;
            this.lbl_exit.Text = "> Fermer";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 525);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1462, 766);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.btn_verify_add);
            this.Controls.Add(this.checkbox_add);
            this.Controls.Add(this.txtbox_add_price);
            this.Controls.Add(this.txtbox_add_content);
            this.Controls.Add(this.lbl_submit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chchLBox_payors);
            this.Controls.Add(this.checkbox_modify);
            this.Controls.Add(this.txtbox_modify_price);
            this.Controls.Add(this.txtbox_modify_content);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.txtbox_path);
            this.Controls.Add(this.txtbox_ticketName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chckLBox_articles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTicket";
            this.Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chckLBox_articles;
        private System.Windows.Forms.TextBox txtbox_ticketName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_path;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.TextBox txtbox_modify_content;
        private System.Windows.Forms.TextBox txtbox_modify_price;
        private System.Windows.Forms.CheckBox checkbox_modify;
        private System.Windows.Forms.CheckedListBox chchLBox_payors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_submit;
        private System.Windows.Forms.CheckBox checkbox_add;
        private System.Windows.Forms.TextBox txtbox_add_price;
        private System.Windows.Forms.TextBox txtbox_add_content;
        private System.Windows.Forms.Button btn_verify_add;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}