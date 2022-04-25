using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Week010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            DataTable dataHomeTeam = new DataTable();
            sqlQuery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataHomeTeam);
            comboBoxHomeTeam.DisplayMember = "Team Name";
            comboBoxHomeTeam.ValueMember = "Team ID";
            comboBoxHomeTeam.DataSource = dataHomeTeam;

            DataTable dataAwayTeam = new DataTable();
            sqlQuery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataAwayTeam);
            comboBoxAwayTeam.DisplayMember = "Team Name";
            comboBoxAwayTeam.ValueMember = "Team ID";
            comboBoxAwayTeam.DataSource = dataAwayTeam;
        }

        private void comboBoxHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataHomeManagerAndCaptain = new DataTable();
            sqlQuery = "SELECT manager.manager_name as `Manager Name`, player.player_name as `Captain Name` FROM team, player, manager WHERE team.captain_id = player.player_id AND manager.manager_id = team.manager_id AND team.team_id = '" + comboBoxHomeTeam.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataHomeManagerAndCaptain);
            labelHomeManager.Text = dataHomeManagerAndCaptain.Rows[0]["Manager Name"].ToString();
            labelHomeCaptain.Text = dataHomeManagerAndCaptain.Rows[0]["Captain Name"].ToString();

            DataTable Stadium = new DataTable();
            sqlQuery = "SELECT concat(home_stadium, ', ',team.city) as `Stadium`, capacity as `Capacity` FROM team WHERE team_id = '" + comboBoxHomeTeam.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Stadium);
            labelStadium.Text = Stadium.Rows[0]["Stadium"].ToString();
            labelCapacity.Text = Stadium.Rows[0]["Capacity"].ToString();
        }

        private void comboBoxAwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataAwayManagerAndCaptain = new DataTable();
            sqlQuery = "SELECT manager.manager_name as `Manager Name`, player.player_name as `Captain Name` FROM team, player, manager WHERE team.captain_id = player.player_id AND manager.manager_id = team.manager_id AND team.team_id = '" + comboBoxAwayTeam.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataAwayManagerAndCaptain);
            labelAwayManager.Text = dataAwayManagerAndCaptain.Rows[0]["Manager Name"].ToString();
            labelAwayCaptain.Text = dataAwayManagerAndCaptain.Rows[0]["Captain Name"].ToString();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DateAndScore = new DataTable();
                sqlQuery = "select date_format(match_date, '%e %M %Y') as `Tanggal`, concat(goal_home, '-', goal_away) as `Skor` from `match` where team_home = '" + comboBoxHomeTeam.SelectedValue.ToString() + "' and team_away = '" + comboBoxAwayTeam.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(DateAndScore);
                labelDate.Text = DateAndScore.Rows[0]["Date"].ToString();
                labelScore.Text = DateAndScore.Rows[0]["SCore"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Pertandingan antara kedua tim belum ada!");
            }
        }
    }
}
