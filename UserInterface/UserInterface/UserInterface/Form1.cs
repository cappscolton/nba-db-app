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

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT PlayerId, CONCAT(P.FIRSTNAME, ', ', P.LASTNAME) AS Name FROM NBA.Player P", DBConnection.conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
                
            uxLookup.DataSource = dtbl;
            uxLookup.DisplayMember = "Name";
            uxLookup.ValueMember = "PlayerId";

            SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT S.SeasonScheduleId, S.SeasonYear FROM NBA.SeasonSchedule S", DBConnection.conn);
            DataTable dtbl1 = new DataTable();
            sqlDa1.Fill(dtbl1);

            comboBox2.DataSource = dtbl1;
            comboBox2.DisplayMember = "SeasonYear";
            comboBox2.ValueMember = "SeasonScheduleId";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.conn.Close();
        }

        private void uxLookupPlayer_Click(object sender, EventArgs e)
        {
            int playerId = (int)uxLookup.SelectedValue;
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT P.FirstName, P.LastName FROM NBA.Player P WHERE P.PlayerId = @playerId", DBConnection.conn); //todo add more col
            sqlDa.SelectCommand.Parameters.AddWithValue("@playerId", playerId);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            string firstName = (string)dtbl.Rows[0].ItemArray[0];
            string lastName = (string)dtbl.Rows[0].ItemArray[1];

            ViewPlayer viewPlayer = new ViewPlayer(playerId, firstName, lastName);
            viewPlayer.Show();

        }

        private void uxLookupGame_Click(object sender, EventArgs e)
        {
            ViewGame game = new ViewGame();
            game.Show();
        }
    }
}