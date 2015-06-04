using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetCSharp.Controller;
using ProjetCSharp.Model;
namespace ProjetCSharp.View
{
    public partial class FormLogin : Form
    {
        private Session session;
        private FormAnimation formAnimation;
        public FormLogin()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None; //enlever la barre de titre.
            txtbox_password.PasswordChar = '*';
            StartPosition = FormStartPosition.CenterScreen;

            //ajouter les nouvelles surveillances des événements de cette fenêtre pour déplacer la fenêtre par tirer le Form.
            new FormDragEvent(this);
            formAnimation = new FormAnimation(this);

            //ajouter les nouvelles surveillances des événements des étiquettes pour avoir une animation Zooming.

            new LabelMouseEvent(lbl_minimize);
            new LabelMouseEvent(lbl_exit);
            new LabelMouseEvent(lbl_login);
            new LabelMouseEvent(lbl_register);
        }

        private void Clear()
        {
            this.txtbox_email.Text = "";
            this.txtbox_password.Text = "";
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            login();
        }


        private void lbl_register_Click(object sender, EventArgs e)
        {
            FormRegister frmRegister = new FormRegister();
            //formAnimation.Hide();
            this.Hide();
            frmRegister.Owner = this;
            frmRegister.ShowDialog();
            //formAnimation.Show();
            this.Show();
        }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void login()
        {
            User usr = Program.db.UserDB.get(txtbox_email.Text);
            if (usr != null)
            {
                if (usr.Password == txtbox_password.Text)
                {
                    //Après avoir connecté, 
                    session = new Session(usr);
                    FormUser frmUser = new FormUser(session);
                    formAnimation.Hide();
                    frmUser.Owner = this;
                    frmUser.ShowDialog();
                    Clear();
                    formAnimation.Show();
                } else
                {
                    FormShakeEvent.shake(this);
                    MessageBox.Show("Mot de passe incorrect.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbox_password.Text = "";
                }
            } else
            {
                FormShakeEvent.shake(this);
                MessageBox.Show("Utilisateur non exist.", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_password.Text = "";
            }
        }
    }
}
