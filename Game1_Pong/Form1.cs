using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Game1_Pong
{
    public partial class Form1 : Form
    {

        //INIZIALIZZAZIONE PARAMETRI

        Random rand = new Random();
        SoundPlayer soundPlayer = new SoundPlayer();
        //SoundPlayer effectPlayer = new SoundPlayer();
        
        static Form2 dlg = new Form2();

        bool loopSound = dlg.LoopCheck;
        int currentTrack = 0;


        int ballX = 10;
        int ballY = 0;

        int p1Points = 0;
        int aiPoints = 0;

        int aiMoveMultiplier;
        int aiLimit;

        float resetCount = 0f;

        bool playing = false;
        bool resetGame = false;

        bool p1Idle = false;
        bool aiIdle = false;

        bool ballHitP1 = false;
        bool ballHitAI = false;

        bool p1Win = false;
        bool aiWin = false;

        string[] aiNames =
        {
            "Coglione",
            "L'imbecillatore",
            "Cassiere della LIDL",
            "Macchinetta del caffé",
            "Tostapane",
            "Il tuo vicino di casa",
            "La tua ciabatta destra",
            "I piedi di gesù"
        };

        bool funnyTextRand = false;
        string funnyTextResult;
        string[] funnyText =
        {
            "Mele",
            "Pere",
            "Metri",
            "Zucchine",
            "Decilitri",
            "Braccia",
            "Secondi",
            "Millepiedi",
            "Anni Luce",
            "C°",
            "F°",
            "K°",
            "Tarzanelli"
        };

        object[] waveFiles =
        {
            Resource1.Ethan94FL___Boss_Fight,
            Resource1.Ethan94FL___Frenesia,
            Resource1.Ethan94FL___Go_On,
            Resource1.Ethan94FL___Happy_Birb,
            Resource1.Ethan94FL___Over_Power
        };

        string[] waveFilesName =
        {
            "Ethan94FL - Boss Fight",
            "Ethan94FL - Frenesia",
            "Ethan94FL - Go On",
            "Ethan94FL - Happy Birb",
            "Ethan94FL - Over Power"
        };

        public Form1()
        {
            InitializeComponent();
        }


        BufferedGraphicsContext buffered = new BufferedGraphicsContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            bool selectDifficulty = false;
            dlg.Location = new Point(ClientRectangle.Location.X, ClientRectangle.Location.Y);
            dlg.ShowDialog();
            var result = rand.Next(0, aiNames.Length);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            if (dlg.Difficulty == 1)
            {
                ballY = 3;
                ballX = 5;
                aiMoveMultiplier = 2;
                aiLimit = 65;
                ball.Size = new Size(17, 17);
                p1.Size = new Size(10, 190);
                AI.Size = new Size(10, 190);
                selectDifficulty = true;
            }
            else if (dlg.Difficulty == 2)
            {

                ballY = 6;
                ballX = 5;
                aiMoveMultiplier = 4;
                aiLimit = 5;
                ball.Size = new Size(15, 15);
                p1.Size = new Size(10, 170);
                AI.Size = new Size(10, 170);
                selectDifficulty = true;
            }
            else if (dlg.Difficulty == 3)
            {
                ballY = 6;
                ballX = 8;
                aiMoveMultiplier = 5;
                aiLimit = 20;
                ball.Size = new Size(13, 13);
                p1.Size = new Size(10, 150);
                AI.Size = new Size(10, 150);
                selectDifficulty = true;
            }
            else if (dlg.Difficulty == 4)
            {
                ballY = 8;
                ballX = 10;
                aiMoveMultiplier = 7;
                aiLimit = 14;
                ball.Size = new Size(13, 13);
                p1.Size = new Size(10, 120);
                AI.Size = new Size(10, 120);
                selectDifficulty = true;
            }
            else
            {
                Close();
            }

            if (selectDifficulty)
            {
                timer1.Enabled = true;
                timer1.Interval = 10;
                timer1.Start();

                timer2.Enabled = true;
                timer2.Interval = 10;
                timer2.Start();

                timer3.Start();

                label1.Visible = resetGame;

                p1Idle = true;
            }
            else
            {
                MessageBox.Show("ERRORE!");
            }

            if (dlg.MusicCheck)
            {
                if (dlg.LoopCheck)
                {
                    soundPlayer.Stream = (System.IO.Stream)waveFiles[currentTrack];
                    soundPlayer.PlayLooping();
                }
                else
                {
                    soundPlayer.Stream = (System.IO.Stream)waveFiles[currentTrack];
                    soundPlayer.Play();
                }
                
                Text = $"[{dlg.Nick}] VS. [{aiNames[result]}] - L'epica battaglia! [COMANDI: Mouse Sinistro= Lancia Pallina | Mouse Destro = Traccia Successiva]";
            }
            else
            {
                Text = $"[{dlg.Nick}] VS. [{aiNames[result]}] - L'epica battaglia! [COMANDI: Mouse Sinistro= Lancia Pallina]";
            }
            label2.Text = "Stai ascoltando: " + $"{currentTrack + 1}# " + waveFilesName[currentTrack];
            loopSound = dlg.LoopCheck;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] ballLocation = { ball.Location.X, ball.Location.Y };
            int ballCenter = ball.ClientRectangle.Height - (ball.Size.Height / 2);
            int p1Center = p1.ClientRectangle.Height - (p1.Size.Height / 2);
            int aiCenter = AI.ClientRectangle.Height - (AI.Size.Height / 2);

            p1.Location = new Point(p1.Location.X, PointToClient(Cursor.Position).Y - p1Center);

            if (p1Idle)
            {
                ball.Location = new Point(p1.Location.X + 15, p1.Location.Y + p1Center - ballCenter);
            }

            if (aiIdle)
            {
                ball.Location = new Point(AI.Location.X + 15, AI.Location.Y + aiCenter - ballCenter);
            }


            if (playing)
            {

                if (ball.Bounds.IntersectsWith(p1.Bounds))
                {
                    //effectPlayer.Stream = null;
                    //effectPlayer.Stop();
                    //effectPlayer.Stream = Resource1.clack_effect;
                    //effectPlayer.Play();
                    ballHitP1 = true;
                    ballHitAI = false;
                }
                else if (ball.Bounds.IntersectsWith(AI.Bounds))
                {
                    //effectPlayer.Stream = null;
                    //effectPlayer.Stop();
                    //effectPlayer.Stream = Resource1.clack_effect;
                    //effectPlayer.Play();
                    ballHitP1 = false;
                    ballHitAI = true;
                }

                if (ballLocation[1] <= 0)
                {
                    ballY = -ballY;
                }
                else if (ballLocation[1] >= Size.Height - 50)
                {
                    ballY = -ballY;
                }

                if (ballHitP1)
                {
                    ball.Location = new Point(ballLocation[0] += ballX, ballLocation[1] + ballY);
                }
                else if (ballHitAI)
                {
                    ball.Location = new Point(ballLocation[0] -= ballX, ballLocation[1] + ballY);
                }
                else
                {
                    ball.Location = new Point(ballLocation[0] += ballX, ballLocation[1] + ballY);
                }

                if (ball.Location.X <= 0)
                {
                    aiWin = true;
                    playing = false;
                    ballHitP1 = false;
                    ballHitAI = false;
                }
                else if (ball.Location.X >= ClientSize.Width)
                {
                    p1Win = true;
                    playing = false;
                    ballHitP1 = false;
                    ballHitAI = false;
                }
                if (p1Win)
                {
                    //effectPlayer.Stream = Resource1.p1_point;
                    //effectPlayer.Play();
                    p1Points++;
                    p1Point.Text = $"{p1Points:0000000000}";
                    p1Win = false;
                    resetGame = true;
                    funnyTextRand = true;
                    resetCount = 3f;
                }
                else if (aiWin)
                {
                    //effectPlayer.Stream = Resource1.AI_point;
                    //effectPlayer.Play();
                    aiPoints++;
                    aiPoint.Text = $"{aiPoints:0000000000}";
                    aiWin = false;
                    resetGame = true;
                    funnyTextRand = true;
                    resetCount = 3f;
                }

            }

            if (resetGame)
            {
                if (resetCount >= 0.0f)
                {
                    if (funnyTextRand)
                    {
                        var result = rand.Next(0, funnyText.Length);
                        funnyTextResult = funnyText[result];
                        funnyTextRand = false;
                    }
                    resetCount -= 0.035f;
                    label1.Text = $"\nReset in {resetCount:0.0} {funnyTextResult}";
                }
                else
                {
                    resetGame = false;
                    p1Idle = true;
                    //effectPlayer.Stream.Position = 0;
                    //effectPlayer.Stream = null;
                    //effectPlayer.Stop();
                }
            }
            label1.Visible = resetGame;
        }

        int aiMove = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            int ballCenter = ball.ClientRectangle.Height - (ball.Size.Height / 2);
            int aiCenter = AI.ClientRectangle.Height - (AI.Size.Height / 2);
            if (((ball.Location.Y - aiCenter) + ballCenter) > (AI.Location.Y + ballCenter) + aiLimit)
            {
                aiMove++;
            }
            else if (((ball.Location.Y - aiCenter) + ballCenter) < (AI.Location.Y + ballCenter) - aiLimit)
            {
                aiMove--;
            }
            else if (((ball.Location.Y - aiCenter) + ballCenter) == (AI.Location.Y + ballCenter))
            {
                AI.Location = new Point(AI.Location.X, (ball.Location.Y - aiCenter) + ballCenter);
            }
            AI.Location = new Point(AI.Location.X, aiMove * aiMoveMultiplier);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !playing && !resetGame)
            {

                int result = rand.Next(0, 11);
                if (result < 5)
                {
                    ballY = +ballY;
                }
                else
                {
                    ballY = -ballY;
                }
                playing = true;
                p1Idle = false;
            }

            if (e.Button == MouseButtons.Right && dlg.MusicCheck)
            {

                if (currentTrack >= waveFiles.Length - 1)
                {
                    currentTrack = 0;
                }
                else
                {
                    currentTrack++;
                }

                try
                {
                    soundPlayer.Stream.Position = 0;
                    soundPlayer.Stream = null;
                    soundPlayer.Stream = (System.IO.Stream)waveFiles[currentTrack];
                    loopSound = dlg.LoopCheck;
                    if (loopSound)
                    {
                        soundPlayer.Stop();
                        soundPlayer.PlayLooping();
                    }
                    else
                    {
                        soundPlayer.Stop();
                        soundPlayer.Play();
                    }
                    label2.Text = "Stai ascoltando: " + $"{currentTrack + 1}# " + waveFilesName[currentTrack];
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }
        }
    }
}
