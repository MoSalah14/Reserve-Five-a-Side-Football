using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserve__a_Five_a_Side_Football
{
    public partial class AddYourTeam : Form
    {
        private int count = 1;
        //private int playerCount = 1;
        private HashSet<string> playerIDs = new HashSet<string>();

        public AddYourTeam()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddYourTeam_Load(object sender, EventArgs e)
        {
            UpdateCountLabel();
        }

        private void UpdateCountLabel()
        {
            countLabel.Text = $" {count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerID = inputTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(playerID))
            {
                if (!playerIDs.Contains(playerID))
                {
                    playerIDs.Add(playerID);
                    MessageBox.Show($"player {count} added successfully!");
                    count++;
                    UpdateCountLabel();
                    //MessageBox.Show($"player {count} added successfully!");
                    // countLabel.Text = playerIDs.Count.ToString();

                    if (playerIDs.Count == 5)
                    {
                        MessageBox.Show("Team added successfully!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Player ID already exists. Please enter a unique ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a player ID.");
            }

            

        }
    }
}
