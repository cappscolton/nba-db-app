using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AddEditPlayer : Form
    {
        private bool isEdit;
        private int playerId;
        public AddEditPlayer() // add constructor
        {
            isEdit = false;
            InitializeComponent();
        }

        public AddEditPlayer(int playerId, string firstName, string lastName, string team, string position) // edit constructor
        {
            isEdit = true;
            this.playerId = playerId;
            InitializeComponent();
            SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT T.TeamId, T.TeamAbbreviation FROM NBA.Team T", DBConnection.conn);
            DataTable dtbl1 = new DataTable();
            sqlDa1.Fill(dtbl1);
            uxTeamComboBox.DataSource = dtbl1;
            uxTeamComboBox.DisplayMember = "TeamAbbreviation";
            uxTeamComboBox.ValueMember = "TeamId";

            uxFirstName.Text = firstName;
            uxLastName.Text = lastName;
            uxPosition.Text = position;
            uxTeamComboBox.Text = team;
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
            if (isEdit)
            {
                SqlCommand sqlDa1 = new SqlCommand(@"UPDATE NBA.Player
                                                    SET 
                                                        FirstName = @firstName,
                                                        LastName = @lastName,
                                                        CurrentTeam = @currentTeam,
                                                        Position = @position
                                                    WHERE PlayerId = @playerId", DBConnection.conn);
                sqlDa1.Parameters.AddWithValue("@playerId", playerId);
                sqlDa1.Parameters.AddWithValue("@firstName", uxFirstName.Text);
                sqlDa1.Parameters.AddWithValue("@lastName", uxLastName.Text);
                sqlDa1.Parameters.AddWithValue("@currentTeam", uxTeamComboBox.Text);
                sqlDa1.Parameters.AddWithValue("@position", uxPosition.Text);
                DataTable dtbl1 = new DataTable();
                sqlDa1.ExecuteNonQuery();
            }
            
            else
            {
                SqlCommand sqlCo = new SqlCommand("INSERT NBA.Player(FirstName, LastName, CurrentTeam, Position) VALUES (@firstName, @lastName, @currentTeam, @position)", DBConnection.conn);
                sqlCo.Parameters.AddWithValue("@firstName", uxFirstName.Text);
                sqlCo.Parameters.AddWithValue("@lastName", uxLastName.Text);
                sqlCo.Parameters.AddWithValue("@currentTeam", uxTeamComboBox.Text);
                sqlCo.Parameters.AddWithValue("@position", uxPosition.Text);
                sqlCo.ExecuteNonQuery();
            }
        }
    }
}
