namespace HorseBetting2020
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCt = new System.Windows.Forms.PictureBox();
            this.pbMonkey = new System.Windows.Forms.PictureBox();
            this.pbMinato = new System.Windows.Forms.PictureBox();
            this.pbSonic = new System.Windows.Forms.PictureBox();
            this.btnRunRace = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.gameConsole = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPunter = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.racerList = new System.Windows.Forms.DomainUpDown();
            this.Bet = new System.Windows.Forms.Label();
            this.betInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.declanRacer = new System.Windows.Forms.Label();
            this.alienRacer = new System.Windows.Forms.Label();
            this.gerardRacer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alienWallet = new System.Windows.Forms.Label();
            this.gerardWallet = new System.Windows.Forms.Label();
            this.alienBet = new System.Windows.Forms.Label();
            this.gerardBet = new System.Windows.Forms.Label();
            this.declanBet = new System.Windows.Forms.Label();
            this.declanWallet = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnAlien = new System.Windows.Forms.RadioButton();
            this.rbtnGerard = new System.Windows.Forms.RadioButton();
            this.rbtnDeclan = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlTrack = new System.Windows.Forms.Panel();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnNextRace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonic)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlTrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCt
            // 
            this.pbCt.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCt.InitialImage")));
            this.pbCt.Location = new System.Drawing.Point(2, 6);
            this.pbCt.Margin = new System.Windows.Forms.Padding(2);
            this.pbCt.Name = "pbCt";
            this.pbCt.Size = new System.Drawing.Size(97, 93);
            this.pbCt.TabIndex = 0;
            this.pbCt.TabStop = false;
            // 
            // pbMonkey
            // 
            this.pbMonkey.InitialImage = null;
            this.pbMonkey.Location = new System.Drawing.Point(0, 2);
            this.pbMonkey.Margin = new System.Windows.Forms.Padding(2);
            this.pbMonkey.Name = "pbMonkey";
            this.pbMonkey.Size = new System.Drawing.Size(97, 93);
            this.pbMonkey.TabIndex = 0;
            this.pbMonkey.TabStop = false;
            // 
            // pbMinato
            // 
            this.pbMinato.Location = new System.Drawing.Point(2, 15);
            this.pbMinato.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinato.Name = "pbMinato";
            this.pbMinato.Size = new System.Drawing.Size(97, 93);
            this.pbMinato.TabIndex = 0;
            this.pbMinato.TabStop = false;
            // 
            // pbSonic
            // 
            this.pbSonic.Location = new System.Drawing.Point(2, 11);
            this.pbSonic.Margin = new System.Windows.Forms.Padding(2);
            this.pbSonic.Name = "pbSonic";
            this.pbSonic.Size = new System.Drawing.Size(97, 93);
            this.pbSonic.TabIndex = 0;
            this.pbSonic.TabStop = false;
            // 
            // btnRunRace
            // 
            this.btnRunRace.Location = new System.Drawing.Point(601, 13);
            this.btnRunRace.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunRace.Name = "btnRunRace";
            this.btnRunRace.Size = new System.Drawing.Size(332, 50);
            this.btnRunRace.TabIndex = 1;
            this.btnRunRace.Text = "Run Race";
            this.btnRunRace.UseVisualStyleBackColor = true;
            this.btnRunRace.Click += new System.EventHandler(this.btnRunRace_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel.Controls.Add(this.gameConsole);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.btnRunRace);
            this.panel.Controls.Add(this.label7);
            this.panel.Location = new System.Drawing.Point(2, 553);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1453, 360);
            this.panel.TabIndex = 2;
            // 
            // gameConsole
            // 
            this.gameConsole.FormattingEnabled = true;
            this.gameConsole.HorizontalScrollbar = true;
            this.gameConsole.Location = new System.Drawing.Point(13, 89);
            this.gameConsole.Name = "gameConsole";
            this.gameConsole.Size = new System.Drawing.Size(334, 199);
            this.gameConsole.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPunter);
            this.panel1.Controls.Add(this.btnBet);
            this.panel1.Controls.Add(this.racerList);
            this.panel1.Controls.Add(this.Bet);
            this.panel1.Controls.Add(this.betInput);
            this.panel1.Location = new System.Drawing.Point(1202, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 208);
            this.panel1.TabIndex = 11;
            // 
            // lblPunter
            // 
            this.lblPunter.AutoSize = true;
            this.lblPunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunter.Location = new System.Drawing.Point(3, 11);
            this.lblPunter.Name = "lblPunter";
            this.lblPunter.Size = new System.Drawing.Size(86, 24);
            this.lblPunter.TabIndex = 7;
            this.lblPunter.Text = "Punter\'s";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(29, 138);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(200, 45);
            this.btnBet.TabIndex = 9;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // racerList
            // 
            this.racerList.Location = new System.Drawing.Point(47, 93);
            this.racerList.Name = "racerList";
            this.racerList.Size = new System.Drawing.Size(155, 20);
            this.racerList.TabIndex = 10;
            this.racerList.Text = "Racers";
            // 
            // Bet
            // 
            this.Bet.AutoSize = true;
            this.Bet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bet.Location = new System.Drawing.Point(109, 39);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(40, 24);
            this.Bet.TabIndex = 6;
            this.Bet.Text = "Bet";
            // 
            // betInput
            // 
            this.betInput.Location = new System.Drawing.Point(47, 66);
            this.betInput.Name = "betInput";
            this.betInput.Size = new System.Drawing.Size(155, 20);
            this.betInput.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.declanRacer);
            this.groupBox1.Controls.Add(this.alienRacer);
            this.groupBox1.Controls.Add(this.gerardRacer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.alienWallet);
            this.groupBox1.Controls.Add(this.gerardWallet);
            this.groupBox1.Controls.Add(this.alienBet);
            this.groupBox1.Controls.Add(this.gerardBet);
            this.groupBox1.Controls.Add(this.declanBet);
            this.groupBox1.Controls.Add(this.declanWallet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtnAlien);
            this.groupBox1.Controls.Add(this.rbtnGerard);
            this.groupBox1.Controls.Add(this.rbtnDeclan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(357, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punters";
            // 
            // declanRacer
            // 
            this.declanRacer.AutoSize = true;
            this.declanRacer.Location = new System.Drawing.Point(630, 28);
            this.declanRacer.Name = "declanRacer";
            this.declanRacer.Size = new System.Drawing.Size(0, 25);
            this.declanRacer.TabIndex = 9;
            // 
            // alienRacer
            // 
            this.alienRacer.AutoSize = true;
            this.alienRacer.Location = new System.Drawing.Point(631, 123);
            this.alienRacer.Name = "alienRacer";
            this.alienRacer.Size = new System.Drawing.Size(0, 25);
            this.alienRacer.TabIndex = 9;
            // 
            // gerardRacer
            // 
            this.gerardRacer.AutoSize = true;
            this.gerardRacer.Location = new System.Drawing.Point(631, 75);
            this.gerardRacer.Name = "gerardRacer";
            this.gerardRacer.Size = new System.Drawing.Size(0, 25);
            this.gerardRacer.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Racer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "$";
            // 
            // alienWallet
            // 
            this.alienWallet.AutoSize = true;
            this.alienWallet.Location = new System.Drawing.Point(333, 123);
            this.alienWallet.Name = "alienWallet";
            this.alienWallet.Size = new System.Drawing.Size(58, 25);
            this.alienWallet.TabIndex = 6;
            this.alienWallet.Text = "0.00";
            // 
            // gerardWallet
            // 
            this.gerardWallet.AutoSize = true;
            this.gerardWallet.Location = new System.Drawing.Point(333, 75);
            this.gerardWallet.Name = "gerardWallet";
            this.gerardWallet.Size = new System.Drawing.Size(58, 25);
            this.gerardWallet.TabIndex = 6;
            this.gerardWallet.Text = "0.00";
            // 
            // alienBet
            // 
            this.alienBet.AutoSize = true;
            this.alienBet.Location = new System.Drawing.Point(481, 123);
            this.alienBet.Name = "alienBet";
            this.alienBet.Size = new System.Drawing.Size(58, 25);
            this.alienBet.TabIndex = 6;
            this.alienBet.Text = "0.00";
            // 
            // gerardBet
            // 
            this.gerardBet.AutoSize = true;
            this.gerardBet.Location = new System.Drawing.Point(481, 75);
            this.gerardBet.Name = "gerardBet";
            this.gerardBet.Size = new System.Drawing.Size(58, 25);
            this.gerardBet.TabIndex = 6;
            this.gerardBet.Text = "0.00";
            // 
            // declanBet
            // 
            this.declanBet.AutoSize = true;
            this.declanBet.Location = new System.Drawing.Point(481, 28);
            this.declanBet.Name = "declanBet";
            this.declanBet.Size = new System.Drawing.Size(58, 25);
            this.declanBet.TabIndex = 6;
            this.declanBet.Text = "0.00";
            // 
            // declanWallet
            // 
            this.declanWallet.AutoSize = true;
            this.declanWallet.Location = new System.Drawing.Point(333, 27);
            this.declanWallet.Name = "declanWallet";
            this.declanWallet.Size = new System.Drawing.Size(58, 25);
            this.declanWallet.TabIndex = 6;
            this.declanWallet.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bets placed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wallet";
            // 
            // rbtnAlien
            // 
            this.rbtnAlien.AutoSize = true;
            this.rbtnAlien.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtnAlien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAlien.Location = new System.Drawing.Point(3, 123);
            this.rbtnAlien.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.rbtnAlien.Name = "rbtnAlien";
            this.rbtnAlien.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.rbtnAlien.Size = new System.Drawing.Size(824, 48);
            this.rbtnAlien.TabIndex = 4;
            this.rbtnAlien.TabStop = true;
            this.rbtnAlien.Text = "Alien of the Unknown";
            this.rbtnAlien.UseVisualStyleBackColor = true;
            this.rbtnAlien.CheckedChanged += new System.EventHandler(this.Radiobtn_CheckedChanged);
            // 
            // rbtnGerard
            // 
            this.rbtnGerard.AutoSize = true;
            this.rbtnGerard.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtnGerard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGerard.Location = new System.Drawing.Point(3, 75);
            this.rbtnGerard.Margin = new System.Windows.Forms.Padding(10);
            this.rbtnGerard.Name = "rbtnGerard";
            this.rbtnGerard.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.rbtnGerard.Size = new System.Drawing.Size(824, 48);
            this.rbtnGerard.TabIndex = 2;
            this.rbtnGerard.TabStop = true;
            this.rbtnGerard.Text = "Gerard the Grey";
            this.rbtnGerard.UseVisualStyleBackColor = true;
            this.rbtnGerard.Click += new System.EventHandler(this.Radiobtn_CheckedChanged);
            // 
            // rbtnDeclan
            // 
            this.rbtnDeclan.AutoSize = true;
            this.rbtnDeclan.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbtnDeclan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDeclan.Location = new System.Drawing.Point(3, 27);
            this.rbtnDeclan.Name = "rbtnDeclan";
            this.rbtnDeclan.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.rbtnDeclan.Size = new System.Drawing.Size(824, 48);
            this.rbtnDeclan.TabIndex = 3;
            this.rbtnDeclan.TabStop = true;
            this.rbtnDeclan.Text = "Declan the Engager";
            this.rbtnDeclan.UseVisualStyleBackColor = true;
            this.rbtnDeclan.Click += new System.EventHandler(this.Radiobtn_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Betting Results:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pbSonic);
            this.panel2.Location = new System.Drawing.Point(4, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1437, 132);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.pbMinato);
            this.panel3.Location = new System.Drawing.Point(2, 138);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1439, 135);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.pbMonkey);
            this.panel4.Location = new System.Drawing.Point(2, 277);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1439, 118);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(115, 106);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1299, 93);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel6.Controls.Add(this.pbCt);
            this.panel6.Location = new System.Drawing.Point(2, 399);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1439, 117);
            this.panel6.TabIndex = 6;
            // 
            // pnlTrack
            // 
            this.pnlTrack.Controls.Add(this.panel2);
            this.pnlTrack.Controls.Add(this.panel4);
            this.pnlTrack.Controls.Add(this.panel6);
            this.pnlTrack.Controls.Add(this.panel3);
            this.pnlTrack.Location = new System.Drawing.Point(2, 12);
            this.pnlTrack.Name = "pnlTrack";
            this.pnlTrack.Size = new System.Drawing.Size(1501, 529);
            this.pnlTrack.TabIndex = 7;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Sitka Subheading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(591, 223);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(196, 69);
            this.lblWinner.TabIndex = 101;
            this.lblWinner.Text = "Winner";
            // 
            // btnNextRace
            // 
            this.btnNextRace.Location = new System.Drawing.Point(576, 341);
            this.btnNextRace.Name = "btnNextRace";
            this.btnNextRace.Size = new System.Drawing.Size(236, 66);
            this.btnNextRace.TabIndex = 102;
            this.btnNextRace.Text = "Next Race";
            this.btnNextRace.UseVisualStyleBackColor = true;
            this.btnNextRace.Click += new System.EventHandler(this.btnNextRace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 913);
            this.Controls.Add(this.btnNextRace);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.pnlTrack);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pbCt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonic)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnlTrack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSonic;
        private System.Windows.Forms.PictureBox pbMinato;
        private System.Windows.Forms.PictureBox pbMonkey;
        private System.Windows.Forms.PictureBox pbCt;
        private System.Windows.Forms.Button btnRunRace;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rbtnAlien;
        private System.Windows.Forms.RadioButton rbtnDeclan;
        private System.Windows.Forms.RadioButton rbtnGerard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Bet;
        private System.Windows.Forms.NumericUpDown betInput;
        private System.Windows.Forms.Label lblPunter;
        private System.Windows.Forms.Label alienWallet;
        private System.Windows.Forms.Label gerardWallet;
        private System.Windows.Forms.Label declanWallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label alienBet;
        private System.Windows.Forms.Label gerardBet;
        private System.Windows.Forms.Label declanBet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DomainUpDown racerList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gerardRacer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label declanRacer;
        private System.Windows.Forms.Label alienRacer;
        private System.Windows.Forms.ListBox gameConsole;
        private System.Windows.Forms.Panel pnlTrack;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnNextRace;
        private System.Windows.Forms.Label label7;
    }
}

