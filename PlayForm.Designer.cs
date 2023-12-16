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
            this.ringSumo = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.innerRing = new System.Windows.Forms.PictureBox();
            this.p1Info = new System.Windows.Forms.Label();
            this.p2Info = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.PictureBox();
            this.TimeText = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ringSumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            this.SuspendLayout();
            // 
            // ringSumo
            // 
            this.ringSumo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ringSumo.Location = new System.Drawing.Point(205, 50);
            this.ringSumo.Name = "ringSumo";
            this.ringSumo.Size = new System.Drawing.Size(388, 382);
            this.ringSumo.TabIndex = 2;
            this.ringSumo.TabStop = false;
            // 
            // player1
            // 
            this.player1.Image = global::SumoMVC.Properties.Resources.player_23;
            this.player1.Location = new System.Drawing.Point(695, 159);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(64, 64);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.Image = global::SumoMVC.Properties.Resources.player_23;
            this.player2.Location = new System.Drawing.Point(695, 299);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(64, 64);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            // 
            // innerRing
            // 
            this.innerRing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.innerRing.Location = new System.Drawing.Point(236, 79);
            this.innerRing.Name = "innerRing";
            this.innerRing.Size = new System.Drawing.Size(321, 321);
            this.innerRing.TabIndex = 3;
            this.innerRing.TabStop = false;
            // 
            // p1Info
            // 
            this.p1Info.AutoSize = true;
            this.p1Info.Location = new System.Drawing.Point(12, 9);
            this.p1Info.Name = "p1Info";
            this.p1Info.Size = new System.Drawing.Size(0, 16);
            this.p1Info.TabIndex = 4;
            // 
            // p2Info
            // 
            this.p2Info.AutoSize = true;
            this.p2Info.Location = new System.Drawing.Point(678, 23);
            this.p2Info.Name = "p2Info";
            this.p2Info.Size = new System.Drawing.Size(0, 16);
            this.p2Info.TabIndex = 5;
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.food.Location = new System.Drawing.Point(706, 252);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(24, 22);
            this.food.TabIndex = 6;
            this.food.TabStop = false;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.Location = new System.Drawing.Point(374, 439);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(0, 16);
            this.TimeText.TabIndex = 7;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 460);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.food);
            this.Controls.Add(this.p2Info);
            this.Controls.Add(this.p1Info);
            this.Controls.Add(this.innerRing);
            this.Controls.Add(this.ringSumo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ringSumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
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