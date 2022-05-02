using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserInterface
{
    public partial class ViewGame : Form
    {
        public int GameId;
        public ViewGame()
        {
            InitializeComponent();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT T.TeamId, T.TeamName FROM NBA.Team T", DBConnection.conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            uxAwaySelect.DataSource = dtbl;
            uxAwaySelect.DisplayMember = "TeamName";
            uxAwaySelect.ValueMember = "TeamId";

            SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT T.TeamId, T.TeamName FROM NBA.Team T", DBConnection.conn);
            DataTable dtbl1 = new DataTable();
            sqlDa1.Fill(dtbl1);

            uxHomeSelect.DataSource = dtbl1;
            uxHomeSelect.DisplayMember = "TeamName";
            uxHomeSelect.ValueMember = "TeamId";
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxDisplayButton_Click(object sender, EventArgs e)
        {
            ViewGameDisplay viewGameDisplay = new ViewGameDisplay(uxHomeSelect.Text, uxAwaySelect.Text, uxDateSelect.Text, (int)uxDateSelect.SelectedValue); // todo pass ids to constructor
            viewGameDisplay.Show();
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

                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT GameId, [Date] FROM NBA.Game G " +
                                                             $"WHERE G.HomeTeamId = @id1 " +
                                                             $"AND G.AwayTeamId = @id2", DBConnection.conn);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@id1", uxHomeSelect.SelectedValue);
                    sqlDa.SelectCommand.Parameters.AddWithValue("@id2", uxAwaySelect.SelectedValue);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    uxDateSelect.DataSource = dtbl;
                    uxDateSelect.DisplayMember = "Date";
                    uxDateSelect.ValueMember = "GameId";


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
