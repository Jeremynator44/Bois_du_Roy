﻿using System;
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

        private void Bouton_Déroulant_Menu_Click(object sender, EventArgs e)
        {
            if (Menu.Height == 262)
            {
                Menu.Height = 89;
            }
            else
            {
                Menu.Height = 262;
            }
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Menu.Height = 89;
        }
    }
}
