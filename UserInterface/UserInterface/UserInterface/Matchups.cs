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
    public partial class Matchups : Form
    {
        public Matchups()
        {
            InitializeComponent();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT PlayerId, CONCAT(P.FIRSTNAME, ', ', P.LASTNAME) AS Name FROM NBA.Player P ORDER BY P.LastName", DBConnection.conn);
            DataTable dtbl = new DataTable();
            DataTable dtbl1 = new DataTable();
            sqlDa.Fill(dtbl);
            sqlDa.Fill(dtbl1);

            comboBox1.DataSource = dtbl;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "PlayerId";

            comboBox2.DataSource = dtbl1;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "PlayerId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null && comboBox2.SelectedValue != null)
            {
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "PlayerId";
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "PlayerId";
                SqlDataAdapter sqlDa = new SqlDataAdapter(@"SELECT FirstName, LastName, AVG(PointsScored) AS AveragePoints, AVG([Minutes]) AS AverageMinutes FROM NBA.GameTeamPlayer GTP
                                                        INNER JOIN NBA.Player P ON P.PlayerId = GTP.PlayerId
                                                        WHERE GTP.GameId IN
                                                            (
                                                            SELECT GameId FROM NBA.GameTeamPlayer GTP
                                                            WHERE GTP.PlayerId = @PlayerId1
                                                            INTERSECT
                                                            SELECT GameId FROM NBA.GameTeamPlayer GTP
                                                            WHERE GTP.PlayerId = @PlayerId2
                                                            )
                                                        AND (GTP.PlayerId=@PlayerId1 OR GTP.PlayerId=@PlayerId2)
                                                        GROUP BY GTP.PlayerId, FirstName, LastName", DBConnection.conn);
                sqlDa.SelectCommand.Parameters.AddWithValue("@PlayerId1", comboBox1.SelectedValue);
                sqlDa.SelectCommand.Parameters.AddWithValue("@PlayerId2", comboBox2.SelectedValue);
                DataTable dtbl1 = new DataTable();
                sqlDa.Fill(dtbl1);
                dataGridView1.DataSource = dtbl1;
            }
        }
    }
}
