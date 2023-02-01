namespace Game_Frogs
{
    partial class RulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            this.GameRulesTextBox = new System.Windows.Forms.TextBox();
            this.RulesCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameRulesTextBox
            // 
            this.GameRulesTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameRulesTextBox.Location = new System.Drawing.Point(28, 21);
            this.GameRulesTextBox.Multiline = true;
            this.GameRulesTextBox.Name = "GameRulesTextBox";
            this.GameRulesTextBox.Size = new System.Drawing.Size(748, 253);
            this.GameRulesTextBox.TabIndex = 0;
            this.GameRulesTextBox.Text = resources.GetString("GameRulesTextBox.Text");
            // 
            // RulesCloseButton
            // 
            this.RulesCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RulesCloseButton.BackColor = System.Drawing.Color.GreenYellow;
            this.RulesCloseButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RulesCloseButton.Location = new System.Drawing.Point(649, 301);
            this.RulesCloseButton.Name = "RulesCloseButton";
            this.RulesCloseButton.Size = new System.Drawing.Size(127, 46);
            this.RulesCloseButton.TabIndex = 1;
            this.RulesCloseButton.Text = "Close";
            this.RulesCloseButton.UseVisualStyleBackColor = false;
            this.RulesCloseButton.Click += new System.EventHandler(this.RulesCloseButton_Click);
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.RulesCloseButton);
            this.Controls.Add(this.GameRulesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RulesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox GameRulesTextBox;
        private Button RulesCloseButton;
    }
}