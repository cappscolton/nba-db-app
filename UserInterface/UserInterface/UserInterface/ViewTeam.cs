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
    public partial class ViewTeam : Form
    {
        public ViewTeam()
        {
            InitializeComponent();
        }

        private void EnableSearchButton(object sender, EventArgs e)
        {
            if (uxTeamSelect.SelectedItem != null)
            {
                uxSearch.Enabled = true;
            }
        }

        private void uxSearch_Click(object sender, EventArgs e)
        {
            //query to display team

            //use .Text properties of these to display their information
            //uxStadiumName
            //uxCity
            //uxState
            //uxZipCode

            ListViewItem item = new ListViewItem("Paul");
            item.SubItems.Add("Jones");
            item.SubItems.Add("Forward");

            uxPlayerRoster.Items.Add(item);
            
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
