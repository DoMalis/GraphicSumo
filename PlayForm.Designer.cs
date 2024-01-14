namespace SumoMVC
{
    partial class PlayForm
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
            this.p1Info = new System.Windows.Forms.Label();
            this.p2Info = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.food = new System.Windows.Forms.PictureBox();
            this.innerRing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).BeginInit();
            this.SuspendLayout();
            // 
            // p1Info
            // 
            this.p1Info.AutoSize = true;
            this.p1Info.BackColor = System.Drawing.Color.Black;
            this.p1Info.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Info.ForeColor = System.Drawing.Color.DarkRed;
            this.p1Info.Location = new System.Drawing.Point(12, 9);
            this.p1Info.Name = "p1Info";
            this.p1Info.Size = new System.Drawing.Size(144, 29);
            this.p1Info.TabIndex = 4;
            this.p1Info.Text = "player1inf";
            // 
            // p2Info
            // 
            this.p2Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p2Info.AutoSize = true;
            this.p2Info.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2Info.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Info.ForeColor = System.Drawing.Color.DarkRed;
            this.p2Info.Location = new System.Drawing.Point(878, 9);
            this.p2Info.Name = "p2Info";
            this.p2Info.Size = new System.Drawing.Size(145, 29);
            this.p2Info.TabIndex = 5;
            this.p2Info.Text = "player2inf";
            // 
            // TimeText
            // 
            this.TimeText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeText.AutoSize = true;
            this.TimeText.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.ForeColor = System.Drawing.Color.DarkRed;
            this.TimeText.Location = new System.Drawing.Point(502, 561);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(101, 35);
            this.TimeText.TabIndex = 7;
            this.TimeText.Text = "timer";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Image = global::SumoMVC.Properties.Resources.red_fotor_bg_remover_20240106135247;
            this.player2.Location = new System.Drawing.Point(870, 313);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(64, 64);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.Transparent;
            this.player1.Image = global::SumoMVC.Properties.Resources.blue_fotor_bg_remover_2024010613440;
            this.player1.Location = new System.Drawing.Point(834, 193);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(64, 64);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.Color.Transparent;
            this.food.Image = global::SumoMVC.Properties.Resources.cheese_burger_cartoon_vector_fotor_bg_remover_202401061577;
            this.food.Location = new System.Drawing.Point(855, 276);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(43, 42);
            this.food.TabIndex = 6;
            this.food.TabStop = false;
            // 
            // innerRing
            // 
            this.innerRing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innerRing.BackColor = System.Drawing.Color.Transparent;
            this.innerRing.Location = new System.Drawing.Point(222, 62);
            this.innerRing.Name = "innerRing";
            this.innerRing.Size = new System.Drawing.Size(592, 484);
            this.innerRing.TabIndex = 3;
            this.innerRing.TabStop = false;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SumoMVC.Properties.Resources._2_sumo_ring_empty_allan_swart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.food);
            this.Controls.Add(this.p2Info);
            this.Controls.Add(this.p1Info);
            this.Controls.Add(this.innerRing);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox innerRing;
        private System.Windows.Forms.Label p1Info;
        private System.Windows.Forms.Label p2Info;
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Timer timer2;
    }
}