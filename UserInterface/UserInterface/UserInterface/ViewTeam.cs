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
    public partial class ViewTeam : Form
    {
        public ViewTeam()
        {
            InitializeComponent();

            SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT T.TeamId, T.TeamName, T.TeamAbbreviation FROM NBA.Team T ORDER BY T.TeamName", DBConnection.conn);
            DataTable dtbl1 = new DataTable();
            sqlDa1.Fill(dtbl1);

            uxTeamSelect.DataSource = dtbl1;
            uxTeamSelect.DisplayMember = "TeamName";
            uxTeamSelect.ValueMember = "TeamAbbreviation";
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
            SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT P.FirstName, P.LastName, P.Position FROM NBA.Player P WHERE P.CurrentTeam = @teamAbbr", DBConnection.conn);
            sqlDa1.SelectCommand.Parameters.AddWithValue("@teamAbbr", uxTeamSelect.SelectedValue);
            DataTable dtbl1 = new DataTable();
            sqlDa1.Fill(dtbl1);

            foreach (DataRow d in dtbl1.Rows)
            {
                string firstName = (string)d.ItemArray[0];
                string lastName = (string)d.ItemArray[1];
                string position = (string)d.ItemArray[2];

                ListViewItem item = new ListViewItem(firstName);
                item.SubItems.Add(lastName);
                item.SubItems.Add(position);

                uxPlayerRoster.Items.Add(item);
            }

            SqlDataAdapter sqlDa2 = new SqlDataAdapter(@"SELECT L.StadiumName, L.City, L.State, L.ZipCode FROM NBA.Team T
                                                         INNER JOIN NBA.Location L ON T.StadiumId = L.LocationId
                                                         WHERE T.TeamAbbreviation = @teamAbbr", DBConnection.conn);
            sqlDa2.SelectCommand.Parameters.AddWithValue("@teamAbbr", uxTeamSelect.SelectedValue);
            DataTable dtbl2 = new DataTable();
            sqlDa2.Fill(dtbl2);
            uxStadiumName.Text = (string)dtbl2.Rows[0].ItemArray[0];
            uxCityName.Text = (string)dtbl2.Rows[0].ItemArray[1];
            uxStateName.Text = (string)dtbl2.Rows[0].ItemArray[2];
            uxZipCode.Text = dtbl2.Rows[0].ItemArray[3].ToString();


            //query to display team

            //use .Text properties of these to display their information

            //uxStadiumName
            //uxCity
            //uxState
            //uxZipCode



        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
