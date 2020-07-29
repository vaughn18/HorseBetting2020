using HorseBetting2020.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace HorseBetting2020
{
    public partial class Form1 : Form
    {

        //instantiate game mechanics class
        Game game = new Game();

        //error checking class and error message
        InputHandler errorCheck = new InputHandler();
        string errorMsg;

        public Form1()
        {
            InitializeComponent();
            //Load Racers and put in front end list
            Racer[] racer= game.LoadRacers(pbSonic, pbMinato, pbMonkey, pbCt);
            foreach(Racer character in racer)
            {
                racerList.Items.Add(character.Name);
            }


            //Load Punters Method
            lblWinner = game.LoadPunters(lblWinner)[0].LabelWinner;

            //load punter wallets
            declanWallet.Text = game.LoadPunters(lblWinner)[0].Cash.ToString();
            gerardWallet.Text = game.LoadPunters(lblWinner)[1].Cash.ToString();
            alienWallet.Text = game.LoadPunters(lblWinner)[2].Cash.ToString();

            //winner text invisible at the start
            lblWinner.Visible = false;
            btnNextRace.Visible = false;
            pnlTrack.BringToFront();

            //disable bet button until punter is selected
            btnBet.Enabled = false;
        }

        //Function to start the race
        private void btnRunRace_Click(object sender, EventArgs e)
        {
            //the distance for the racers to run
            int distance = Form1.ActiveForm.Width - pbSonic.Width - 30;

            btnRunRace.Enabled = false;
            btnBet.Enabled = false;
            if (game.runRace(false, Form1.ActiveForm.Width - pbSonic.Width - 30) != "Error")
            {
                //set the winner label to empty as the race starts
                lblWinner.Text = " ";
                while (lblWinner.Text == " ")
                {
                    foreach (string msg in game.FindWinner(game.runRace(false, distance)))
                    {
                        gameConsole.Items.Add(msg);
                    }

                    lblWinner.Visible = true;
                    lblWinner.BringToFront();
                    lblWinner.Text = game.runRace(false, distance);

                }
            }
            //show the button based on the result of the game
            List<string> reset = game.RaceReset(double.Parse(declanWallet.Text), double.Parse(gerardWallet.Text), double.Parse(alienWallet.Text), lblWinner);

            declanBet.Text = reset[0];
            declanWallet.Text = reset[1];

            gerardBet.Text = reset[2];
            gerardWallet.Text = reset[3];

            alienBet.Text = reset[4];
            alienWallet.Text = reset[5];

            btnNextRace.Text = reset[6];

            btnNextRace.Visible = true;
            btnNextRace.BringToFront();
        }


        //Choosing your punter
        private void Radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton tmpBtn = (RadioButton)sender;
            lblPunter.Text = tmpBtn.Text + "'s ";
            btnBet.Enabled = true;

            //update wallet and maximum bet input depending on punter
                    switch (tmpBtn.Text)
                    {
                        //loads the total amount of cash the punters currently have
                        case "Declan the Engager":
                            declanWallet.Text = game.punterSelect(tmpBtn.Text);
                    betInput.Maximum = decimal.Parse(game.punterSelect(tmpBtn.Text));
                    break;
                        case "Gerard the Grey":
                            gerardWallet.Text = game.punterSelect(tmpBtn.Text);
                    betInput.Maximum = decimal.Parse(game.punterSelect(tmpBtn.Text));
                    break;
                        case "Alien of the Unknown":
                            alienWallet.Text = game.punterSelect(tmpBtn.Text);
                    betInput.Maximum = decimal.Parse(game.punterSelect(tmpBtn.Text));
                    break;
                    }

            betInput.Value = betInput.Maximum;
        }


        //Placing the punters bets
        private void btnBet_Click(object sender, EventArgs e)
        {
            //calling the function and assign to a variable to keep code shorter
            List<string> betInfo = game.AssignBets(racerList.Text, betInput.Value);

            //checks the input given before placing bets
            errorMsg = errorCheck.isBetSuccess(betInfo[2], decimal.Parse(betInfo[1]), betInfo[0], decimal.Parse(betInfo[3]));



            if (errorMsg == null)
            {
                    switch (betInfo[2])
                    {
                        //loads their bet and racer into front end
                        case "Declan the Engager":
                        declanBet.Text = betInfo[1];
                        declanRacer.Text = betInfo[0];
                        rbtnDeclan.Enabled = false;
                        break;
                        case "Gerard the Grey":
                        gerardBet.Text = betInfo[1];
                        gerardRacer.Text = betInfo[0];
                        rbtnGerard.Enabled = false;
                        break;
                        case "Alien of the Unknown":
                        alienBet.Text = betInfo[1];
                        alienRacer.Text = betInfo[0];
                        rbtnAlien.Enabled = false;
                        break;
                    }

                //update game console
                gameConsole.Items.Add(betInfo[2] + " has placed " + "$ " + betInfo[1].ToString() + " on " + betInfo[0]);

                //disable bet button to prevent betting 2 times
                btnBet.Enabled = false;

            }
            else
            {
                MessageBox.Show(errorMsg);
            }

        }

        private void btnNextRace_Click(object sender, EventArgs e)
        {
            //call reset function in a variable to make code shorter
            List<string> reset = game.RaceReset(double.Parse(declanWallet.Text), double.Parse(gerardWallet.Text), double.Parse(alienWallet.Text), lblWinner);

            declanBet.Text = reset[0];
            declanWallet.Text = reset[1];

            gerardBet.Text = reset[2];
            gerardWallet.Text = reset[3];

            alienBet.Text = reset[4];
            alienWallet.Text = reset[5];

            btnNextRace.Text = reset[6];


            //restart the race and the bets
            btnNextRace.Visible = false;
            lblWinner.Visible = false;
            pnlTrack.BringToFront();

            //clear the list box or the game console
            gameConsole.Items.Clear();

            //reset radio button selections
            rbtnAlien.Checked = false;
            rbtnDeclan.Checked = false;
            rbtnGerard.Checked = false;
            rbtnAlien.Enabled = true;
            rbtnDeclan.Enabled = true;
            rbtnGerard.Enabled = true;

            //Load Racers and put in front end list
            pbSonic.Location = new Point(2, 11);
            pbMinato.Location = new Point(2, 15);
            pbMonkey.Location = new Point(0, 2);
            pbCt.Location = new Point(2, 6);


            btnRunRace.Enabled = true;

        }
    }
}
