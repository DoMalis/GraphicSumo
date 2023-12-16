namespace SumoMVC
{
    partial class PlayObstacleForm
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
            this.components = new System.ComponentModel.Container();
            this.sumoRing = new System.Windows.Forms.PictureBox();
            this.innerRing = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeInfo = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.PictureBox();
            this.player1Info = new System.Windows.Forms.Label();
            this.player2Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumoRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            this.SuspendLayout();
            // 
            // sumoRing
            // 
            this.sumoRing.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sumoRing.Location = new System.Drawing.Point(198, 53);
            this.sumoRing.Name = "sumoRing";
            this.sumoRing.Size = new System.Drawing.Size(403, 369);
            this.sumoRing.TabIndex = 2;
            this.sumoRing.TabStop = false;
            // 
            // innerRing
            // 
            this.innerRing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.innerRing.Location = new System.Drawing.Point(209, 70);
            this.innerRing.Name = "innerRing";
            this.innerRing.Size = new System.Drawing.Size(379, 332);
            this.innerRing.TabIndex = 3;
            this.innerRing.TabStop = false;
            // 
            // player1
            // 
            this.player1.Image = global::SumoMVC.Properties.Resources.player_23;
            this.player1.Location = new System.Drawing.Point(701, 270);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(64, 64);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1.TabIndex = 4;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // player2
            // 
            this.player2.Image = global::SumoMVC.Properties.Resources.player_23;
            this.player2.Location = new System.Drawing.Point(631, 196);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(64, 64);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player2.TabIndex = 5;
            this.player2.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::SumoMVC.Properties.Resources.block_05;
            this.obstacle1.Location = new System.Drawing.Point(701, 130);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(64, 64);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 6;
            this.obstacle1.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::SumoMVC.Properties.Resources.block_05;
            this.obstacle2.Location = new System.Drawing.Point(631, 130);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(64, 64);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 7;
            this.obstacle2.TabStop = false;
            // 
            // obstacle3
            // 
            this.obstacle3.Image = global::SumoMVC.Properties.Resources.block_05;
            this.obstacle3.Location = new System.Drawing.Point(701, 200);
            this.obstacle3.Name = "obstacle3";
            this.obstacle3.Size = new System.Drawing.Size(64, 64);
            this.obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle3.TabIndex = 8;
            this.obstacle3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeInfo
            // 
            this.timeInfo.AutoSize = true;
            this.timeInfo.Location = new System.Drawing.Point(364, 425);
            this.timeInfo.Name = "timeInfo";
            this.timeInfo.Size = new System.Drawing.Size(44, 16);
            this.timeInfo.TabIndex = 9;
            this.timeInfo.Text = "label1";
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.food.Location = new System.Drawing.Point(607, 266);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(24, 21);
            this.food.TabIndex = 10;
            this.food.TabStop = false;
            // 
            // player1Info
            // 
            this.player1Info.AutoSize = true;
            this.player1Info.Location = new System.Drawing.Point(31, 25);
            this.player1Info.Name = "player1Info";
            this.player1Info.Size = new System.Drawing.Size(44, 16);
            this.player1Info.TabIndex = 11;
            this.player1Info.Text = "label1";
            // 
            // player2Info
            // 
            this.player2Info.AutoSize = true;
            this.player2Info.Location = new System.Drawing.Point(651, 25);
            this.player2Info.Name = "player2Info";
            this.player2Info.Size = new System.Drawing.Size(44, 16);
            this.player2Info.TabIndex = 12;
            this.player2Info.Text = "label1";
            // 
            // PlayObstacleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2Info);
            this.Controls.Add(this.player1Info);
            this.Controls.Add(this.food);
            this.Controls.Add(this.timeInfo);
            this.Controls.Add(this.obstacle3);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.innerRing);
            this.Controls.Add(this.sumoRing);
            this.Name = "PlayObstacleForm";
            this.Text = "PlayObstacleForm";
            this.Load += new System.EventHandler(this.PlayObstacleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sumoRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox sumoRing;
        private System.Windows.Forms.PictureBox innerRing;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeInfo;
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.Label player1Info;
        private System.Windows.Forms.Label player2Info;
    }
}