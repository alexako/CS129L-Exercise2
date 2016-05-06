namespace Registration
{
    partial class TeamMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.showStatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Membership Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To join, click on the team name";
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(12, 76);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(295, 27);
            this.redButton.TabIndex = 2;
            this.redButton.Text = "Red Team";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(12, 106);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(295, 27);
            this.blueButton.TabIndex = 3;
            this.blueButton.Text = "Blue Team";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.Location = new System.Drawing.Point(12, 135);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(295, 27);
            this.greenButton.TabIndex = 4;
            this.greenButton.Text = "Green Team";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.Location = new System.Drawing.Point(12, 165);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(295, 27);
            this.yellowButton.TabIndex = 5;
            this.yellowButton.Text = "Yellow Team";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // showStatusButton
            // 
            this.showStatusButton.Location = new System.Drawing.Point(12, 195);
            this.showStatusButton.Name = "showStatusButton";
            this.showStatusButton.Size = new System.Drawing.Size(295, 27);
            this.showStatusButton.TabIndex = 6;
            this.showStatusButton.Text = "Show Status";
            this.showStatusButton.UseVisualStyleBackColor = true;
            this.showStatusButton.Click += new System.EventHandler(this.showStatusButton_Click);
            // 
            // TeamMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 234);
            this.Controls.Add(this.showStatusButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TeamMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color League";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button showStatusButton;
    }
}

