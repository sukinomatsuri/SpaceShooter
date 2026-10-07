namespace SpaceShooter.gui
{
    partial class AboutForm
    {
        private Label titleLabel;
        private Label gameDescriptionLabel;
        private LinkLabel developerLabel;
        private Button okButton;

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
            titleLabel = new Label();
            gameDescriptionLabel = new Label();
            developerLabel = new LinkLabel();
            okButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(24, 48);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(366, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "About Space Shooter";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameDescriptionLabel
            // 
            gameDescriptionLabel.BackColor = Color.Transparent;
            gameDescriptionLabel.Font = new Font("Segoe UI", 10F);
            gameDescriptionLabel.ForeColor = Color.White;
            gameDescriptionLabel.Location = new Point(34, 125);
            gameDescriptionLabel.Name = "gameDescriptionLabel";
            gameDescriptionLabel.Size = new Size(346, 90);
            gameDescriptionLabel.TabIndex = 1;
            gameDescriptionLabel.Text = "A space shooter game.";
            gameDescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // developerLabel
            // 
            developerLabel.BackColor = Color.Transparent;
            developerLabel.LinkColor = Color.LightBlue;
            developerLabel.Location = new Point(34, 235);
            developerLabel.Name = "developerLabel";
            developerLabel.Size = new Size(346, 30);
            developerLabel.TabIndex = 2;
            developerLabel.TabStop = true;
            developerLabel.Text = "Developer: vertex group";
            developerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            okButton.BackColor = Color.Transparent;
            okButton.Location = new Point(159, 350);
            okButton.Name = "okButton";
            okButton.Size = new Size(96, 32);
            okButton.TabIndex = 3;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 438);
            Controls.Add(okButton);
            Controls.Add(developerLabel);
            Controls.Add(gameDescriptionLabel);
            Controls.Add(titleLabel);
            Name = "AboutForm";
            Load += AboutForm_Load_1;
            ResumeLayout(false);
        }

        #endregion
    }
}