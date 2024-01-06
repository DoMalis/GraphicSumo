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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeInfo = new System.Windows.Forms.Label();
            this.player1Info = new System.Windows.Forms.Label();
            this.player2Info = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.PictureBox();
            this.obstacle3 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.innerRing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeInfo
            // 
            this.timeInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeInfo.AutoSize = true;
            this.timeInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeInfo.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.timeInfo.Location = new System.Drawing.Point(484, 556);
            this.timeInfo.Name = "timeInfo";
            this.timeInfo.Size = new System.Drawing.Size(89, 29);
            this.timeInfo.TabIndex = 9;
            this.timeInfo.Text = "label1";
            // 
            // player1Info
            // 
            this.player1Info.AutoSize = true;
            this.player1Info.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1Info.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Info.ForeColor = System.Drawing.Color.DarkRed;
            this.player1Info.Location = new System.Drawing.Point(28, 9);
            this.player1Info.Name = "player1Info";
            this.player1Info.Size = new System.Drawing.Size(89, 29);
            this.player1Info.TabIndex = 11;
            this.player1Info.Text = "label1";
            // 
            // player2Info
            // 
            this.player2Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Info.AutoSize = true;
            this.player2Info.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player2Info.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Info.ForeColor = System.Drawing.Color.DarkRed;
            this.player2Info.Location = new System.Drawing.Point(806, 9);
            this.player2Info.Name = "player2Info";
            this.player2Info.Size = new System.Drawing.Size(89, 29);
            this.player2Info.TabIndex = 12;
            this.player2Info.Text = "label1";
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.Color.Transparent;
            this.food.Image = global::SumoMVC.Properties.Resources.cheese_burger_cartoon_vector_fotor_bg_remover_202401061577;
            this.food.Location = new System.Drawing.Point(940, 89);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(40, 40);
            this.food.TabIndex = 10;
            this.food.TabStop = false;
            // 
            // obstacle3
            // 
            this.obstacle3.Image = global::SumoMVC.Properties.Resources.block_05;
            this.obstacle3.Location = new System.Drawing.Point(940, 334);
            this.obstacle3.Name = "obstacle3";
            this.obstacle3.Size = new System.Drawing.Size(64, 64);
            this.obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle3.TabIndex = 8;
            this.obstacle3.TabStop = false;
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::SumoMVC.Properties.Resources.block_05;
            this.obstacle2.Location = new System.Drawing.Point(940, 196);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(64, 64);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 7;
            this.obstacle2.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::SumoMVC.Properties.Resources.block_05;
            this.obstacle1.Location = new System.Drawing.Point(940, 266);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(64, 64);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 6;
            this.obstacle1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = global::SumoMVC.Properties.Resources.blue_fotor_bg_remover_2024010613440;
            this.player2.Location = new System.Drawing.Point(752, 479);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(64, 64);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player2.TabIndex = 5;
            this.player2.TabStop = false;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::SumoMVC.Properties.Resources.red_fotor_bg_remover_20240106135247;
            this.player1.Location = new System.Drawing.Point(221, 56);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(64, 64);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1.TabIndex = 4;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // innerRing
            // 
            this.innerRing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innerRing.BackColor = System.Drawing.Color.Transparent;
            this.innerRing.Location = new System.Drawing.Point(221, 56);
            this.innerRing.Name = "innerRing";
            this.innerRing.Size = new System.Drawing.Size(595, 487);
            this.innerRing.TabIndex = 3;
            this.innerRing.TabStop = false;
            // 
            // PlayObstacleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SumoMVC.Properties.Resources._2_sumo_ring_empty_allan_swart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 603);
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
            this.Name = "PlayObstacleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayObstacleForm";
            this.Load += new System.EventHandler(this.PlayObstacleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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