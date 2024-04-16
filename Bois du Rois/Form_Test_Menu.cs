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
    public partial class Form_Test_Menu : Form
    {
        public Form_Test_Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 138)
            {
                panel3.Height = 46;

            }
            else
            {
                panel3.Height = 138;
            }
        }

        private void Form_Test_Menu_Load(object sender, EventArgs e)
        {
            panel3.Height = 46;
        }

    }
}
