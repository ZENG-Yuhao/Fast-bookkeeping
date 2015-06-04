using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCSharp.Controller
{
    //Lorsque le cursor entre dans la cadre de label, on augemente la taille de la police, et la fait en gris.
    //les méthodes peuvent être registées dans MouseEvent du label
    public class LabelMouseEvent
    {
        //les fonts par default
        private Label label;
        private Font font_Enter;
        private Font font_Leave;

        public LabelMouseEvent(Label label)
        {
            this.label = label;
            this.font_Leave = new Font(label.Font.Name, label.Font.Size, label.Font.Style);
            this.font_Enter = new Font(label.Font.Name, label.Font.Size + 2, FontStyle.Bold);
            this.label.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.label.MouseLeave += new System.EventHandler(this.mouseLeave);
        }

        private void mouseEnter(Object sender, EventArgs e)
        {
            label.Font = font_Enter;
        }

        private void mouseLeave(Object sender, EventArgs e)
        {
            label.Font = font_Leave;
        }
    }
}
