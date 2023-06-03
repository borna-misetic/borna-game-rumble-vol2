namespace Rumble
{
    partial class GameSelect
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
            this.btnGameOne = new System.Windows.Forms.Button();
            this.btnGameTwo = new System.Windows.Forms.Button();
            this.btnGameThree = new System.Windows.Forms.Button();
            this.btnGameFour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGameOne
            // 
            this.btnGameOne.Location = new System.Drawing.Point(340, 157);
            this.btnGameOne.Name = "btnGameOne";
            this.btnGameOne.Size = new System.Drawing.Size(75, 23);
            this.btnGameOne.TabIndex = 0;
            this.btnGameOne.Text = "Pong";
            this.btnGameOne.UseVisualStyleBackColor = true;
            this.btnGameOne.Click += new System.EventHandler(this.btnGameOne_Click);
            // 
            // btnGameTwo
            // 
            this.btnGameTwo.Location = new System.Drawing.Point(340, 186);
            this.btnGameTwo.Name = "btnGameTwo";
            this.btnGameTwo.Size = new System.Drawing.Size(75, 23);
            this.btnGameTwo.TabIndex = 1;
            this.btnGameTwo.Text = "Frogger";
            this.btnGameTwo.UseVisualStyleBackColor = true;
            this.btnGameTwo.Click += new System.EventHandler(this.btnGameTwo_Click);
            // 
            // btnGameThree
            // 
            this.btnGameThree.Location = new System.Drawing.Point(340, 215);
            this.btnGameThree.Name = "btnGameThree";
            this.btnGameThree.Size = new System.Drawing.Size(75, 23);
            this.btnGameThree.TabIndex = 2;
            this.btnGameThree.Text = "Flappy Bird";
            this.btnGameThree.UseVisualStyleBackColor = true;
            this.btnGameThree.Click += new System.EventHandler(this.btnGameThree_Click);
            // 
            // btnGameFour
            // 
            this.btnGameFour.Location = new System.Drawing.Point(340, 244);
            this.btnGameFour.Name = "btnGameFour";
            this.btnGameFour.Size = new System.Drawing.Size(75, 23);
            this.btnGameFour.TabIndex = 3;
            this.btnGameFour.Text = "Snake";
            this.btnGameFour.UseVisualStyleBackColor = true;
            this.btnGameFour.Click += new System.EventHandler(this.btnGameFour_Click);
            // 
            // GameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnGameFour);
            this.Controls.Add(this.btnGameThree);
            this.Controls.Add(this.btnGameTwo);
            this.Controls.Add(this.btnGameOne);
            this.Name = "GameSelect";
            this.Text = "GameSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGameOne;
        private System.Windows.Forms.Button btnGameTwo;
        private System.Windows.Forms.Button btnGameThree;
        private System.Windows.Forms.Button btnGameFour;
    }
}