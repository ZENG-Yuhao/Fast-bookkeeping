using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Le principe est de générer un déplacement prévu(un chiffre aléatoire) avec lequel on change la position de la fenêtre
 * chaque fois la fenêtre se déplace,  elle revient sa position initiale après.
 * Répéter les étapes ci-dessus plusieurs fois, il resemble que la fenêtre vibre.
 */

namespace ProjetCSharp.Controller
{
    public class FormShakeEvent
    {
        public static void shake(Object sender)
        {
            if (sender is Form)
            {
                Form frm = (Form)sender;
                const int rand = 10;
                int recordx = frm.Left;
                int recordy = frm.Top;
                Random random = new Random();
                for (int i = 0; i < 500; i++)
                {
                    int x = random.Next(rand);
                    int y = random.Next(rand);
                    if (x % 2 == 0)
                    {
                        frm.Left = frm.Left + x;
                    } else
                    {
                        frm.Left = frm.Left - x;
                    }
                    if (y % 2 == 0)
                    {
                        frm.Top = frm.Top + y;
                    } else
                    {
                        frm.Top = frm.Top - y;
                    }

                    frm.Left = recordx;
                    frm.Top = recordy;
                }
            } else
            {
                throw new Exception("Wrong Type");
            }
        }
    }
}
