using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void italianbutton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buongiorno";
        }

        private void 西班牙button_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buenos dias";
        }

        private void 德國button_Click(object sender, EventArgs e)
                         
        {translateLabel.Text = "Guten Morgen";
            
        }
    }
}
