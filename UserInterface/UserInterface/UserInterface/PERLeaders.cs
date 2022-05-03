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
    public partial class PERLeaders : Form
    {
        Dictionary<string, string> seasonOptions;
        public PERLeaders()
        {
            InitializeComponent();

            seasonOptions = new Dictionary<string, string>();

            seasonOptions.Add("2019-22", "22019");
            seasonOptions.Add("2020-21", "22020");
            seasonOptions.Add("2021-22", "22021");
            seasonOptions.Add("All (2019-22)", "22021, 22022, 22019");
            uxSeasonComboBox.DataSource = new BindingSource(seasonOptions, null);
            uxSeasonComboBox.DisplayMember = "Key";
            uxSeasonComboBox.ValueMember = "Value";
        }

    private void uxSeasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (uxSeasonComboBox.SelectedIndex == 3)
        {
            SqlDataAdapter sqlDa2 = new SqlDataAdapter(@"SELECT FirstName, LastName, Stats * 1.00000 / CONVERT(DECIMAL(10,5), TotalMinutes) AS LinearPER FROM 
                                                        (
                                                            SELECT * FROM 
                                                            (
                                                                SELECT P.FirstName, P.LastName, 
                                                                SUM(GTP.FGM) * 85.910 + 
                                                                SUM(Steals) *  53.897 
                                                                + SUM(FG3M) * 51.757 
                                                                + SUM(FTM) * 46.845 
                                                                + SUM(BLOCKS) * 39.190
                                                                + SUM(OREB) * 39.190 
                                                                + SUM(Assists) * 34.677 
                                                                + SUM(DREB) * 14.707 
                                                                - SUM(Fouls) * 17.174 
                                                                - SUM(FTA-FTM) * 20.091 
                                                                - SUM(FGA-FGM) * 39.190 
                                                                - SUM(Turnovers) * 53.897 AS Stats, 
                                                                SUM([Minutes]) AS TotalMinnutes FROM NBA.GameTeamPlayer GTP
                                                                INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
                                                                INNER JOIN NBA.Game G ON GTP.GameId = G.GameId
                                                                WHERE G.SeasonScheduleId IN ('22021', '22022', '22019')
                                                                GROUP BY P.FirstName, P.LastName
                                                            ) AS MyTable (FirstName, LastName, Stats, TotalMinutes)
                                                            WHERE TotalMinutes > 20

                                                        ) AS FilteredPlayers
                                                    ORDER BY LinearPER DESC", DBConnection.conn);
            DataTable dtbl2 = new DataTable();
            sqlDa2.Fill(dtbl2);
            dataGridView1.DataSource = dtbl2;
        }
        else
        {
            SqlDataAdapter sqlDa1 = new SqlDataAdapter(@"SELECT FirstName, LastName, Stats * 1.00000 / CONVERT(DECIMAL(10,5), TotalMinutes) AS LinearPER FROM 
                                                        (
                                                            SELECT * FROM 
                                                            (
                                                                SELECT P.FirstName, P.LastName, 
                                                                SUM(GTP.FGM) * 85.910 + 
                                                                SUM(Steals) *  53.897 
                                                                + SUM(FG3M) * 51.757 
                                                                + SUM(FTM) * 46.845 
                                                                + SUM(BLOCKS) * 39.190
                                                                + SUM(OREB) * 39.190 
                                                                + SUM(Assists) * 34.677 
                                                                + SUM(DREB) * 14.707 
                                                                - SUM(Fouls) * 17.174 
                                                                - SUM(FTA-FTM) * 20.091 
                                                                - SUM(FGA-FGM) * 39.190 
                                                                - SUM(Turnovers) * 53.897 AS Stats, 
                                                                SUM([Minutes]) AS TotalMinnutes FROM NBA.GameTeamPlayer GTP
                                                                INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
                                                                INNER JOIN NBA.Game G ON GTP.GameId = G.GameId
                                                                WHERE G.SeasonScheduleId = @seasonScheduleId
                                                                GROUP BY P.FirstName, P.LastName
                                                            ) AS MyTable (FirstName, LastName, Stats, TotalMinutes)
                                                            WHERE TotalMinutes > 20

                                                        ) AS FilteredPlayers
                                                    ORDER BY LinearPER DESC", DBConnection.conn);
            sqlDa1.SelectCommand.Parameters.AddWithValue("@seasonScheduleId", ((KeyValuePair<string, string>)uxSeasonComboBox.SelectedItem).Value);
            DataTable dtbl1 = new DataTable();
            sqlDa1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
        }
    }

    private void uxExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
}
