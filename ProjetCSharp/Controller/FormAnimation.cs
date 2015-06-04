using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCSharp.Controller
{
    public class FormAnimation
    {
        private Form form;
        private Timer timerForLoading, timerForClosing, timerForHiding;
        private const int interval_time = 20;
        private const float interval_opacity = 0.08F;
        public FormAnimation(Form form)
        {
            this.form = form;
            form.Opacity = 0;
            timerForLoading = new Timer();
            timerForLoading.Interval = interval_time;
            timerForLoading.Tick += new System.EventHandler(loading_Tick);

            timerForClosing = new Timer();
            timerForClosing.Interval = interval_time;
            timerForClosing.Tick += new System.EventHandler(closing_Tick);

            timerForHiding = new Timer();
            timerForHiding.Interval = interval_time;
            timerForHiding.Tick += new System.EventHandler(hiding_Tick);

            form.Load += new System.EventHandler(LoadingEvent);
            form.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ClosingEvent);
        }

        private void LoadingEvent(Object sender, EventArgs e)
        {
            form.Opacity = 0;
            form.Show();
            timerForLoading.Start();
        }


        private void ClosingEvent(Object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //Annuler la fermeture de la fenetre.
            form.Opacity = 1;
            timerForClosing.Start();

        }


        private void loading_Tick(object sender, EventArgs e)
        {
            Timer currentTimer = (Timer)sender;
            form.Opacity += interval_opacity;
            if (form.Opacity >= 1)
            {
                currentTimer.Stop();
            }
        }

        private void closing_Tick(object sender, EventArgs e)
        {
            Timer currentTimer = (Timer)sender;
            form.Opacity -= interval_opacity;
            if (form.Opacity <= 0)
            {
                //Car ClosingEvent va annuler la fermeture de la fenêtre, si on veut ferme la fenêtre, il faut enlever cet événement.
                form.FormClosing -= ClosingEvent;
                currentTimer.Stop();
                form.Close(); 
            }
        }

        private void hiding_Tick(object sender, EventArgs e)
        {
            Timer currentTimer = (Timer)sender;
            form.Opacity -= interval_opacity;
            if (form.Opacity <= 0)
            {
                currentTimer.Stop();
                form.Hide();
            }
        }


        //Vu qu'il n'y a pas de événement qui corresponds à Form.Show(), pour ajouter l'animation pour méthode .Show(), on invoke encore une fois la méthode Load().
        public void Show()
        {
            LoadingEvent(null, null);
        }

        public void Hide()
        {
            form.Opacity = 1;
            timerForHiding.Start();
        }
    }

}
