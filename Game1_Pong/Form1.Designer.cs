
namespace Game1_Pong
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p1Point = new System.Windows.Forms.Label();
            this.aiPoint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.AI = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // p1Point
            // 
            this.p1Point.AutoSize = true;
            this.p1Point.BackColor = System.Drawing.Color.Transparent;
            this.p1Point.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1Point.Enabled = false;
            this.p1Point.Font = new System.Drawing.Font("VCR OSD Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Point.ForeColor = System.Drawing.Color.LawnGreen;
            this.p1Point.Location = new System.Drawing.Point(6, 7);
            this.p1Point.Name = "p1Point";
            this.p1Point.Size = new System.Drawing.Size(174, 29);
            this.p1Point.TabIndex = 1;
            this.p1Point.Text = "0000000000";
            this.p1Point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aiPoint
            // 
            this.aiPoint.AutoSize = true;
            this.aiPoint.BackColor = System.Drawing.Color.Transparent;
            this.aiPoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aiPoint.Enabled = false;
            this.aiPoint.Font = new System.Drawing.Font("VCR OSD Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiPoint.ForeColor = System.Drawing.Color.LawnGreen;
            this.aiPoint.Location = new System.Drawing.Point(830, 7);
            this.aiPoint.Name = "aiPoint";
            this.aiPoint.Size = new System.Drawing.Size(174, 29);
            this.aiPoint.TabIndex = 1;
            this.aiPoint.Text = "0000000000";
            this.aiPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(359, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label3";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1008, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "label3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 500;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Orange;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ball.Image = global::Game1_Pong.Properties.Resources.Sprite_ball;
            this.ball.Location = new System.Drawing.Point(149, 202);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // AI
            // 
            this.AI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AI.BackColor = System.Drawing.Color.Yellow;
            this.AI.BackgroundImage = global::Game1_Pong.Properties.Resources.Sprite_barr;
            this.AI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AI.Location = new System.Drawing.Point(932, 178);
            this.AI.Name = "AI";
            this.AI.Size = new System.Drawing.Size(10, 150);
            this.AI.TabIndex = 0;
            this.AI.TabStop = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Yellow;
            this.p1.BackgroundImage = global::Game1_Pong.Properties.Resources.Sprite_barr;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.ErrorImage = null;
            this.p1.Image = global::Game1_Pong.Properties.Resources.Sprite_barr;
            this.p1.InitialImage = global::Game1_Pong.Properties.Resources.Sprite_barr;
            this.p1.Location = new System.Drawing.Point(74, 178);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(10, 150);
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.AI);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1Point);
            this.Controls.Add(this.aiPoint);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox AI;
        private System.Windows.Forms.Label p1Point;
        private System.Windows.Forms.Label aiPoint;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
    }
}

