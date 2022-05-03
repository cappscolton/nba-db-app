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
    public partial class PlusMinusDisplay : Form
    {
        Dictionary<string, string> seasonOptions;
        public PlusMinusDisplay()
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
                SqlDataAdapter sqlDa2 = new SqlDataAdapter(@"SELECT FirstName, LastName, SUM(PlusMinus) SumPlusMinus FROM NBA.GameTeamPlayer GTP
                                                        INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
                                                        INNER JOIN NBA.Game G ON G.GameId = GTP.GameId
                                                        WHERE G.SeasonScheduleId IN (22021, 22022, 22019)
                                                        GROUP BY GTP.PlayerId, FirstName, LastName
                                                        ORDER BY SumPlusMinus DESC", DBConnection.conn);
                DataTable dtbl2 = new DataTable();
                sqlDa2.Fill(dtbl2);
                dataGridView1.DataSource = dtbl2;
            }
            else
            {
                SqlDataAdapter sqlDa1 = new SqlDataAdapter(@"SELECT FirstName, LastName, SUM(PlusMinus) SumPlusMinus FROM NBA.GameTeamPlayer GTP
                                                        INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
                                                        INNER JOIN NBA.Game G ON G.GameId = GTP.GameId
                                                        WHERE G.SeasonScheduleId IN (@seasonScheduleId)
                                                        GROUP BY GTP.PlayerId, FirstName, LastName
                                                        ORDER BY SumPlusMinus DESC", DBConnection.conn);
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
