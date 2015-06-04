using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCSharp.Controller
{
    public class FormDragEvent
    {
        private Point offset;
        private Point cur;
        private Form form;
        public FormDragEvent(Form form)
        {
            this.form = form;
            this.form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.form.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            /* Après avoir enlevé la barre de titre, on peut plus déplacer la fenêtre. Du coup il faut cette méthode + méthode MouseMove, 
             * pour qu'on puisse tirer la fenêtre en faissant  une clique gauche et une glisse de souris.
             * Lorsqu'on appuie le button clique à gauche de souris, cette méthode est appelée après on calcule la distance 'offset' entre 
             * la position de la fenêtre et la position du curseur.
             * Ce 'offset' sert à recalculer la correcte position de la fenêtre par rapport à la position de souris pendant le mouvement de 
             * souris dans la méthode MouseMove.
             */

            if (MouseButtons.Left != e.Button) return;
            cur = form.PointToScreen(e.Location);
            offset = new Point(cur.X - form.Left, cur.Y - form.Top);
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            //Lorsqu'on glisse le souris, (avec un button gauche de souris appruyé), on calcule la position de la fenêtre continuement.
            if (MouseButtons.Left != e.Button) return;
            cur = Control.MousePosition;
            form.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
    }
}
