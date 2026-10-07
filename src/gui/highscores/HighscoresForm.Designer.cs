namespace SpaceShooter.gui
{
    partial class HighscoresForm
    {
        private Label titleLabel;
        private DataGridView highscoresGrid;
        private DataGridViewTextBoxColumn rankColumn;
        private DataGridViewTextBoxColumn scoreColumn;
        private DataGridViewTextBoxColumn waveColumn;
        private DataGridViewTextBoxColumn durationColumn;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            titleLabel = new Label();
            highscoresGrid = new DataGridView();
            rankColumn = new DataGridViewTextBoxColumn();
            scoreColumn = new DataGridViewTextBoxColumn();
            waveColumn = new DataGridViewTextBoxColumn();
            durationColumn = new DataGridViewTextBoxColumn();
            okButton = new Button();
            ((System.ComponentModel.ISupportInitialize)highscoresGrid).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(100, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(475, 60);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "HIGHSCORES";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // highscoresGrid
            // 
            highscoresGrid.AllowUserToAddRows = false;
            highscoresGrid.AllowUserToDeleteRows = false;
            highscoresGrid.AllowUserToResizeRows = false;
            highscoresGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            highscoresGrid.BackgroundColor = Color.Black;
            highscoresGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            highscoresGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            highscoresGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            highscoresGrid.Columns.AddRange(new DataGridViewColumn[] { rankColumn, scoreColumn, waveColumn, durationColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            highscoresGrid.DefaultCellStyle = dataGridViewCellStyle2;
            highscoresGrid.EnableHeadersVisualStyles = false;
            highscoresGrid.Location = new Point(45, 125);
            highscoresGrid.Name = "highscoresGrid";
            highscoresGrid.ReadOnly = true;
            highscoresGrid.RowHeadersVisible = false;
            highscoresGrid.RowHeadersWidth = 51;
            highscoresGrid.RowTemplate.Height = 30;
            highscoresGrid.Size = new Size(585, 475);
            highscoresGrid.TabIndex = 1;
            // 
            // rankColumn
            // 
            rankColumn.HeaderText = "No.";
            rankColumn.MinimumWidth = 6;
            rankColumn.Name = "rankColumn";
            rankColumn.ReadOnly = true;
            // 
            // scoreColumn
            // 
            scoreColumn.HeaderText = "Score";
            scoreColumn.MinimumWidth = 6;
            scoreColumn.Name = "scoreColumn";
            scoreColumn.ReadOnly = true;
            // 
            // waveColumn
            // 
            waveColumn.HeaderText = "Wave";
            waveColumn.MinimumWidth = 6;
            waveColumn.Name = "waveColumn";
            waveColumn.ReadOnly = true;
            // 
            // durationColumn
            // 
            durationColumn.HeaderText = "Duration";
            durationColumn.MinimumWidth = 6;
            durationColumn.Name = "durationColumn";
            durationColumn.ReadOnly = true;
            // 
            // okButton
            // 
            okButton.BackColor = Color.FromArgb(60, 255, 255, 255);
            okButton.FlatAppearance.BorderSize = 0;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(283, 635);
            okButton.Name = "okButton";
            okButton.Size = new Size(109, 36);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            // 
            // HighscoresForm
            // 
            ClientSize = new Size(675, 727);
            Controls.Add(okButton);
            Controls.Add(highscoresGrid);
            Controls.Add(titleLabel);
            Name = "HighscoresForm";
            ((System.ComponentModel.ISupportInitialize)highscoresGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}