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
    public partial class AddEditGame : Form
    {
        bool isEdit = false;
        int gameId;
        SqlDataAdapter dgvAdapter;
        DataTable dgvDataTable;
        public AddEditGame()
        {
            InitializeComponent();


            //data context should be set for:
            //uxHomeSelect
            //uxAwaySelect
            //uxSeasonSelect??
        }

        public AddEditGame(string homeTeam, string awayTeam, string date, int gameId)
        {
            isEdit = true;
            this.gameId = gameId;
            InitializeComponent();
            //set up data context here

            uxComplete.Enabled = true;

            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT S.SeasonScheduleId, S.SeasonYear AS Name FROM NBA.SeasonSchedule S", DBConnection.conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            uxSeasonSelect.DataSource = dtbl;
            uxSeasonSelect.DisplayMember = "SeasonYear";
            uxSeasonSelect.ValueMember = "SeasonScheduleId";


            SqlDataAdapter sqlDa1 = new SqlDataAdapter(@"SELECT GTP.GameTeamPlayerId, P.PlayerId, P.FirstName, P.LastName, GTP.PointsScored, GTP.PlusMinus, GTP.Minutes, GTP.FGM,
                                                        GTP.FGA, GTP.FG3M, GTP.FG3A, GTP.FTM, GTP.FTA, GTP.OREB, GTP.DREB,
								                        GTP.Assists, GTP.Turnovers, GTP.Blocks, GTP.Fouls, T.TeamAbbreviation FROM NBA.GameTeamPlayer GTP
                                                         INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
                                                         INNER JOIN NBA.Team T ON T.TeamId = GTP.TeamId
                                                         WHERE GTP.GameId = @gameId", DBConnection.conn);
            sqlDa1.SelectCommand.Parameters.AddWithValue("@gameId", gameId);
            DataTable dtbl1 = new DataTable();
            sqlDa1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
            dataGridView1.Columns["GameTeamPlayerId"].Visible = false;
            dataGridView1.Columns["PlayerId"].Visible = false;
            dgvAdapter = sqlDa1;
            dgvDataTable = dtbl1;

            SqlDataAdapter sqlDa2 = new SqlDataAdapter(@"SELECT G.Date FROM NBA.GameTeamPlayer GTP
                                                         INNER JOIN NBA.Game G ON G.GameId = GTP.GameId
                                                         WHERE GTP.GameId = @gameId", DBConnection.conn);
            sqlDa2.SelectCommand.Parameters.AddWithValue("@gameId", gameId);
            DataTable dtbl2 = new DataTable();
            sqlDa2.Fill(dtbl2);
            uxDateSelect.Text = dtbl2.Rows[0].ItemArray[0].ToString().Replace("+00:00", "-6:00");
            ;


        }

        private void uxComplete_Click(object sender, EventArgs e)
        {
            if(isEdit)
            {
                DataRow[] test = dgvDataTable.Select();
                foreach (DataRow dr in test)
                {
                    SqlDataAdapter sqlDa2 = new SqlDataAdapter(@"SELECT P.PlayerId FROM NBA.Player P
                                                                    WHERE P.FirstName = @firstName
                                                                    AND P.LastName = @lastName", DBConnection.conn);
                    sqlDa2.SelectCommand.Parameters.AddWithValue("@firstName", dr.ItemArray[2]);
                    sqlDa2.SelectCommand.Parameters.AddWithValue("@lastName", dr.ItemArray[3]);
                    DataTable dtbl2 = new DataTable();
                    sqlDa2.Fill(dtbl2);
                    int playerId = (int)dtbl2.Rows[0].ItemArray[0];

                    SqlDataAdapter sqlDa3 = new SqlDataAdapter(@"SELECT T.TeamId FROM NBA.Team T
                                                                    WHERE T.TeamAbbreviation = @teamAbbr", DBConnection.conn);
                    sqlDa3.SelectCommand.Parameters.AddWithValue("@teamAbbr", dr.ItemArray[19]);
                    DataTable dtbl3 = new DataTable();
                    sqlDa3.Fill(dtbl3);
                    int teamId = (int)dtbl3.Rows[0].ItemArray[0];

                    if (dr.RowState.Equals(DataRowState.Added))
                    {
                        SqlCommand sqlCo = new SqlCommand(@"INSERT NBA.GameTeamPlayer(GameId, TeamId, PlayerId, PointsScored, PlusMinus,
								[Minutes], FGM, FGA, FG3M, FG3A, FTM, FTA, OREB, DREB,
								Assists, Turnovers, Blocks, Fouls) 
                                                            VALUES (@gameId, @teamId, @playerId, @PointsScored, @PlusMinus,
								@Minutes, @FGM, @FGA, @FG3M, @FG3A, @FTM, @FTA, @OREB, @DREB,
								@Assists, @Turnovers, @Blocks, @Fouls)", DBConnection.conn);
                        sqlCo.Parameters.AddWithValue("@gameId", gameId);
                        sqlCo.Parameters.AddWithValue("@teamId", teamId);
                        sqlCo.Parameters.AddWithValue("@playerId", playerId);
                        sqlCo.Parameters.AddWithValue("@PointsScored", dr.ItemArray[4]);
                        sqlCo.Parameters.AddWithValue("@PlusMinus", dr.ItemArray[5]);
                        sqlCo.Parameters.AddWithValue("@Minutes", dr.ItemArray[6]);
                        sqlCo.Parameters.AddWithValue("@FGM", dr.ItemArray[7]);
                        sqlCo.Parameters.AddWithValue("@FGA", dr.ItemArray[8]);
                        sqlCo.Parameters.AddWithValue("@FG3M", dr.ItemArray[9]);
                        sqlCo.Parameters.AddWithValue("@FG3A", dr.ItemArray[10]);
                        sqlCo.Parameters.AddWithValue("@FTM", dr.ItemArray[11]);
                        sqlCo.Parameters.AddWithValue("@FTA", dr.ItemArray[12]);
                        sqlCo.Parameters.AddWithValue("@OREB", dr.ItemArray[13]);
                        sqlCo.Parameters.AddWithValue("@DREB", dr.ItemArray[14]);
                        sqlCo.Parameters.AddWithValue("@Assists", dr.ItemArray[15]);
                        sqlCo.Parameters.AddWithValue("@Turnovers", dr.ItemArray[16]);
                        sqlCo.Parameters.AddWithValue("@Blocks", dr.ItemArray[17]);
                        sqlCo.Parameters.AddWithValue("@Fouls", dr.ItemArray[18]);
                        sqlCo.ExecuteNonQuery();
                    }
                    if (dr.RowState.Equals(DataRowState.Modified))
                    {
                        SqlCommand sqlDa1 = new SqlCommand(@"UPDATE NBA.GameTeamplayer
                                                    SET 
                                                        PlayerId = @playerId,
                                                        TeamId = @teamId,
                                                        PointsScored = @PointsScored,
                                                        PlusMinus = @PlusMinus,
                                                        Minutes = @Minutes,
                                                        FGM = @FGM,
                                                        FGA = @FGA,
                                                        FG3M = @FG3M,
                                                        FG3A = @FG3A,
                                                        FTM = @FTM,
                                                        FTA = @FTA,
                                                        OREB = @OREB,
                                                        DREB = @DREB,
                                                        Assists = @Assists,
                                                        Turnovers = @Turnovers,
                                                        Blocks = @Blocks,
                                                        Fouls = @Fouls                                                      
                                                    WHERE GameTeamPlayerId = @gameTeamPlayerId", DBConnection.conn);
                        sqlDa1.Parameters.AddWithValue("@gameTeamPlayerId", dr.ItemArray[0]);
                        sqlDa1.Parameters.AddWithValue("@teamId", teamId);
                        sqlDa1.Parameters.AddWithValue("@playerId", playerId);
                        sqlDa1.Parameters.AddWithValue("@PointsScored", dr.ItemArray[4]);
                        sqlDa1.Parameters.AddWithValue("@PlusMinus", dr.ItemArray[5]);
                        sqlDa1.Parameters.AddWithValue("@Minutes", dr.ItemArray[6]);
                        sqlDa1.Parameters.AddWithValue("@FGM", dr.ItemArray[7]);
                        sqlDa1.Parameters.AddWithValue("@FGA", dr.ItemArray[8]);
                        sqlDa1.Parameters.AddWithValue("@FG3M", dr.ItemArray[9]);
                        sqlDa1.Parameters.AddWithValue("@FG3A", dr.ItemArray[10]);
                        sqlDa1.Parameters.AddWithValue("@FTM", dr.ItemArray[11]);
                        sqlDa1.Parameters.AddWithValue("@FTA", dr.ItemArray[12]);
                        sqlDa1.Parameters.AddWithValue("@OREB", dr.ItemArray[13]);
                        sqlDa1.Parameters.AddWithValue("@DREB", dr.ItemArray[14]);
                        sqlDa1.Parameters.AddWithValue("@Assists", dr.ItemArray[15]);
                        sqlDa1.Parameters.AddWithValue("@Turnovers", dr.ItemArray[16]);
                        sqlDa1.Parameters.AddWithValue("@Blocks", dr.ItemArray[17]);
                        sqlDa1.Parameters.AddWithValue("@Fouls", dr.ItemArray[18]);
                        sqlDa1.ExecuteNonQuery();
                    }
                }
                this.Close();//close out of the form (method terminates)
            }
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
