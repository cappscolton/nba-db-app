using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public partial class ViewPlayer : Form
    {
        private Button uxEditPlayer;
        private Button uxExit;
        private Label lastNameLabel;
        private Label uxFirstName;
        private Label uxLastName;
        private Label label1;
        private Label uxTeam;
        private Label firstNameLabel;
        private Label label2;
        private Label label3;
        private Label uxPosition;
        private int playerId;

        public ViewPlayer(int playerId, string firstName, string lastName, string currentTeam, string position)
        {
            InitializeComponent();
            this.playerId = playerId;
            uxFirstName.Text = firstName;
            uxLastName.Text = lastName;
            uxTeam.Text = currentTeam;
            uxPosition.Text = position;
        }

        private void InitializeComponent()
        {
            this.uxEditPlayer = new System.Windows.Forms.Button();
            this.uxExit = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.uxFirstName = new System.Windows.Forms.Label();
            this.uxLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxTeam = new System.Windows.Forms.Label();
            this.uxPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxEditPlayer
            // 
            this.uxEditPlayer.Location = new System.Drawing.Point(112, 133);
            this.uxEditPlayer.Name = "uxEditPlayer";
            this.uxEditPlayer.Size = new System.Drawing.Size(148, 23);
            this.uxEditPlayer.TabIndex = 11;
            this.uxEditPlayer.Text = "Edit Information";
            this.uxEditPlayer.UseVisualStyleBackColor = true;
            this.uxEditPlayer.Click += new System.EventHandler(this.uxEditPlayer_Click);
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(31, 133);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(75, 23);
            this.uxExit.TabIndex = 10;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(31, 49);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 15);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(31, 15);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(67, 15);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            // 
            // uxFirstName
            // 
            this.uxFirstName.AutoSize = true;
            this.uxFirstName.Location = new System.Drawing.Point(115, 16);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(38, 15);
            this.uxFirstName.TabIndex = 12;
            this.uxFirstName.Text = "label1";
            // 
            // uxLastName
            // 
            this.uxLastName.AutoSize = true;
            this.uxLastName.Location = new System.Drawing.Point(113, 48);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(38, 15);
            this.uxLastName.TabIndex = 13;
            this.uxLastName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Team:";
            // 
            // uxTeam
            // 
            this.uxTeam.AutoSize = true;
            this.uxTeam.Location = new System.Drawing.Point(112, 79);
            this.uxTeam.Name = "uxTeam";
            this.uxTeam.Size = new System.Drawing.Size(38, 15);
            this.uxTeam.TabIndex = 15;
            this.uxTeam.Text = "label2";
            // 
            // uxPosition
            // 
            this.uxPosition.AutoSize = true;
            this.uxPosition.Location = new System.Drawing.Point(112, 105);
            this.uxPosition.Name = "uxPosition";
            this.uxPosition.Size = new System.Drawing.Size(38, 15);
            this.uxPosition.TabIndex = 17;
            this.uxPosition.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 104);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Position";
            // 
            // ViewPlayer
            // 
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.uxPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.uxEditPlayer);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "ViewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void uxEditPlayer_Click(object sender, EventArgs e)
        {
            AddEditPlayer addEditPlayer = new AddEditPlayer(playerId, uxFirstName.Text, uxLastName.Text, uxTeam.Text, uxPosition.Text);
            addEditPlayer.Show();
            this.Close();
        }
    }
}
