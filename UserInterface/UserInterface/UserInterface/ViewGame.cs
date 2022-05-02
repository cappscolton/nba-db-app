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
    public partial class ViewGame : Form
    {
        public ViewGame()
        {
            InitializeComponent();
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxDisplayButton_Click(object sender, EventArgs e)
        {
            //Query with the given information:
            //uxAwaySelect
            //uxHomeSelect
            //uxDateSelect
        }

        private void EnableFormControls(object sender, EventArgs e)
        {
            if(uxAwaySelect.SelectedItem != null && uxHomeSelect.SelectedItem != null)//if both teams are selected
            {
                uxAwaySelect.Enabled = false;
                uxHomeSelect.Enabled = false;

                if (uxDateSelect.Enabled == false)//enable date select if not already
                {
                    uxDateSelect.Enabled = true;
                }
                else//if date select is already enabled
                {
                    if(uxDateSelect.SelectedItem != null)//if the date is selected
                    {
                        uxDateSelect.Enabled = false;
                        uxDisplayButton.Enabled = true;//allow query through
                    }
                }
            }
        }

        private void RestoreDefaults(object sender, EventArgs e)
        {
            ViewGame newView = new ViewGame();
            newView.Show();
            this.Dispose(false);
        }
    }
}
