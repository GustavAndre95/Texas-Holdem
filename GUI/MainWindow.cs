using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ConsoleApp1.Domain;
using System.Timers;

namespace ConsoleApp1.GUI
{
    public partial class MainWindow : Form
    {
        List<PictureBox> allPocketCards = new List<PictureBox>();
        List<PictureBox> invisibleCards = new List<PictureBox>();
        List<PictureBox> tableCards = new List<PictureBox>();
        List<Label> betLabels = new List<Label>();
        Controller controller;
        int betsum;
        bool animationRunning = false;

        public MainWindow(Controller c)
        {
            controller = c;
            controller.startGame();
            InitializeComponent();
            addTableCards();
            addAllPocketCards();
            addBetLabels();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            addTableCards();
            loadAllPlayerStats();
            loadPocketCards();
            loadTableCards();
            loadPlayerStats();
            loadTableStats();
            loadOutPutWindow();
            loadBetSum(0);
        }

        private void rightCard_Click(object sender, EventArgs e)
        {

        }
        private void leftCard_Click(object sender, EventArgs e)
        {

        }

        //Functions for loading values depending on controller input.
        private void loadPocketCards() {
            Player p = controller.CurrentPlayer;

            String source = System.IO.Path.GetFullPath(@"..\..\") + "GUI\\GUI_Images\\PlayingCards";
            try
            {
                String card1 = source + "\\" + getImage(p.PocketCards[0]);
                String card2 = source + "\\" + getImage(p.PocketCards[1]);
                leftCard.Image = Image.FromFile(card1);
                rightCard.Image = Image.FromFile(card2);
            }    //Reloads game if it somehow finds currentplayer to be null.
            catch (NullReferenceException)
            {
                controller.reloadGame();
                MainWindow_Load(this, null);
                return;
            }
        }

        private void loadTableCards() {
            if (controller.triggerRevealCards()) {
                controller.sendToOutput("Time for the showdown! Cards are being revealed...");
                triggerRevealCards();
                loadDialogWindow();

            }
            GameTable gt = controller.GameBoard;
            String source = System.IO.Path.GetFullPath(@"..\..\") + "GUI\\GUI_Images\\PlayingCards";
            Image backImage = Image.FromFile(source + "\\" + "playingcardback.jpg");

            int index = 0;
            if (gt.CardsShown.Count == 0) {
                foreach (PictureBox pb in tableCards)
                    pb.Image = backImage;
            }
            foreach (Card c in gt.CardsShown) {
                tableCards[index].Image = Image.FromFile(source + "\\" + c.Rank + "_of_" + c.Suit + ".png");
                index++;
            }
        }


        private void loadAllPlayerStats() {
            List<Player> players = controller.GameBoard.Players;
            String source = System.IO.Path.GetFullPath(@"..\..\") + "GUI\\GUI_Images\\PlayingCards\\playingcardback.jpg";
            if (controller.GameBoard.RoundIndex == 1)
                foreach (PictureBox pb in allPocketCards)
                    pb.Image = Image.FromFile(source);


            player1Cash.Text = "Cash: " + players[0].Cash;
            if (players.Count > 1)
                player2Cash.Text = "Cash: " + players[1].Cash;
            if (players.Count > 2)
                player3Cash.Text = "Cash: " + players[2].Cash;
       
        }
        
            
        private void loadPlayerStats() {
            Player p = controller.CurrentPlayer;
            playerNameLabel.Text = p.Name;
            displayPlayerCash.Text = Convert.ToString(p.Cash);
            displayTotalBet.Text = Convert.ToString(p.TotalBet);
        }

        private void loadTableStats() {
            GameTable gt = controller.GameBoard;
            displayCurrentPot.Text = Convert.ToString(gt.CurrentPot);
            displayMinimumBet.Text = Convert.ToString(gt.MinimumBet);
        }

        private void loadOutPutWindow() {
            List<String> toPrint = controller.OutputLines;
            textBox1.Text = "";
            foreach (String line in toPrint) {
                textBox1.Text += line + Environment.NewLine;
            }
        }

        private void loadBetSum(int diff)
        {
           var gt = controller.GameBoard;
           var p = controller.CurrentPlayer;

            if (diff == 0)
                betsum = gt.MinimumBet - p.TotalBet;
            if (betsum + diff < 0)
                return;
            betsum = betsum + diff;
            betBox.Text = Convert.ToString(betsum);
        }

        //Animations and triggered events! WOOOHOOO
        private void triggerExplosion(int i) {
            String source = System.IO.Path.GetFullPath(@"..\..\") + "GUI\\GUI_Images\\Animations\\tmp-";
            if (i == 3)
            {
                for (int cardIndex = 0; cardIndex < i; cardIndex++)
                {
                    for (int animIndex = 0; animIndex < 7; animIndex ++)
                    {
                       
                    }
               
                }
            }
        }

        private async void triggerRevealCards() //Play animation for revealing cards.
        {
            animationRunning = true;
            List<Player> players = controller.GameBoard.Players;

            int interval = 1000;
            int index = 0;
            int i = 0;

            Image backImage = Image.FromFile(System.IO.Path.GetFullPath(@"..\..\") + "GUI\\GUI_Images\\PlayingCards\\playingcardback.jpg");
            String source = System.IO.Path.GetFullPath(@"..\..\") + "GUI\\GUI_Images\\PlayingCards\\";

            while (index < players.Count * 2) {
                allPocketCards[index].Image = Image.FromFile(source + getImage(players[index / 2].PocketCards[i]));
                await Task.Delay(interval);
      
                if (i == 0)
                {
                    i = 1;
                }
                else if (i == 1)
                    i = 0;

                if (index > (players.Count * 2) - 1)
                {
                    return;
                }
                index++;
            }
            animationRunning = false;

        }



        private async void fadeOut(Label l, Player current, int betsum, int interval = 150 )
        {
            //Object is fully visible. Fade it out
            l.Visible = true;
            l.Text = "- " + betsum;
            int value = 0;
            while (value < 250)
            {
                l.BackColor = Color.FromArgb(value, Color.Green);
                l.ForeColor = Color.FromArgb(value, Color.Red);
                await Task.Delay(interval); 
                value = value + 50;
            }
            l.Visible = false;
        }

        //Internal functions for adding cards to arrays, which makes loading cards easier.
        private void addTableCards()
        {
            
            tableCards.Clear();
            tableCards.Add(tableCard1);
            tableCards.Add(tableCard2);
            tableCards.Add(tableCard3);
            tableCards.Add(tableCard4);
            tableCards.Add(tableCard5);

        }
        private void addBetLabels()
        {
            betLabels.Add(player1BetLabel);
            betLabels.Add(player2BetLabel);
            betLabels.Add(player3BetLabel);
        }
        private void addAllPocketCards()
        {
            allPocketCards.Add(player1Card1);
            allPocketCards.Add(player1Card2);
            allPocketCards.Add(player2Card1);
            allPocketCards.Add(player2Card2);
            allPocketCards.Add(player3Card1);
            allPocketCards.Add(player3Card2);

        }


        private async void loadDialogWindow() {
            List <Player> players = controller.GameBoard.Players;

            await Task.Delay(players.Count * 2000); //Wait until all cards has been visible before loading!
            DialogResult dialog = MessageBox.Show("The Winner is " + controller.Winner.Name + " with a " + controller.Winner.BestCards.Type + ".\nDo you want to play another session?", "Play again?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) {
                controller.startGame(); 
                MainWindow_Load(this, null);
            }
            else
                Application.Exit();
        }

        private void triggerBetAnimation(int betsum, Player current) {
            List<Player> players = controller.GameBoard.Players;
            foreach (Player p in players) {
                if (current == p)
                {
                    fadeOut(betLabels[players.IndexOf(p)], p, betsum);
                }
            }
                    
        }

        private String getImage(Card c) {
            return c.Rank + "_of_" + c.Suit + ".png";
        }

        //Listeners
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (animationRunning)
                return;
            Player p = controller.CurrentPlayer;
            if (controller.checkBet(0, p))
                triggerBetAnimation(0, p);
            MainWindow_Load(this, null);
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            if (animationRunning)
                return;
            Player p = controller.CurrentPlayer;
            GameTable gt = controller.GameBoard;
            int betsum = gt.MinimumBet - p.TotalBet;
            if (controller.checkBet(betsum, p))
                triggerBetAnimation((betsum), p);
            MainWindow_Load(this, null);
        }

        private void foldButton_Click(object sender, EventArgs e)
        {
            if (animationRunning)
                return;
            Player p = controller.CurrentPlayer;
            controller.foldPlayer(p);
            MainWindow_Load(this, null);
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (animationRunning)
                return;
            Player p = controller.CurrentPlayer;
            try
            {
                int betsum = Convert.ToInt16(betBox.Text);
                if (controller.checkBet(betsum, p)) {
                    triggerBetAnimation(betsum, p);
                }
            } catch (FormatException) {
                controller.sendToOutput("Invalid input.");
            }
            MainWindow_Load(this, null);
        }

        private void allInButton_Click(object sender, EventArgs e)
        {
            if (animationRunning)
                return;
            Player p = controller.CurrentPlayer;
            controller.allInPlayer(p);
            MainWindow_Load(this, null);
            
        }
        private void upButton_Click(object sender, EventArgs e)
        {
            if (animationRunning)
                return;
            loadBetSum(5);

        }

        private void boardPlayer3_Click(object sender, EventArgs e)
        {

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (animationRunning)
                return;
            loadBetSum(-5);
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (animationRunning)
                return;
            controller.reloadGame();
            MainWindow_Load(this, null);
        }
    }
}
