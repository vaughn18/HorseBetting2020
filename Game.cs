using HorseBetting2020.Business;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace HorseBetting2020
{
    public class Game
    {
        //initialise an array for the racers
        Racer[] racer = new Racer[4];

        //Punter array
        Punter[] punter = new Punter[3];

        //winner of the race
        private string raceWinner;

        //current punter chosen
        Punter currentPunter;



        //Load the Racers
        public Racer[] LoadRacers(PictureBox pbSonic, PictureBox pbMinato, PictureBox pbMonkey, PictureBox pbCt)
        {
            racer[0] = new Racer { Length = 0, Img = pbSonic, Name = "Sonic" };
            racer[0].Img.Image = Properties.Resources.sonicStand;
            racer[1] = new Racer { Length = 0, Img = pbMinato, Name = "Minato" };
            racer[1].Img.Image = Properties.Resources.minato;
            racer[2] = new Racer { Length = 0, Img = pbMonkey, Name = "Monkey" };
            racer[2].Img.Image = Properties.Resources.monkey;
            racer[3] = new Racer { Length = 0, Img = pbCt, Name = "Counter-Terrorist" };
            racer[3].Img.Image = Properties.Resources.ctGun;

            return racer;

        }

        //Load Punters
        public List<Punter> LoadPunters(Label lblWinner)
        {
            List<Punter> punterInfo = new List<Punter>();

            for (int i = 0; i < 3; i++)
            {

                punter[i] = Factory.GetAPunter(i);
                punter[i].LabelWinner = lblWinner;
                punterInfo.Add(punter[i]);
            }
            return punterInfo;
        }

        //Run Race 
        public string runRace(bool end, int distance)
        {
            var myrand = new Random();

            while (end != true)
            {

                for (int i = 0; i < racer.Length; i++)
                {
                    Thread.Sleep(3);
                    racer[i].Img.Left += myrand.Next(1, 10);

                    if (racer[i].Img.Left > distance)
                    {
                        end = true;
                        raceWinner = racer[i].Name;
                    }
                }

            }

            //when the race ends return the winner
            if(end == true)
            {
                return raceWinner + " wins";
            }
            return null;

        }


        //find a winner function then return a list of messages to show the result of the game
        public List<string> FindWinner(string winner)
        {
            List<string> consoleMessages = new List<string>();

            for (int i = 0; i < punter.Length; i++)
            {
 if(punter[i].Racer != winner)
                {
                    punter[i].Cash -= punter[i].Bet;

                    //update match results to game console (list box)
                    consoleMessages.Add(punter[i].PunterName + " loses " + "$" + punter[i].Bet.ToString() + ".00");

                }
                else
                {

                    punter[i].Cash += punter[i].Bet;

                    //update match results to game console (list box)
                    consoleMessages.Add(punter[i].PunterName + " wins " + "$" + punter[i].Bet.ToString() + ".00 more");
                }

                //set the punter's bet to 0 for round 2
                punter[i].Bet = 0;
            }

            return consoleMessages;
        }

        //function when choosing a punter to place a bet with
        public string punterSelect(string punterName)
        {
            
            //This code is commented out for unit testing purposes

            //for (int i = 0; i < 3; i++)
            //{
            //    punter[i] = Factory.GetAPunter(i);
            //}


            //initialise a list to return
            string cash;

            //for every punter in the array, return their total cash
            foreach (Punter punterItem in punter)
            {
                if (punterName == punterItem.PunterName)
                {
                    switch (punterName)
                    {
                        //returns the total amount of cash the punters currently have
                        case "Declan the Engager":
                            currentPunter = new Declan();
                            cash = (punterItem.Cash.ToString());
                            return cash;

                        case "Gerard the Grey":
                            currentPunter = new Gerard();
                            cash = (punterItem.Cash.ToString());
                            return cash;

                        case "Alien of the Unknown":
                            currentPunter = new Alien();
                            cash = (punterItem.Cash.ToString());
                            return cash;

                    }
                }
              
            }
            return null;
        }


        //when bets are placed this function will execute
        public List<string> AssignBets(string selectedRacer, decimal selectedBet)
        {
            List<string> betInfo = new List<string>();

            for (int i = 0; i < punter.Length; i++)
            {
                if (currentPunter.PunterName == punter[i].PunterName)
                {

                    //assign racer
                    punter[i].Racer = selectedRacer;
                    betInfo.Add(punter[i].Racer);

                    //assign bet
                    punter[i].Bet = float.Parse(selectedBet.ToString());
                    betInfo.Add(punter[i].Bet.ToString());

                    //return the info and the name of the punter to assign it in front end
                    betInfo.Add(punter[i].PunterName);

                    //assign wallet for input checking when betting
                    betInfo.Add(punter[i].Cash.ToString());

                    return betInfo;
                }
            }
            return null;
        }

        //This is the function to check if the race should go to the next round
        //or it should reset to beginning maximum wallets or continue from what the player left off

        public List<string> RaceReset(double declanWallet, double gerardWallet, double alienWallet, Label winner)
        {
            List<string> walletList = new List<string>();


            if(punter[0].Cash <= 0 && punter[1].Cash <= 0 && punter[2].Cash <= 0)
            {
                LoadPunters(winner);
                for (int i = 0; i < punter.Length; i++)
                {
                    walletList.Add(punter[i].Bet.ToString());
                    walletList.Add(punter[i].Cash.ToString());
                }
                walletList.Add("Play Again");
                return walletList;
            }
            else
            {
                for (int i = 0; i < punter.Length; i++)
                {
                    walletList.Add(punter[i].Bet.ToString());
                    walletList.Add(punter[i].Cash.ToString());
                }
                walletList.Add("Next Round");
                return walletList;
            }

        }

    }
}   