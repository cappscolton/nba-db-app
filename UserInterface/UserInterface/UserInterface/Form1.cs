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
        SqlConnection conn;
        public Form1()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog = NBA;Trusted_Connection=yes;";
            conn = new SqlConnection(connetionString);
            conn.Open();
            MessageBox.Show("Connection Open  !");
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void uxLookupPlayer_Click(object sender, EventArgs e)
        {
            using (conn)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM NBA.Player P WHERE P.PlayerId = 2544", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }
    }
}