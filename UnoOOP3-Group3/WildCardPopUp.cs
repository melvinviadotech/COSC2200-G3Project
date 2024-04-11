using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoOOP3_Group3
{
    public partial class WildCardPopUp : Form
    {
        public Boolean wildRedClicked = false;
        public Boolean wildBlueClicked = false; 
        public Boolean wildGreenClicked = false; 
        public Boolean wildYellowClicked = false;



        public WildCardPopUp()
        {
            InitializeComponent();
        }

        private void buttonWildRed_Click(object sender, EventArgs e)
        {
            wildRedClicked = true;
        }

        private void buttonWildBlue_Click(object sender, EventArgs e)
        {
            wildBlueClicked = true;
        }

        private void buttonWildGreen_Click(object sender, EventArgs e)
        {
            wildGreenClicked = true;
        }

        private void buttonWildYellow_Click(object sender, EventArgs e)
        {
            wildYellowClicked = true;
        }
    }
}
