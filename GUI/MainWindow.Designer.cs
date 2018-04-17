namespace ConsoleApp1.GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.leftCard = new System.Windows.Forms.PictureBox();
            this.rightCard = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.displayTotalBet = new System.Windows.Forms.Label();
            this.roundBetLabel = new System.Windows.Forms.Label();
            this.allInButton = new System.Windows.Forms.Button();
            this.displayPlayerCash = new System.Windows.Forms.Label();
            this.playerCashLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.minusButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.betBox = new System.Windows.Forms.TextBox();
            this.betButton = new System.Windows.Forms.Button();
            this.foldButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.gameBoard = new System.Windows.Forms.PictureBox();
            this.boardPlayer1 = new System.Windows.Forms.Label();
            this.boardPlayer2 = new System.Windows.Forms.Label();
            this.player3Card1 = new System.Windows.Forms.PictureBox();
            this.player3Card2 = new System.Windows.Forms.PictureBox();
            this.player1Card1 = new System.Windows.Forms.PictureBox();
            this.player1Card2 = new System.Windows.Forms.PictureBox();
            this.player2Card1 = new System.Windows.Forms.PictureBox();
            this.player2Card2 = new System.Windows.Forms.PictureBox();
            this.tableCard1 = new System.Windows.Forms.PictureBox();
            this.tableCard2 = new System.Windows.Forms.PictureBox();
            this.tableCard3 = new System.Windows.Forms.PictureBox();
            this.tableCard4 = new System.Windows.Forms.PictureBox();
            this.tableCard5 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.currentPotLabel = new System.Windows.Forms.Label();
            this.displayCurrentPot = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.displayMinimumBet = new System.Windows.Forms.Label();
            this.boardPlayer3 = new System.Windows.Forms.Label();
            this.player3Cash = new System.Windows.Forms.Label();
            this.player1Cash = new System.Windows.Forms.Label();
            this.player2Cash = new System.Windows.Forms.Label();
            this.player3BetLabel = new System.Windows.Forms.Label();
            this.player1BetLabel = new System.Windows.Forms.Label();
            this.player2BetLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightCard)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // leftCard
            // 
            this.leftCard.Image = ((System.Drawing.Image)(resources.GetObject("leftCard.Image")));
            this.leftCard.Location = new System.Drawing.Point(606, 681);
            this.leftCard.Name = "leftCard";
            this.leftCard.Size = new System.Drawing.Size(89, 123);
            this.leftCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftCard.TabIndex = 0;
            this.leftCard.TabStop = false;
            this.leftCard.Click += new System.EventHandler(this.leftCard_Click);
            // 
            // rightCard
            // 
            this.rightCard.Image = global::ConsoleApp1.Properties.Resources.ace_of_hearts;
            this.rightCard.Location = new System.Drawing.Point(692, 681);
            this.rightCard.Name = "rightCard";
            this.rightCard.Size = new System.Drawing.Size(82, 123);
            this.rightCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightCard.TabIndex = 1;
            this.rightCard.TabStop = false;
            this.rightCard.Click += new System.EventHandler(this.rightCard_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.displayTotalBet);
            this.leftPanel.Controls.Add(this.roundBetLabel);
            this.leftPanel.Controls.Add(this.allInButton);
            this.leftPanel.Controls.Add(this.displayPlayerCash);
            this.leftPanel.Controls.Add(this.playerCashLabel);
            this.leftPanel.Controls.Add(this.playerNameLabel);
            this.leftPanel.Location = new System.Drawing.Point(780, 681);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(319, 132);
            this.leftPanel.TabIndex = 2;
            // 
            // displayTotalBet
            // 
            this.displayTotalBet.AutoSize = true;
            this.displayTotalBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.displayTotalBet.Location = new System.Drawing.Point(206, 88);
            this.displayTotalBet.Name = "displayTotalBet";
            this.displayTotalBet.Size = new System.Drawing.Size(76, 29);
            this.displayTotalBet.TabIndex = 10;
            this.displayTotalBet.Text = "100 $";
            // 
            // roundBetLabel
            // 
            this.roundBetLabel.AutoSize = true;
            this.roundBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.roundBetLabel.Location = new System.Drawing.Point(3, 87);
            this.roundBetLabel.Name = "roundBetLabel";
            this.roundBetLabel.Size = new System.Drawing.Size(211, 29);
            this.roundBetLabel.TabIndex = 9;
            this.roundBetLabel.Text = "Betted this round:";
            // 
            // allInButton
            // 
            this.allInButton.BackColor = System.Drawing.Color.DarkRed;
            this.allInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.allInButton.Location = new System.Drawing.Point(220, 3);
            this.allInButton.Name = "allInButton";
            this.allInButton.Size = new System.Drawing.Size(87, 48);
            this.allInButton.TabIndex = 8;
            this.allInButton.Text = "ALL IN";
            this.allInButton.UseVisualStyleBackColor = false;
            this.allInButton.Click += new System.EventHandler(this.allInButton_Click);
            // 
            // displayPlayerCash
            // 
            this.displayPlayerCash.AutoSize = true;
            this.displayPlayerCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.displayPlayerCash.Location = new System.Drawing.Point(78, 45);
            this.displayPlayerCash.Name = "displayPlayerCash";
            this.displayPlayerCash.Size = new System.Drawing.Size(76, 29);
            this.displayPlayerCash.TabIndex = 2;
            this.displayPlayerCash.Text = "100 $";
            // 
            // playerCashLabel
            // 
            this.playerCashLabel.AutoSize = true;
            this.playerCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.playerCashLabel.Location = new System.Drawing.Point(3, 45);
            this.playerCashLabel.Name = "playerCashLabel";
            this.playerCashLabel.Size = new System.Drawing.Size(79, 29);
            this.playerCashLabel.TabIndex = 1;
            this.playerCashLabel.Text = "Cash:";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.playerNameLabel.Location = new System.Drawing.Point(3, 5);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(106, 29);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player 1";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.rightPanel.Controls.Add(this.minusButton);
            this.rightPanel.Controls.Add(this.upButton);
            this.rightPanel.Controls.Add(this.betBox);
            this.rightPanel.Controls.Add(this.betButton);
            this.rightPanel.Controls.Add(this.foldButton);
            this.rightPanel.Controls.Add(this.checkButton);
            this.rightPanel.Controls.Add(this.callButton);
            this.rightPanel.Location = new System.Drawing.Point(328, 681);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(279, 123);
            this.rightPanel.TabIndex = 3;
            // 
            // minusButton
            // 
            this.minusButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minusButton.BackgroundImage")));
            this.minusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.minusButton.Location = new System.Drawing.Point(177, 83);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(33, 26);
            this.minusButton.TabIndex = 10;
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // upButton
            // 
            this.upButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upButton.BackgroundImage")));
            this.upButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.upButton.Location = new System.Drawing.Point(177, 54);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(33, 26);
            this.upButton.TabIndex = 8;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // betBox
            // 
            this.betBox.Location = new System.Drawing.Point(216, 67);
            this.betBox.Name = "betBox";
            this.betBox.Size = new System.Drawing.Size(56, 22);
            this.betBox.TabIndex = 4;
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.DimGray;
            this.betButton.Location = new System.Drawing.Point(216, 95);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(63, 28);
            this.betButton.TabIndex = 7;
            this.betButton.Text = "BET";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // foldButton
            // 
            this.foldButton.BackColor = System.Drawing.Color.DimGray;
            this.foldButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.foldButton.FlatAppearance.BorderSize = 5;
            this.foldButton.Location = new System.Drawing.Point(189, 0);
            this.foldButton.Name = "foldButton";
            this.foldButton.Size = new System.Drawing.Size(87, 48);
            this.foldButton.TabIndex = 6;
            this.foldButton.Text = "FOLD";
            this.foldButton.UseVisualStyleBackColor = false;
            this.foldButton.Click += new System.EventHandler(this.foldButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.DimGray;
            this.checkButton.Location = new System.Drawing.Point(0, 0);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(93, 48);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "CHECK";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // callButton
            // 
            this.callButton.BackColor = System.Drawing.Color.DimGray;
            this.callButton.Location = new System.Drawing.Point(99, 0);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(84, 48);
            this.callButton.TabIndex = 4;
            this.callButton.Text = "CALL";
            this.callButton.UseVisualStyleBackColor = false;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // gameBoard
            // 
            this.gameBoard.Image = ((System.Drawing.Image)(resources.GetObject("gameBoard.Image")));
            this.gameBoard.Location = new System.Drawing.Point(340, 12);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(780, 605);
            this.gameBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameBoard.TabIndex = 4;
            this.gameBoard.TabStop = false;

            // 
            // boardPlayer1
            // 
            this.boardPlayer1.AutoSize = true;
            this.boardPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.boardPlayer1.Location = new System.Drawing.Point(513, 40);
            this.boardPlayer1.Name = "boardPlayer1";
            this.boardPlayer1.Size = new System.Drawing.Size(77, 24);
            this.boardPlayer1.TabIndex = 11;
            this.boardPlayer1.Text = "Player 1";
            // 
            // boardPlayer2
            // 
            this.boardPlayer2.AutoSize = true;
            this.boardPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.boardPlayer2.Location = new System.Drawing.Point(859, 40);
            this.boardPlayer2.Name = "boardPlayer2";
            this.boardPlayer2.Size = new System.Drawing.Size(77, 24);
            this.boardPlayer2.TabIndex = 12;
            this.boardPlayer2.Text = "Player 2";
            // 
            // player3Card1
            // 
            this.player3Card1.Image = ((System.Drawing.Image)(resources.GetObject("player3Card1.Image")));
            this.player3Card1.Location = new System.Drawing.Point(340, 520);
            this.player3Card1.Name = "player3Card1";
            this.player3Card1.Size = new System.Drawing.Size(70, 95);
            this.player3Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player3Card1.TabIndex = 13;
            this.player3Card1.TabStop = false;
            // 
            // player3Card2
            // 
            this.player3Card2.Image = ((System.Drawing.Image)(resources.GetObject("player3Card2.Image")));
            this.player3Card2.Location = new System.Drawing.Point(416, 520);
            this.player3Card2.Name = "player3Card2";
            this.player3Card2.Size = new System.Drawing.Size(68, 95);
            this.player3Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player3Card2.TabIndex = 14;
            this.player3Card2.TabStop = false;
            // 
            // player1Card1
            // 
            this.player1Card1.Image = ((System.Drawing.Image)(resources.GetObject("player1Card1.Image")));
            this.player1Card1.Location = new System.Drawing.Point(348, 30);
            this.player1Card1.Name = "player1Card1";
            this.player1Card1.Size = new System.Drawing.Size(73, 92);
            this.player1Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Card1.TabIndex = 15;
            this.player1Card1.TabStop = false;
    
            // 
            // player1Card2
            // 
            this.player1Card2.Image = ((System.Drawing.Image)(resources.GetObject("player1Card2.Image")));
            this.player1Card2.Location = new System.Drawing.Point(427, 30);
            this.player1Card2.Name = "player1Card2";
            this.player1Card2.Size = new System.Drawing.Size(68, 92);
            this.player1Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Card2.TabIndex = 16;
            this.player1Card2.TabStop = false;
            // 
            // player2Card1
            // 
            this.player2Card1.Image = ((System.Drawing.Image)(resources.GetObject("player2Card1.Image")));
            this.player2Card1.Location = new System.Drawing.Point(958, 21);
            this.player2Card1.Name = "player2Card1";
            this.player2Card1.Size = new System.Drawing.Size(69, 92);
            this.player2Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2Card1.TabIndex = 17;
            this.player2Card1.TabStop = false;
            // 
            // player2Card2
            // 
            this.player2Card2.Image = ((System.Drawing.Image)(resources.GetObject("player2Card2.Image")));
            this.player2Card2.Location = new System.Drawing.Point(1033, 21);
            this.player2Card2.Name = "player2Card2";
            this.player2Card2.Size = new System.Drawing.Size(66, 92);
            this.player2Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2Card2.TabIndex = 18;
            this.player2Card2.TabStop = false;
            // 
            // tableCard1
            // 
            this.tableCard1.Image = ((System.Drawing.Image)(resources.GetObject("tableCard1.Image")));
            this.tableCard1.Location = new System.Drawing.Point(534, 220);
            this.tableCard1.Name = "tableCard1";
            this.tableCard1.Size = new System.Drawing.Size(73, 110);
            this.tableCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableCard1.TabIndex = 19;
            this.tableCard1.TabStop = false;
            // 
            // tableCard2
            // 
            this.tableCard2.Image = ((System.Drawing.Image)(resources.GetObject("tableCard2.Image")));
            this.tableCard2.Location = new System.Drawing.Point(613, 200);
            this.tableCard2.Name = "tableCard2";
            this.tableCard2.Size = new System.Drawing.Size(76, 103);
            this.tableCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableCard2.TabIndex = 20;
            this.tableCard2.TabStop = false;
            // 
            // tableCard3
            // 
            this.tableCard3.Image = ((System.Drawing.Image)(resources.GetObject("tableCard3.Image")));
            this.tableCard3.Location = new System.Drawing.Point(695, 182);
            this.tableCard3.Name = "tableCard3";
            this.tableCard3.Size = new System.Drawing.Size(74, 105);
            this.tableCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableCard3.TabIndex = 21;
            this.tableCard3.TabStop = false;
            // 
            // tableCard4
            // 
            this.tableCard4.Image = ((System.Drawing.Image)(resources.GetObject("tableCard4.Image")));
            this.tableCard4.Location = new System.Drawing.Point(780, 198);
            this.tableCard4.Name = "tableCard4";
            this.tableCard4.Size = new System.Drawing.Size(74, 105);
            this.tableCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableCard4.TabIndex = 22;
            this.tableCard4.TabStop = false;
            // 
            // tableCard5
            // 
            this.tableCard5.Image = ((System.Drawing.Image)(resources.GetObject("tableCard5.Image")));
            this.tableCard5.Location = new System.Drawing.Point(863, 220);
            this.tableCard5.Name = "tableCard5";
            this.tableCard5.Size = new System.Drawing.Size(77, 105);
            this.tableCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tableCard5.TabIndex = 23;
            this.tableCard5.TabStop = false;

            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(-5, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(339, 491);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "TESTING TESTING";
            // 
            // currentPotLabel
            // 
            this.currentPotLabel.AutoSize = true;
            this.currentPotLabel.BackColor = System.Drawing.Color.Green;
            this.currentPotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.currentPotLabel.Location = new System.Drawing.Point(675, 326);
            this.currentPotLabel.Name = "currentPotLabel";
            this.currentPotLabel.Size = new System.Drawing.Size(42, 24);
            this.currentPotLabel.TabIndex = 25;
            this.currentPotLabel.Text = "Pot:";

            // 
            // displayCurrentPot
            // 
            this.displayCurrentPot.AutoSize = true;
            this.displayCurrentPot.BackColor = System.Drawing.Color.Green;
            this.displayCurrentPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.displayCurrentPot.Location = new System.Drawing.Point(708, 326);
            this.displayCurrentPot.Name = "displayCurrentPot";
            this.displayCurrentPot.Size = new System.Drawing.Size(55, 24);
            this.displayCurrentPot.TabIndex = 26;
            this.displayCurrentPot.Text = "100 $";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.BackColor = System.Drawing.Color.Green;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.minimumBetLabel.Location = new System.Drawing.Point(658, 350);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(125, 24);
            this.minimumBetLabel.TabIndex = 27;
            this.minimumBetLabel.Text = "Minimum Bet:";
    
            // 
            // displayMinimumBet
            // 
            this.displayMinimumBet.AutoSize = true;
            this.displayMinimumBet.BackColor = System.Drawing.Color.Green;
            this.displayMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.displayMinimumBet.Location = new System.Drawing.Point(776, 350);
            this.displayMinimumBet.Name = "displayMinimumBet";
            this.displayMinimumBet.Size = new System.Drawing.Size(45, 24);
            this.displayMinimumBet.TabIndex = 28;
            this.displayMinimumBet.Text = "50 $";
            // 
            // boardPlayer3
            // 
            this.boardPlayer3.AutoSize = true;
            this.boardPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.boardPlayer3.Location = new System.Drawing.Point(501, 543);
            this.boardPlayer3.Name = "boardPlayer3";
            this.boardPlayer3.Size = new System.Drawing.Size(77, 24);
            this.boardPlayer3.TabIndex = 10;
            this.boardPlayer3.Text = "Player 3";
            this.boardPlayer3.Click += new System.EventHandler(this.boardPlayer3_Click);
            // 
            // player3Cash
            // 
            this.player3Cash.AutoSize = true;
            this.player3Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.player3Cash.Location = new System.Drawing.Point(501, 567);
            this.player3Cash.Name = "player3Cash";
            this.player3Cash.Size = new System.Drawing.Size(96, 24);
            this.player3Cash.TabIndex = 29;
            this.player3Cash.Text = "FINISHED";
     
            // 
            // player1Cash
            // 
            this.player1Cash.AutoSize = true;
            this.player1Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.player1Cash.Location = new System.Drawing.Point(513, 64);
            this.player1Cash.Name = "player1Cash";
            this.player1Cash.Size = new System.Drawing.Size(96, 24);
            this.player1Cash.TabIndex = 30;
            this.player1Cash.Text = "FINISHED";
            // 
            // player2Cash
            // 
            this.player2Cash.AutoSize = true;
            this.player2Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.player2Cash.Location = new System.Drawing.Point(859, 64);
            this.player2Cash.Name = "player2Cash";
            this.player2Cash.Size = new System.Drawing.Size(96, 24);
            this.player2Cash.TabIndex = 31;
            this.player2Cash.Text = "FINISHED";
            // 
            // player3BetLabel
            // 
            this.player3BetLabel.AutoSize = true;
            this.player3BetLabel.BackColor = System.Drawing.Color.Green;
            this.player3BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.player3BetLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.player3BetLabel.Location = new System.Drawing.Point(518, 498);
            this.player3BetLabel.Name = "player3BetLabel";
            this.player3BetLabel.Size = new System.Drawing.Size(60, 31);
            this.player3BetLabel.TabIndex = 32;
            this.player3BetLabel.Text = "- 30";
            this.player3BetLabel.Visible = false;
            // 
            // player1BetLabel
            // 
            this.player1BetLabel.AutoSize = true;
            this.player1BetLabel.BackColor = System.Drawing.Color.Green;
            this.player1BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.player1BetLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.player1BetLabel.Location = new System.Drawing.Point(518, 106);
            this.player1BetLabel.Name = "player1BetLabel";
            this.player1BetLabel.Size = new System.Drawing.Size(60, 31);
            this.player1BetLabel.TabIndex = 33;
            this.player1BetLabel.Text = "- 30";
            this.player1BetLabel.Visible = false;
            // 
            // player2BetLabel
            // 
            this.player2BetLabel.AutoSize = true;
            this.player2BetLabel.BackColor = System.Drawing.Color.Green;
            this.player2BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.player2BetLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.player2BetLabel.Location = new System.Drawing.Point(857, 106);
            this.player2BetLabel.Name = "player2BetLabel";
            this.player2BetLabel.Size = new System.Drawing.Size(60, 31);
            this.player2BetLabel.TabIndex = 34;
            this.player2BetLabel.Text = "- 30";
            this.player2BetLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.button1.Location = new System.Drawing.Point(77, 717);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 74);
            this.button1.TabIndex = 35;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 816);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.player2BetLabel);
            this.Controls.Add(this.player1BetLabel);
            this.Controls.Add(this.player3BetLabel);
            this.Controls.Add(this.player2Cash);
            this.Controls.Add(this.player1Cash);
            this.Controls.Add(this.player3Cash);
            this.Controls.Add(this.displayMinimumBet);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.displayCurrentPot);
            this.Controls.Add(this.currentPotLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableCard5);
            this.Controls.Add(this.tableCard4);
            this.Controls.Add(this.tableCard3);
            this.Controls.Add(this.tableCard2);
            this.Controls.Add(this.tableCard1);
            this.Controls.Add(this.player2Card2);
            this.Controls.Add(this.player2Card1);
            this.Controls.Add(this.player1Card2);
            this.Controls.Add(this.player1Card1);
            this.Controls.Add(this.player3Card2);
            this.Controls.Add(this.player3Card1);
            this.Controls.Add(this.boardPlayer2);
            this.Controls.Add(this.boardPlayer1);
            this.Controls.Add(this.boardPlayer3);
            this.Controls.Add(this.gameBoard);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightCard);
            this.Controls.Add(this.leftCard);
            this.Name = "MainWindow";
            this.Text = "Texas Holdem";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightCard)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCard5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox leftCard;
        private System.Windows.Forms.PictureBox rightCard;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button foldButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button callButton;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.TextBox betBox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label playerCashLabel;
        private System.Windows.Forms.Label displayPlayerCash;
        private System.Windows.Forms.Button allInButton;
        private System.Windows.Forms.PictureBox gameBoard;
        private System.Windows.Forms.Label boardPlayer1;
        private System.Windows.Forms.Label boardPlayer2;
        private System.Windows.Forms.PictureBox player3Card1;
        private System.Windows.Forms.PictureBox player3Card2;
        private System.Windows.Forms.PictureBox player1Card1;
        private System.Windows.Forms.PictureBox player1Card2;
        private System.Windows.Forms.PictureBox player2Card1;
        private System.Windows.Forms.PictureBox player2Card2;
        private System.Windows.Forms.PictureBox tableCard1;
        private System.Windows.Forms.PictureBox tableCard2;
        private System.Windows.Forms.PictureBox tableCard3;
        private System.Windows.Forms.PictureBox tableCard4;
        private System.Windows.Forms.PictureBox tableCard5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label currentPotLabel;
        private System.Windows.Forms.Label displayCurrentPot;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label displayMinimumBet;
        private System.Windows.Forms.Label displayTotalBet;
        private System.Windows.Forms.Label roundBetLabel;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label boardPlayer3;
        private System.Windows.Forms.Label player3Cash;
        private System.Windows.Forms.Label player1Cash;
        private System.Windows.Forms.Label player2Cash;
        private System.Windows.Forms.Label player3BetLabel;
        private System.Windows.Forms.Label player1BetLabel;
        private System.Windows.Forms.Label player2BetLabel;
        private System.Windows.Forms.Button button1;
    }
}