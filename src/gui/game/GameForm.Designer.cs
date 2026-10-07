namespace SpaceShooter.gui
{
    partial class GameForm
    {
        private Panel gridPreviewPanel;
        private Label gridPreviewLabel;
        private Panel statsPreviewPanel;
        private Label wavePreviewLabel;
        private Label scorePreviewLabel;
        private Label timePreviewLabel;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridPreviewPanel = new Panel();
            gridPreviewLabel = new Label();
            statsPreviewPanel = new Panel();
            wavePreviewLabel = new Label();
            scorePreviewLabel = new Label();
            timePreviewLabel = new Label();
            SuspendLayout();
            // 
            // gridPreviewPanel
            // 
            gridPreviewPanel.BackColor = Color.Black;
            gridPreviewPanel.Controls.Add(gridPreviewLabel);
            gridPreviewPanel.Location = new Point(0, 45);
            gridPreviewPanel.Name = "gridPreviewPanel";
            gridPreviewPanel.Size = new Size(382, 408);
            gridPreviewPanel.TabIndex = 0;
            // 
            // gridPreviewLabel
            // 
            gridPreviewLabel.Dock = DockStyle.Fill;
            gridPreviewLabel.ForeColor = Color.Gray;
            gridPreviewLabel.Location = new Point(0, 0);
            gridPreviewLabel.Name = "gridPreviewLabel";
            gridPreviewLabel.Size = new Size(382, 408);
            gridPreviewLabel.TabIndex = 0;
            gridPreviewLabel.Text = "Game area preview";
            gridPreviewLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statsPreviewPanel
            // 
            statsPreviewPanel.BackColor = Color.FromArgb(40, 40, 40);
            statsPreviewPanel.Controls.Add(wavePreviewLabel);
            statsPreviewPanel.Controls.Add(scorePreviewLabel);
            statsPreviewPanel.Controls.Add(timePreviewLabel);
            statsPreviewPanel.Location = new Point(0, 0);
            statsPreviewPanel.Name = "statsPreviewPanel";
            statsPreviewPanel.Size = new Size(382, 45);
            statsPreviewPanel.TabIndex = 1;
            // 
            // wavePreviewLabel
            // 
            wavePreviewLabel.AutoSize = true;
            wavePreviewLabel.ForeColor = Color.White;
            wavePreviewLabel.Location = new Point(10, 14);
            wavePreviewLabel.Name = "wavePreviewLabel";
            wavePreviewLabel.Size = new Size(51, 20);
            wavePreviewLabel.TabIndex = 0;
            wavePreviewLabel.Text = "Wave 1";
            // 
            // scorePreviewLabel
            // 
            scorePreviewLabel.AutoSize = true;
            scorePreviewLabel.ForeColor = Color.White;
            scorePreviewLabel.Location = new Point(125, 14);
            scorePreviewLabel.Name = "scorePreviewLabel";
            scorePreviewLabel.Size = new Size(59, 20);
            scorePreviewLabel.TabIndex = 1;
            scorePreviewLabel.Text = "Score 0";
            // 
            // timePreviewLabel
            // 
            timePreviewLabel.AutoSize = true;
            timePreviewLabel.ForeColor = Color.White;
            timePreviewLabel.Location = new Point(255, 14);
            timePreviewLabel.Name = "timePreviewLabel";
            timePreviewLabel.Size = new Size(115, 20);
            timePreviewLabel.TabIndex = 2;
            timePreviewLabel.Text = "Elapsed 00:00:00";
            // 
            // GameForm
            // 
            ClientSize = new Size(382, 453);
            Name = "GameForm";
            Controls.Add(gridPreviewPanel);
            Controls.Add(statsPreviewPanel);
            ResumeLayout(false);
        }

        #endregion
    }
}