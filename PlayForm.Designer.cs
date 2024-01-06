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
            this.ringSumo = new System.Windows.Forms.PictureBox();
            this.innerRing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringSumo)).BeginInit();
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
            this.p1Info.Size = new System.Drawing.Size(0, 29);
            this.p1Info.TabIndex = 4;
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
            this.p2Info.Size = new System.Drawing.Size(0, 29);
            this.p2Info.TabIndex = 5;
            // 
            // TimeText
            // 
            this.TimeText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeText.AutoSize = true;
            this.TimeText.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeText.ForeColor = System.Drawing.Color.DarkRed;
            this.TimeText.Location = new System.Drawing.Point(502, 561);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(0, 35);
            this.TimeText.TabIndex = 7;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.BurlyWood;
            this.player2.Image = global::SumoMVC.Properties.Resources.red_fotor_bg_remover_20240106135247;
            this.player2.Location = new System.Drawing.Point(834, 323);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(64, 64);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.BurlyWood;
            this.player1.Image = global::SumoMVC.Properties.Resources.blue_fotor_bg_remover_2024010613440;
            this.player1.Location = new System.Drawing.Point(834, 193);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(64, 64);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.food.Location = new System.Drawing.Point(854, 274);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(24, 22);
            this.food.TabIndex = 6;
            this.food.TabStop = false;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // ringSumo
            // 
            this.ringSumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ringSumo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ringSumo.BackgroundImage = global::SumoMVC.Properties.Resources._2_sumo_ring_empty_allan_swart;
            this.ringSumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ringSumo.Location = new System.Drawing.Point(153, 77);
            this.ringSumo.Name = "ringSumo";
            this.ringSumo.Size = new System.Drawing.Size(736, 481);
            this.ringSumo.TabIndex = 2;
            this.ringSumo.TabStop = false;
            // 
            // innerRing
            // 
            this.innerRing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innerRing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.innerRing.Location = new System.Drawing.Point(310, 121);
            this.innerRing.Name = "innerRing";
            this.innerRing.Size = new System.Drawing.Size(423, 392);
            this.innerRing.TabIndex = 3;
            this.innerRing.TabStop = false;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.food);
            this.Controls.Add(this.p2Info);
            this.Controls.Add(this.p1Info);
            this.Controls.Add(this.ringSumo);
            this.Controls.Add(this.innerRing);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ringSumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox ringSumo;
        private System.Windows.Forms.PictureBox innerRing;
        private System.Windows.Forms.Label p1Info;
        private System.Windows.Forms.Label p2Info;
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Timer timer2;
    }
}