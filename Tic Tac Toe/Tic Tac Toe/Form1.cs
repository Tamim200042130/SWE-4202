using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        
        public enum Player
        {
            X, O
        }

        Player currentPlayer; 

        List<Button> buttons; 
        Random rand = new Random(); 
        int playerWins = 0; 
        int computerWins = 0; 

        public Form1()
        {
            InitializeComponent();
            resetGame(); 
        }

        private void playerClick(object sender, EventArgs e)
        {
            Button button = (Button)sender; 
            currentPlayer = Player.X; 
            button.Text = currentPlayer.ToString(); 
            button.Enabled = false; 
            button.BackColor = System.Drawing.Color.Cyan; 
            buttons.Remove(button); 
            Check(); 
            AImoves.Start(); 
        }

        private void AImove(object sender, EventArgs e)
        {
            
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); 
                buttons[index].Enabled = false; 

                currentPlayer = Player.O; 
                buttons[index].Text = currentPlayer.ToString(); 
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon; 
                buttons.RemoveAt(index); 
                Check(); 
                AImoves.Stop(); 
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void loadbuttons()
        {
           
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8,button9};
        }
        


        private void resetGame()
        {
            
            foreach (Control X in this.Controls)
            {

                if (X is Button && X.Tag == "Play")

                {
                    ((Button)X).Enabled = true; 
                    ((Button)X).Text = "?"; 
                    ((Button)X).BackColor = default(Color); 
                }
            }

            loadbuttons(); 
        }
       

        private void Check()
        {

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {

                AImoves.Stop();
                MessageBox.Show("Player Wins!!!!");
                playerWins++;
                PlayerScore.Text = "Player Wins-  " + playerWins;
                resetGame();
            }

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {


                AImoves.Stop();
                MessageBox.Show("Computer Wins!!!!");
                computerWins++;
                ComputerScore.Text = "Computer Wins -  " + computerWins;
                resetGame();
            }

            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWins = 0;
            PlayerScore.Text = "Player Wins-  " + playerWins;
            computerWins = 0;
            ComputerScore.Text = "Computer Wins -  " + computerWins;
            resetGame();
            MessageBox.Show("New Game!!!");

        }

        

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Game is made by ''Mohammad Tamim Ibn Hossain''\nIslamic University of Technology\nSofware Engineering\nID NO:200042130");
        }
    }
}
