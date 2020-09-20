namespace PacMan
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Coral;
            this.buttonStart.Location = new System.Drawing.Point(218, 142);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(256, 98);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START GAME";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.Yellow;
            this.Hero.Location = new System.Drawing.Point(158, 33);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(65, 60);
            this.Hero.TabIndex = 1;
            this.Hero.TabStop = false;
            this.Hero.Visible = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.SteelBlue;
            this.Enemy.Location = new System.Drawing.Point(311, 33);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(65, 60);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            this.Enemy.Visible = false;
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.Green;
            this.Food.Location = new System.Drawing.Point(466, 33);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(65, 60);
            this.Food.TabIndex = 3;
            this.Food.TabStop = false;
            this.Food.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 381);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Burbank Big Cd Bk", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Food;
    }
}

