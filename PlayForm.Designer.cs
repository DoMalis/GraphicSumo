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
            this.ringSumo = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.innerRing = new System.Windows.Forms.PictureBox();
            this.p1Info = new System.Windows.Forms.Label();
            this.p2Info = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ringSumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innerRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            this.SuspendLayout();
            // 
            // ringSumo
            // 
            this.ringSumo.Image = global::SumoMVC.Properties.Resources.SumoRing;
            this.ringSumo.Location = new System.Drawing.Point(199, 50);
            this.ringSumo.Name = "ringSumo";
            this.ringSumo.Size = new System.Drawing.Size(394, 376);
            this.ringSumo.TabIndex = 2;
            this.ringSumo.TabStop = false;
            // 
            // player1
            // 
            this.player1.Image = global::SumoMVC.Properties.Resources.player_23;
            this.player1.Location = new System.Drawing.Point(246, 83);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(64, 64);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.Image = global::SumoMVC.Properties.Resources.player_23;
            this.player2.Location = new System.Drawing.Point(492, 331);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(64, 64);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            // 
            // innerRing
            // 
            this.innerRing.Location = new System.Drawing.Point(246, 83);
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
            this.p2Info.Location = new System.Drawing.Point(759, 13);
            this.p2Info.Name = "p2Info";
            this.p2Info.Size = new System.Drawing.Size(0, 16);
            this.p2Info.TabIndex = 5;
            // 
            // food
            // 
            this.food.Image = global::SumoMVC.Properties.Resources.environment_10;
            this.food.Location = new System.Drawing.Point(695, 229);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(64, 64);
            this.food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food.TabIndex = 6;
            this.food.TabStop = false;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(815, 460);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.food);
            this.Controls.Add(this.p2Info);
            this.Controls.Add(this.p1Info);
            this.Controls.Add(this.ringSumo);
            this.Controls.Add(this.innerRing);
            this.ForeColor = System.Drawing.SystemColors.Control;
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
    }
}