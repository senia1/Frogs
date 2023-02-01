namespace Game_Frogs
{
    partial class WinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.WinLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.questionRestartLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinLabel.Location = new System.Drawing.Point(239, 21);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(170, 27);
            this.WinLabel.TabIndex = 0;
            this.WinLabel.Text = "Congratulations!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_Frogs.Properties.Resources.KingFrog;
            this.pictureBox1.Location = new System.Drawing.Point(100, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextLabel.Location = new System.Drawing.Point(86, 439);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(476, 27);
            this.resultTextLabel.TabIndex = 2;
            this.resultTextLabel.Text = "You won in the minimum number of moves: 24!";
            // 
            // questionRestartLabel
            // 
            this.questionRestartLabel.AutoSize = true;
            this.questionRestartLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionRestartLabel.Location = new System.Drawing.Point(205, 500);
            this.questionRestartLabel.Name = "questionRestartLabel";
            this.questionRestartLabel.Size = new System.Drawing.Size(244, 22);
            this.questionRestartLabel.TabIndex = 3;
            this.questionRestartLabel.Text = "Would you like to play again?";
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.GreenYellow;
            this.yesButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesButton.Location = new System.Drawing.Point(73, 493);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(112, 34);
            this.yesButton.TabIndex = 4;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.GreenYellow;
            this.noButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noButton.Location = new System.Drawing.Point(468, 493);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(112, 34);
            this.noButton.TabIndex = 5;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 568);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.questionRestartLabel);
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WinLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WinLabel;
        private PictureBox pictureBox1;
        private Label resultTextLabel;
        private Label questionRestartLabel;
        private Button yesButton;
        private Button noButton;
    }
}