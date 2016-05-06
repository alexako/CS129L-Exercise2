using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamEx;
using Registration;

namespace Registration
{
    public partial class TeamMenu : Form
    {
        Team redTeam = new Team("Red Team", 5, 18, 30);
        Team blueTeam = new Team("Blue Team", 5, 18, 30);
        Team greenTeam = new Team("Green Team", 7, 10, 15);
        Team yellowTeam = new Team("Yellow Team", 7, 10, 15);

        member_input input = new member_input();
        
        public TeamMenu()
        {
            InitializeComponent();
            Team[] teams = new Team[] { redTeam, blueTeam, greenTeam, yellowTeam };
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            processMemberFor(redTeam);
            if (teamIsFull(redTeam))
                redButton.Enabled = false;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            processMemberFor(blueTeam);
            if (teamIsFull(blueTeam))
                blueButton.Enabled = false;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            processMemberFor(greenTeam);
            if (teamIsFull(greenTeam))
                greenButton.Enabled = false;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            processMemberFor(yellowTeam);
            if (teamIsFull(yellowTeam))
                yellowButton.Enabled = false;
        }

        public bool teamIsFull(Team team)
        {
            return team.memberCnt >= team.maxMember;
        }

        public void processMemberFor(Team team)
        {
            input.Text = "Joining " + team.name;

            if (input.ShowDialog() == DialogResult.OK)
            {
                Member member = new Member(input.MemberName.Text,
                    Convert.ToInt32(input.MemberAge.Text));
                if (team.CheckQualification(member))
                {
                    team.AddMember(member);
                    MessageBox.Show(
                        "Welcome to " + team.name + ", " + member.name + "!");
                }
                else
                    MessageBox.Show("Sorry, age qualification not met.");

                input.MemberName.ResetText();
                input.MemberAge.ResetText();
            }
        }

        private void showStatusButton_Click(object sender, EventArgs e)
        {
            string status = "Teams' Status:\n" +
                redTeam.name + ": " + redTeam.memberCnt + "\n" +
                blueTeam.name + ": " + blueTeam.memberCnt + "\n" +
                greenTeam.name + ": " + greenTeam.memberCnt + "\n" +
                yellowTeam.name + ": " + yellowTeam.memberCnt + "\n";

            MessageBox.Show(status);
        }
    }
}
