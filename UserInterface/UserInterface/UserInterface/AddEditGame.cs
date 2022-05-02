﻿using System;
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
    public partial class AddEditGame : Form
    {
        public AddEditGame()
        {
            InitializeComponent();

            //data context should be set for:
            //uxHomeSelect
            //uxAwaySelect
            //uxSeasonSelect??
        }

        private void uxComplete_Click(object sender, EventArgs e)
        {
            //Values for the queries will be stored in:
            //uxHomeSelect
            //uxAwaySelect
            //uxHomeScoreVal
            //uxAwayScoreVal
            //uxDateSelect
            //uxSeasonSelect
        }

        private void EnableCompleteButton(object sender, EventArgs e)
        {
            if(uxHomeSelect.SelectedItem != null && uxAwaySelect.SelectedItem != null && uxSeasonSelect.SelectedItem != null)
            {
                uxComplete.Enabled = true;
            }
        }
    }
}
