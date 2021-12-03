
namespace TicTakToe
{
    partial class Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnS1 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.btnS5 = new System.Windows.Forms.Button();
            this.btnS6 = new System.Windows.Forms.Button();
            this.btnS3 = new System.Windows.Forms.Button();
            this.btnS4 = new System.Windows.Forms.Button();
            this.btnS8 = new System.Windows.Forms.Button();
            this.btnS7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(54, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(588, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnNewGame);
            this.panel3.Location = new System.Drawing.Point(268, 506);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 101);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player 2:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(271, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(120, 53);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Winner:";
            // 
            // btnS1
            // 
            this.btnS1.Location = new System.Drawing.Point(203, 153);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(100, 80);
            this.btnS1.TabIndex = 3;
            this.btnS1.UseVisualStyleBackColor = true;
            this.btnS1.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(203, 257);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(100, 80);
            this.btnS2.TabIndex = 4;
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS5
            // 
            this.btnS5.Location = new System.Drawing.Point(362, 257);
            this.btnS5.Name = "btnS5";
            this.btnS5.Size = new System.Drawing.Size(100, 80);
            this.btnS5.TabIndex = 5;
            this.btnS5.UseVisualStyleBackColor = true;
            this.btnS5.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS6
            // 
            this.btnS6.Location = new System.Drawing.Point(362, 359);
            this.btnS6.Name = "btnS6";
            this.btnS6.Size = new System.Drawing.Size(100, 80);
            this.btnS6.TabIndex = 6;
            this.btnS6.UseVisualStyleBackColor = true;
            this.btnS6.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS3
            // 
            this.btnS3.Location = new System.Drawing.Point(203, 359);
            this.btnS3.Name = "btnS3";
            this.btnS3.Size = new System.Drawing.Size(100, 80);
            this.btnS3.TabIndex = 7;
            this.btnS3.UseVisualStyleBackColor = true;
            this.btnS3.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS4
            // 
            this.btnS4.Location = new System.Drawing.Point(362, 153);
            this.btnS4.Name = "btnS4";
            this.btnS4.Size = new System.Drawing.Size(100, 80);
            this.btnS4.TabIndex = 8;
            this.btnS4.UseVisualStyleBackColor = true;
            this.btnS4.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS8
            // 
            this.btnS8.Location = new System.Drawing.Point(518, 257);
            this.btnS8.Name = "btnS8";
            this.btnS8.Size = new System.Drawing.Size(100, 80);
            this.btnS8.TabIndex = 9;
            this.btnS8.UseVisualStyleBackColor = true;
            this.btnS8.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS7
            // 
            this.btnS7.Location = new System.Drawing.Point(518, 153);
            this.btnS7.Name = "btnS7";
            this.btnS7.Size = new System.Drawing.Size(100, 80);
            this.btnS7.TabIndex = 10;
            this.btnS7.UseVisualStyleBackColor = true;
            this.btnS7.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(518, 359);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 80);
            this.button10.TabIndex = 11;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 636);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnS7);
            this.Controls.Add(this.btnS8);
            this.Controls.Add(this.btnS4);
            this.Controls.Add(this.btnS3);
            this.Controls.Add(this.btnS6);
            this.Controls.Add(this.btnS5);
            this.Controls.Add(this.btnS2);
            this.Controls.Add(this.btnS1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Game";
            this.Text = "Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.Button btnS5;
        private System.Windows.Forms.Button btnS6;
        private System.Windows.Forms.Button btnS3;
        private System.Windows.Forms.Button btnS4;
        private System.Windows.Forms.Button btnS8;
        private System.Windows.Forms.Button btnS7;
        private System.Windows.Forms.Button button10;
    }
}