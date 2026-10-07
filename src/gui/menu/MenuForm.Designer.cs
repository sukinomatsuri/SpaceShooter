using SpaceShooter.resources;

namespace SpaceShooter.gui
{
    partial class MenuForm
    {
        private Label titleLabel;
        private PictureBox heroPictureBox;
        private Button playButton;
        private Button highscoresButton;
        private Button optionsButton;
        private Button aboutButton;

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
            heroPictureBox = new PictureBox();
            playButton = new Button();
            highscoresButton = new Button();
            optionsButton = new Button();
            aboutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)heroPictureBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(51, 28);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(314, 120);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "SPACE\nSHOOTER";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heroPictureBox
            // 
            heroPictureBox.BackColor = Color.Transparent;
            heroPictureBox.Image = Resources.img_hero_spaceship;
            heroPictureBox.Location = new Point(160, 175);
            heroPictureBox.Name = "heroPictureBox";
            heroPictureBox.Size = new Size(96, 106);
            heroPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            heroPictureBox.TabIndex = 1;
            heroPictureBox.TabStop = false;
            // 
            // playButton
            // 
            playButton.BackColor = Color.FromArgb(60, 255, 255, 255);
            playButton.FlatAppearance.BorderSize = 0;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Microsoft Sans Serif", 12F);
            playButton.ForeColor = Color.White;
            playButton.Location = new Point(138, 327);
            playButton.Name = "playButton";
            playButton.Size = new Size(140, 36);
            playButton.TabIndex = 2;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            // 
            // highscoresButton
            // 
            highscoresButton.BackColor = Color.FromArgb(60, 255, 255, 255);
            highscoresButton.FlatAppearance.BorderSize = 0;
            highscoresButton.FlatStyle = FlatStyle.Flat;
            highscoresButton.Font = new Font("Microsoft Sans Serif", 12F);
            highscoresButton.ForeColor = Color.White;
            highscoresButton.Location = new Point(138, 372);
            highscoresButton.Name = "highscoresButton";
            highscoresButton.Size = new Size(140, 36);
            highscoresButton.TabIndex = 3;
            highscoresButton.Text = "Highscores";
            highscoresButton.UseVisualStyleBackColor = false;
            // 
            // optionsButton
            // 
            optionsButton.BackColor = Color.FromArgb(60, 255, 255, 255);
            optionsButton.FlatAppearance.BorderSize = 0;
            optionsButton.FlatStyle = FlatStyle.Flat;
            optionsButton.Font = new Font("Microsoft Sans Serif", 12F);
            optionsButton.ForeColor = Color.White;
            optionsButton.Location = new Point(138, 417);
            optionsButton.Name = "optionsButton";
            optionsButton.Size = new Size(140, 36);
            optionsButton.TabIndex = 4;
            optionsButton.Text = "Options";
            optionsButton.UseVisualStyleBackColor = false;
            // 
            // aboutButton
            // 
            aboutButton.BackColor = Color.FromArgb(60, 255, 255, 255);
            aboutButton.FlatAppearance.BorderSize = 0;
            aboutButton.FlatStyle = FlatStyle.Flat;
            aboutButton.Font = new Font("Microsoft Sans Serif", 12F);
            aboutButton.ForeColor = Color.White;
            aboutButton.Location = new Point(138, 462);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(140, 36);
            aboutButton.TabIndex = 5;
            aboutButton.Text = "About";
            aboutButton.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            ClientSize = new Size(416, 529);
            Controls.Add(aboutButton);
            Controls.Add(optionsButton);
            Controls.Add(highscoresButton);
            Controls.Add(playButton);
            Controls.Add(heroPictureBox);
            Controls.Add(titleLabel);
            Name = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)heroPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}