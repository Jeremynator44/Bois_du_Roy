using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bois_du_Rois
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }
        bool menuDeroulant=false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuDeroulant == false) 
            {
                MenuDeroulant.Height += 10;
                if (MenuDeroulant.Height >= 248)
                {
                    menuTransition.Stop();
                    menuDeroulant = false;
                }
            }
            else
            {
                MenuDeroulant.Height -= 10;
                if (MenuDeroulant.Height <= 89) 
                {
                    menutransition.Stop();
                    menuDeroulant = false;
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
    }
}
