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
        public bool wildRedClicked = false;
        public bool wildBlueClicked = false;
        public bool wildGreenClicked = false;
        public bool wildYellowClicked = false;



        public WildCardPopUp()
        {
            InitializeComponent();
        }

        private void buttonWildRed_Click(object sender, EventArgs e)
        {
            wildRedClicked = true;
            this.Close();
        }

        private void buttonWildBlue_Click(object sender, EventArgs e)
        {
            wildBlueClicked = true;
            this.Close();
        }

        private void buttonWildGreen_Click(object sender, EventArgs e)
        {
            wildGreenClicked = true;
            this.Close();
        }

        private void buttonWildYellow_Click(object sender, EventArgs e)
        {
            wildYellowClicked = true;
            this.Close();
        }
    }
}
