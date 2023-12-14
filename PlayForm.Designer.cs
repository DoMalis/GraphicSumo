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
            this.player2 = new System.Windows.Forms.PictureBox();
            this.borders = new System.Windows.Forms.PictureBox();
            this.food = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // player2
            // 
            this.player2.Image = global::SumoMVC.Properties.Resources.player_23;
            this.player2.Location = new System.Drawing.Point(285, 74);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(56, 60);
            this.player2.TabIndex = 7;
            this.player2.TabStop = false;
            // 
            // borders
            // 
            this.borders.Image = global::SumoMVC.Properties.Resources.block_05;
            this.borders.Location = new System.Drawing.Point(126, 144);
            this.borders.Name = "borders";
            this.borders.Size = new System.Drawing.Size(65, 64);
            this.borders.TabIndex = 6;
            this.borders.TabStop = false;
            this.borders.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // food
            // 
            this.food.Image = global::SumoMVC.Properties.Resources.environment_10;
            this.food.Location = new System.Drawing.Point(589, 200);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(64, 64);
            this.food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food.TabIndex = 5;
            this.food.TabStop = false;
            // 
            // floor
            // 
            this.floor.Image = global::SumoMVC.Properties.Resources.ground_06;
            this.floor.Location = new System.Drawing.Point(456, 158);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(63, 50);
            this.floor.TabIndex = 4;
            this.floor.TabStop = false;
            this.floor.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // player1
            // 
            this.player1.Image = global::SumoMVC.Properties.Resources.player_23;
            this.player1.Location = new System.Drawing.Point(170, 230);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(56, 60);
            this.player1.TabIndex = 1;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.borders);
            this.Controls.Add(this.food);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.player1);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.PictureBox borders;
        private System.Windows.Forms.PictureBox player2;
    }
}