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
    public partial class Form1 : Form
    {
        public Form1()
        {
            DBConnection.conn.Open();

            InitializeComponent();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT PlayerId, CONCAT(P.FIRSTNAME, ', ', P.LASTNAME) AS Name FROM NBA.Player P ORDER BY P.LastName", DBConnection.conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
                
            uxLookup.DataSource = dtbl;
            uxLookup.DisplayMember = "Name";
            uxLookup.ValueMember = "PlayerId";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.conn.Close();
        }

        private void uxLookupPlayer_Click(object sender, EventArgs e)
        {
            int playerId = (int)uxLookup.SelectedValue;
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT P.FirstName, P.LastName, P.CurrentTeam, P.Position FROM NBA.Player P WHERE P.PlayerId = @playerId", DBConnection.conn); //todo add more col
            sqlDa.SelectCommand.Parameters.AddWithValue("@playerId", playerId);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            string firstName = (string)dtbl.Rows[0].ItemArray[0];
            string lastName = (string)dtbl.Rows[0].ItemArray[1];
            string currentTeam = (string)dtbl.Rows[0].ItemArray[2];
            string position = (string)dtbl.Rows[0].ItemArray[3];

            ViewPlayer viewPlayer = new ViewPlayer(playerId, firstName, lastName, currentTeam, position);
            viewPlayer.Show();

        }

        private void uxLookupGame_Click(object sender, EventArgs e)
        {
            ViewGame game = new ViewGame();
            game.Show();
        }

        private void uxLookupTeam_Click(object sender, EventArgs e)
        {
            ViewTeam team = new ViewTeam();
            team.Show();
        }

        private void uxAddEditPlayer_Click(object sender, EventArgs e)
        {
            AddEditPlayer player = new AddEditPlayer();
            player.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlusMinusDisplay plusMinusDisplay = new PlusMinusDisplay();
            plusMinusDisplay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PERLeaders perLeaders = new PERLeaders();
            perLeaders.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Matchups matchups = new Matchups();
            matchups.Show();
        }
    }
}