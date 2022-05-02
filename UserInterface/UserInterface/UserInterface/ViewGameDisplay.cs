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
using System.Globalization;

namespace UserInterface
{
    public partial class ViewGameDisplay : Form
    {
        int homeScore;
        int awayScore;
        string homeTeamName;
        string awayTeamName;
        string date;
        string season;
        public ViewGameDisplay(string homeTeam, string awayTeam, string date, int gameId)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter(@"SELECT SUM(PointsScored), S.SeasonYear FROM NBA.GameTeamPlayer GTP 
                                                        INNER JOIN NBA.Team T ON T.TeamId = GTP.TeamId 
                                                        INNER JOIN NBA.Game G on G.GameId = GTP.GameId
                                                        INNER JOIN NBA.SeasonSchedule S on S.SeasonScheduleId = G.SeasonScheduleId 
                                                        WHERE GTP.GameId = @GameId 
                                                        AND T.TeamName = @teamName 
                                                        GROUP BY T.TeamId, S.SeasonYear", DBConnection.conn);
            sqlDa.SelectCommand.Parameters.AddWithValue("@gameId", gameId);
            sqlDa.SelectCommand.Parameters.AddWithValue("@teamName", homeTeam);
            DataTable homeDataTable = new DataTable();
            sqlDa.Fill(homeDataTable);

            SqlDataAdapter sqlDa1 = new SqlDataAdapter(@"SELECT SUM(PointsScored) FROM NBA.GameTeamPlayer GTP 
                                                        INNER JOIN NBA.Team T ON T.TeamId = GTP.TeamId 
                                                        WHERE GTP.GameId = @GameId 
                                                        AND T.TeamName = @teamName 
                                                        GROUP BY T.TeamId", DBConnection.conn);
            sqlDa1.SelectCommand.Parameters.AddWithValue("@gameId", gameId);
            sqlDa1.SelectCommand.Parameters.AddWithValue("@teamName", awayTeam);
            DataTable awayDataTable = new DataTable();
            sqlDa1.Fill(awayDataTable);
            homeScore = Convert.ToInt32(homeDataTable.Rows[0].ItemArray[0]);
            awayScore = Convert.ToInt32(awayDataTable.Rows[0].ItemArray[0]);
            season = (string)homeDataTable.Rows[0].ItemArray[1];
            date = date.Replace("+00:00", "-6:00");


            InitializeComponent();

            uxHomeTeamName.Text = homeTeam;
            uxAwayTeamName.Text = awayTeam;
            uxAwayTeamScore.Text = awayScore.ToString();
            uxHomeTeamScore.Text = homeScore.ToString();
            uxDatePlayed.Text = date;
            uxSeasonValue.Text = season;



        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
