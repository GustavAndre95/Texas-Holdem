using ConsoleApp1.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1.Domain
{

    public class Controller
    {
        public Controller(GameTable gt)
        {
            gameBoard = gt;
            players = gameBoard.Players;
        }

        private Player winner;
        public Player Winner { get => winner; }
        private Player currentPlayer;
        public Player CurrentPlayer { get => currentPlayer; }

        private bool revealCards;
        private bool showDialog;
        private List<Player> players;
        private GameTable gameBoard;
        public GameTable GameBoard { get => gameBoard; set => gameBoard = value; }
        private List<String> outputLines = new List<String>();
        public List<String> OutputLines { get => outputLines; }

        public void startGame()
        {
            ResultAnalyzer ra = new ResultAnalyzer();
            PersistanceManager pm = new PersistanceManager();
            try { pm.loadFromFile(gameBoard); }
            catch (System.IO.FileNotFoundException)
            {
                players.Clear();
                outputLines.Clear();
                gameBoard.CurrentPot = 0;
                players.Add(new Person("Player " + 1, 50, gameBoard)); //Main player
                for (int i = 2; i < 4; i++)  //Start with 2 extra persons for testing purposes.
                    players.Add(new Person("Player " + i, 50, gameBoard));
            }

            try
            {
                startSession();
            }
            catch (SinglePlayerException) {
                async void wait()
                {
                    sendToOutput("Congratulations, you won the game. Now restarting");
                    await Task.Delay(3000);
                    reloadGame();
                }
                
                
            }

            if (players.Count == 0)
                reloadGame();
        }

        public bool triggerRevealCards()
        {
            bool check = revealCards;
            revealCards = false;
            return check;
        }

        public bool triggerShowDialog()
        {
            bool check = showDialog;
            showDialog = false;
            return check;
        }

        private void checkNextMove()
        {
            List<Player> checkList = new List<Player>();

            foreach (Player p in players)
                if (!p.HasFolded)
                    checkList.Add(p);

            if (checkList.Count == 1)
            {
                checkList[0].Cash += gameBoard.CurrentPot;
                winner = gameBoard.decideWinner();
                revealCards = true;
                return;
            }

            foreach (Player p in players)
            {
                if (!p.HasBetted && !p.HasFolded && !p.HasBettedAll)
                {
                    currentPlayer = p;
                    sendToOutput(currentPlayer.Name + " is making his decision...");
                    return;
                }
            }
            foreach (Player p in players)
            {
                if (!p.HasFolded && !p.HasBettedAll)
                {
                    
                    if (p.TotalBet < gameBoard.MinimumBet)
                    {
                        currentPlayer = p;
                        sendToOutput(currentPlayer.Name + " is making his decision...");
                        return;
                    }
                }
            }
            startRound();
        }

        public bool checkBet(int betSum, Player currentPlayer)
        {
            if (betSum > currentPlayer.Cash)
            {
                sendToOutput("You don't have the cash.");
                return false;
            }
            else if (currentPlayer.TotalBet + betSum < gameBoard.MinimumBet)
            {
                sendToOutput("Bet (totally this round) higher than minimum bet or fold.");
                return false;
            }
            else
            {
                sendToOutput(currentPlayer.Name + " bets " + betSum);
                currentPlayer.bet(betSum);
                checkNextMove();
                return true;
            }
        }

        public void foldPlayer(Player p)
        {
            sendToOutput(p.Name + " has folded and is skipping the rest of the session");
            p.fold();
            checkNextMove();
        }

        public void allInPlayer(Player p)
        {
            p.bet(p.Cash);
            p.HasBettedAll = true;
            sendToOutput(p.Name + " just betted all of his cash!!");
            checkNextMove();
        }

        public void startSession()
        {
            sendToOutput(Environment.NewLine);
            sendToOutput("A new session has started!");
            gameBoard.RoundIndex = 0;
            gameBoard.CardsShown.Clear();
            kickBrokePlayers();
            if (players.Count == 1)
            {
                throw new SinglePlayerException();
            }
            sendToOutput("The players are: ");

            foreach (Player p in players)
            {
                p.HasFolded = false; //Reset folds from previous sessions.
                p.HasBettedAll = false;
                sendToOutput(p.Name);
                p.giveBlind(); //Give blinds
            }
            sendToOutput("New cards are being dealt out..");
            gameBoard.dealCards(); // Deal cards
            startRound();
        }

        private void startRound()
        {
            //Is the session done?
            if (gameBoard.RoundIndex > 3)
            {
                revealCards = true;
                showDialog = true;
                winner = GameBoard.decideWinner();
                PersistanceManager pm = new PersistanceManager();
                pm.saveToFile(gameBoard);
                return;
            }

            sendToOutput(Environment.NewLine);
            sendToOutput("A new round has started.");
            gameBoard.MinimumBet = 0;

            foreach (Player p in players)
            {
                p.HasBetted = false;
                p.TotalBet = 0;
            }

            if (gameBoard.RoundIndex != 0)
                gameBoard.layCards();

            foreach (Player p in players)
            {
                if (!p.HasFolded && !p.HasBettedAll)
                {
                    currentPlayer = p;
                    sendToOutput(currentPlayer.Name + " is making his decision...");
                    break;
                }
            }
            gameBoard.RoundIndex++;

        }
        public void sendToOutput(String line)
        {
            if (OutputLines.Count > 18)
                OutputLines.RemoveAt(0);
            OutputLines.Add(line);
        }

        private void kickBrokePlayers()
        {
            List<Player> toKick = new List<Player>();

            foreach (Player p in players)
            {
                if (p.Cash == 0)
                {
                    toKick.Add(p);
                    sendToOutput(p.Name + " has gambled away all his cash and has been kicked out of the game!");
                }
            }
            foreach (Player p in toKick)
            {
                players.Remove(p);
            }
        }

        public void reloadGame() {
            File.Delete(System.IO.Path.GetFullPath(@"..\..\") + "bin\\Debug\\savedata.xml");
            startGame();
        }
    }
}