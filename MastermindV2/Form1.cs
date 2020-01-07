using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MastermindV2
{
    enum Gamemode
    {
        single,
        multi
    }

    enum Turn
    {
        player1,
        player2
    }


    public partial class Form1 : Form
    {
        

        #region variables
        static List<GuessControl> guessList = new List<GuessControl>(); //list of the guess controls
        static int count = 0; //count of the amount of guesses
        public static List<Color> colors = new List<Color>(); //the colours to be guessed of game
        public static List<Color> colors2 = new List<Color>(); //the colours to be guessed of game for player2
        static GuessControl playerColours = new GuessControl(); //this control sets colours for player1 and show colours after game has ended
        static GuessControl player2Colours = new GuessControl(); //this control sets colours for player2 and show colours after the game has ended
        static Turn turn = new Turn(); //manage the guesses of the players turns
        static Gamemode gamemode = new Gamemode(); //to distinguish gamemode
        public static bool colorSet = false; //to stop guess control from checking colours when settings the players colours in multiplay for playerColours controls
        static bool playerWon = false; //to flag that player1 has won and that player 2 has 1 guess left
        #endregion


        public Form1()
        {
            InitializeComponent();
            playerColours.button1.Click += SetPlayerColours;
            player2Colours.button1.Click += SetPlayerColours;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding the placeholder control to the form (in 2 player mode this is used to set the opponents colours)
            playerColours.Location = new Point(12, 20);
            player2Colours.Location = new Point(542, 20);
            this.Controls.Add(playerColours);
            this.Controls.Add(player2Colours);
            //disable the right colour right position and right colour wrong position boxes and check button for placeholder control as they arnt necessary
            playerColours.rrBox.Visible = false;
            playerColours.rwBox.Visible = false;
            playerColours.button1.Visible = false;
            playerColours.Enabled = false;

            player2Colours.rrBox.Visible = false;
            player2Colours.rwBox.Visible = false;
            player2Colours.button1.Visible = false;
            player2Colours.Enabled = false;
            //add all the guesscontrols to a list for easier way to reset the game and manage the controls
            guessList.Add(guessControl1);
            guessList.Add(guessControl2);
            guessList.Add(guessControl3);
            guessList.Add(guessControl4);
            guessList.Add(guessControl5);
            guessList.Add(guessControl6);
            guessList.Add(guessControl7);
            guessList.Add(guessControl8);
            guessList.Add(guessControl9);
            guessList.Add(guessControl10);
            guessList.Add(guessControl11);
            guessList.Add(guessControl12);
            guessList.Add(guessControl13);
            guessList.Add(guessControl14);
            guessList.Add(guessControl15);
            guessList.Add(guessControl16);
            guessList.Add(guessControl17);
            guessList.Add(guessControl18);
            guessList.Add(guessControl19);
            guessList.Add(guessControl20);
            gamemode = Gamemode.single;
            resetGame();
        }

        private static void resetGame()
        {
            if (gamemode == Gamemode.single)
            {
                turn = Turn.player1;
                colorSet = false;
                playerColours.button1.Visible = false;
                playerColours.Visible = true;
                DisableControl(playerColours);
                HideColours();
                count = 0;//reset turns taken
                colors.Clear(); //reset colors to be guessed
                //hide all of the controls but the first one so it doesnt appear to flash when game is reset
                for (int i = 1; i < 10;i++ )
                {
                    resetControl(guessList[i]);
                }
                clearControl(guessList[0]);

                setColours(); //set the colours to be guessed
                EnableControl(guessList[count]);//set the first guess control visible
            }
            //2player mode
            else
            {
                colorSet = true; //stops playercolours control from checking colours when setting players colours
                HideColours();
                turn = Turn.player1;
                playerWon = false;
                
                playerColours.Visible = false;
                EnableControl(player2Colours);
                player2Colours.button1.Visible = true;
                player2Colours.button1.Text = "Set";
                count = 0;//reset turns taken
                colors.Clear(); //reset colors to be guessed
                colors2.Clear();
                //hide all of the controls
                foreach (GuessControl gc in guessList)
                {
                    resetControl(gc);
                }
                MessageBox.Show("Player1 set player2's colours.\nPlayer2 look away!", "Set Colours", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //method for settings the colours for both players in multiplayer mode
        void SetPlayerColours(object sender, EventArgs e)
        {
            if (turn == Turn.player1)
            {
                if (ValidateControl(player2Colours))
                {
                    colors2.Add(player2Colours.color1.BackColor);
                    colors2.Add(player2Colours.color2.BackColor);
                    colors2.Add(player2Colours.color3.BackColor);
                    colors2.Add(player2Colours.color4.BackColor);
                    turn = Turn.player2;
                    //hide player2 colors
                    clearControl(player2Colours);

                    player2Colours.button1.Visible = false;
                    DisableControl(player2Colours);

                    playerColours.button1.Text = "Set";
                    
                    playerColours.Visible = true;

                    EnableControl(playerColours);

                }
                ResetColourControlSetColour();
                MessageBox.Show("Player2 set player1's colours.\nPlayer1 look away!", "Set Colours", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ValidateControl(playerColours))
                {
                    colors.Add(playerColours.color1.BackColor);
                    colors.Add(playerColours.color2.BackColor);
                    colors.Add(playerColours.color3.BackColor);
                    colors.Add(playerColours.color4.BackColor);
                    turn = Turn.player1;
                    //hide player 1 colours
                    clearControl(playerColours);
                    DisableControl(playerColours);
                    playerColours.button1.Visible = false;
                    player2Colours.Visible = true;
                    EnableControl(guessList[count]);
                    ResetColourControlSetColour();
                    colorSet = false;
                }
            }
        }

        private void ResetColourControlSetColour()
        {
            
            Button b = new Button();
            colourControl1.button9.BackColor = b.BackColor;
        }

        private bool ValidateControl(GuessControl ctrl)
        {
            if (ctrl.color1.BackColor == SystemColors.Control)
            {
                return false;
            }

            if (ctrl.color2.BackColor == SystemColors.Control)
            {
                return false;
            }

            if (ctrl.color3.BackColor == SystemColors.Control)
            {
                return false;
            }

            if (ctrl.color4.BackColor == SystemColors.Control)
            {
                return false;
            }

            return true;
        }

        //set the colours of the game to be guessed
        private static void setColours()
        {
            while(colors.Count<4) //while there isnt four colours keep generating random colour to fill list
            {
                Color c = GetColor();//random a colour
                if(!colors.Contains(c))//if list of colours doesnt contain randomly generated color add it to list
                {
                    colors.Add(c);
                }
            }
        }

        private static void clearControl(GuessControl gc)
        {
            gc.color1.BackColor = SystemColors.Control;
            gc.color2.BackColor = SystemColors.Control;
            gc.color3.BackColor = SystemColors.Control;
            gc.color4.BackColor = SystemColors.Control;
            gc.button1.Visible = true;
            gc.Enabled = true;
            gc.rrBox.Text = "";
            gc.rwBox.Text = "";
            gc.colours.Clear();
        }

        private static void resetControl(GuessControl gc)
        {
            gc.Visible = false;
            gc.color1.BackColor = SystemColors.Control;
            gc.color2.BackColor = SystemColors.Control;
            gc.color3.BackColor = SystemColors.Control;
            gc.color4.BackColor = SystemColors.Control;
            gc.button1.Visible = true;
            gc.Enabled = true;
            gc.rrBox.Text = "";
            gc.rwBox.Text = "";
            gc.colours.Clear();
        }

        //get a random colour
        private static Color GetColor()
        {
            Color c = new Color();

            Random r = new Random();
            int num = r.Next(1,9);

            if (num == 1)
            {
                c = Color.Red;
            }

            else if (num == 2)
            {
                c = Color.Green;
            }

            else if (num == 3)
            {
                c = Color.Blue;
            }

            else if (num == 4)
            {
                c = Color.Yellow;
            }

            else if (num == 5)
            {
                c = Color.Purple;
            }

            else if (num == 6)
            {
                c = Color.Orange;
            }

            else if (num == 7)
            {
                c = Color.Pink;
            }

            else if (num == 8)
            {
                c = Color.Brown;
            }

            return c;

        }

        //fill rw and rr boxes with info (rw:rightcolour right position|rw:rightcolour wrong position)
        private static void GetGuessInfo(GuessControl ctrl)
        {
            int rr = 0;
            int rw = 0;
            List<Color> colors = new List<Color>();
            if(turn == Turn.player1)
            {
                colors = Form1.colors;
            }
            else
            {
                colors = colors2;
            }
                for (int i = 0; i <= 3; i++)
                {
                    if (ctrl.colours[i] == colors[i]) //if the colour in this position matches the colour in guessing colours same position add to right count
                    {
                        rr++;
                    }
                    else if (colors.Contains(ctrl.colours[i])) //if the guessing colours contains the colour in the guess control add to right colour wrong position
                    {
                        rw++;
                    }
                }
                ctrl.rrBox.Text = rr.ToString();
                ctrl.rwBox.Text = rw.ToString();
            
        }

        //show colours to be guessed
        public static void ShowColours()
        {
            playerColours.color1.BackColor = colors[0];
            playerColours.color2.BackColor = colors[1];
            playerColours.color3.BackColor = colors[2];
            playerColours.color4.BackColor = colors[3];
            if (gamemode == Gamemode.multi)
            {
                player2Colours.color1.BackColor = colors2[0];
                player2Colours.color2.BackColor = colors2[1];
                player2Colours.color3.BackColor = colors2[2];
                player2Colours.color4.BackColor = colors2[3];
            }
        }

        public static void ShowColours(int player)
        {
            if(player == 1)
            {
                playerColours.color1.BackColor = colors[0];
                playerColours.color2.BackColor = colors[1];
                playerColours.color3.BackColor = colors[2];
                playerColours.color4.BackColor = colors[3];
            }
            else
            {
                player2Colours.color1.BackColor = colors2[0];
                player2Colours.color2.BackColor = colors2[1];
                player2Colours.color3.BackColor = colors2[2];
                player2Colours.color4.BackColor = colors2[3];
            }
        }

        //hide colours to be guessed
        public static void HideColours()
        {
            playerColours.color1.BackColor = SystemColors.Control;
            playerColours.color2.BackColor = SystemColors.Control;
            playerColours.color3.BackColor = SystemColors.Control;
            playerColours.color4.BackColor = SystemColors.Control;

            player2Colours.color1.BackColor = SystemColors.Control;
            player2Colours.color2.BackColor = SystemColors.Control;
            player2Colours.color3.BackColor = SystemColors.Control;
            player2Colours.color4.BackColor = SystemColors.Control;
        }

        //disable control
        private static void DisableControl(GuessControl ctrl)
        {
            ctrl.color1.Enabled = false;
            ctrl.color2.Enabled = false;
            ctrl.color3.Enabled = false;
            ctrl.color4.Enabled = false;
            ctrl.button1.Visible = false;
        }

        private static void EnableControl(GuessControl ctrl)
        {
            ctrl.Enabled = true;
            ctrl.Visible = true;
            ctrl.color1.Enabled = true;
            ctrl.color2.Enabled = true;
            ctrl.color3.Enabled = true;
            ctrl.color4.Enabled = true;
            ctrl.button1.Visible = true;
        }

        //checks each guess
        public static void CheckGuess(GuessControl ctrl)
        {
            if (gamemode == Gamemode.single)
            {
                GetGuessInfo(ctrl);
                if (CheckWin(ctrl))//game is won
                {
                    DisableControl(ctrl);
                    ShowColours();
                    DialogResult result = MessageBox.Show("Congratulations you won!\nWould you like to play again?", "Play again?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        resetGame();
                    }
                    else
                    {
                        result = MessageBox.Show("Would you like to quit?", "Quit", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                else//game is not won
                {
                    if (count < 9)//if havnt used all guesses
                    {
                        DisableControl(ctrl);
                        count++;
                        EnableControl(guessList[count]);
                    }
                    else//used all guesses
                    {
                        ShowColours();
                        DialogResult result = MessageBox.Show("You have lost.\nWould you like to play again?", "Play again?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            resetGame();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            else // game is multiplayer
            {
                GetGuessInfo(ctrl);
                if (CheckWin(ctrl) | playerWon == true)//game is won
                {
                    DisableControl(ctrl);
                    
                    if(turn == Turn.player1)//if player 1 won
                    {
                        ShowColours(1);//show player1s colours
                        playerWon = true; //set flag that player1 has won
                        turn = Turn.player2; //set turn to player2
                        EnableControl(guessList[count + 10]); //show player2's last guess control
                        return;
                    }
                    else //player2 won
                    {
                        if(playerWon == false) //if player1 flag wasnt true then player2 won
                        {
                            ShowColours();
                            DialogResult result = MessageBox.Show("Congratulations Player 2 you win!\nWould you like to play again?", "Play again?", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                resetGame();
                            }
                            else
                            {
                                result = MessageBox.Show("Would you like to quit?", "Quit", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    Application.Exit();
                                }
                                else
                                {
                                    return;
                                }
                            }
                        }
                        else//player1 already won check to see if player2 tied game
                        {
                            if (CheckWin(ctrl)) //if player 2 won as well as player1
                            {
                                ShowColours();
                                DialogResult result = MessageBox.Show("Its a tie!\nPlay again?", "Play again?", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    resetGame();
                                }
                                else
                                {
                                    result = MessageBox.Show("Would you like to quit?", "Quit", MessageBoxButtons.YesNo);
                                    if (result == DialogResult.Yes)
                                    {
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            }
                            else //player 2 didnt win and player 1 did
                            {
                                ShowColours();
                                DialogResult result = MessageBox.Show("Congratulations Player 1 you win!\nWould you like to play again?", "Play again?", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    resetGame();
                                }
                                else
                                {
                                    result = MessageBox.Show("Would you like to quit?", "Quit", MessageBoxButtons.YesNo);
                                    if (result == DialogResult.Yes)
                                    {
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
                

                else//game is not won
                {
                    if (count < 9 || turn == Turn.player1 & count == 9)//if havnt used all guesses
                    {
                        DisableControl(ctrl);
                        if (turn == Turn.player1)
                        {
                            turn = Turn.player2;//set turn to player2
                            EnableControl(guessList[count + 10]);
                            
                        }
                        else
                        {
                            count++;
                            turn = Turn.player1;//set turn to player1
                            EnableControl(guessList[count]);
                        }
                    }
                    else//used all guesses
                    {
                        ShowColours();
                        DialogResult result = MessageBox.Show("Its a tie nobody wins.\nWould you like to play again?", "♦♣♠♥", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            resetGame();
                        }
                        else
                        {
                            result = MessageBox.Show("Do you want to quit?", "Quit game?", MessageBoxButtons.YesNo);
                            if(result == DialogResult.Yes)
                            {
                                resetGame();
                            }
                        }
                    }
                }
            }
        }

        static bool CheckWin(GuessControl ctrl)
        {
            //if all colours are the same its win
            List<Color> colors = new List<Color>();
            if(turn == Turn.player1)
            {
                colors = Form1.colors;
            }
            else
            {
                colors = colors2;
            }

            if(ctrl.color1.BackColor == colors[0] && ctrl.color2.BackColor == colors[1] && ctrl.color3.BackColor == colors[2] && ctrl.color4.BackColor == colors[3])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 561;
            this.CenterToScreen();
            gamemode = Gamemode.single;
            colourControl1.button9.BackColor = new Button().BackColor;
            resetGame();
        }

        private void playerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 1012;
            this.CenterToScreen();
            gamemode = Gamemode.multi;
            colourControl1.button9.BackColor = new Button().BackColor;
            resetGame();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f.Name == "frmAbout")
                {
                    f.Focus();
                    return;
                }

            }
            frmAbout frm = new frmAbout();
            frm.Show();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmHowToPlay")
                {
                    f.Focus();
                    return;
                }

            }
            frmHowToPlay frm = new frmHowToPlay();
            frm.Show();
        }

        #region paintbackground
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Gray, Color.Black, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        #endregion
    }
}
