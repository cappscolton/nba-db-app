using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AddEditPlayer : Form
    {
        public AddEditPlayer()
        {
            InitializeComponent();
        }

        private void EnableCompleteButton(object sender, EventArgs e)
        {
            if (uxFirstName.Text.Length != 0 && uxLastName.Text.Length != 0)
            {
                uxAddPlayer.Enabled = true;
            }
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxAddPlayer_Click(object sender, EventArgs e)
        {
            //query for adding a new player to database
        }
    }
}
