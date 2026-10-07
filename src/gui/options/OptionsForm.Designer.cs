using SpaceShooter.resources;

namespace SpaceShooter.gui
{
    partial class OptionsForm
    {
        private Label titleLabel;
        private GroupBox movementGroup;
        private PictureBox arrowKeysPictureBox;
        private PictureBox wasdKeysPictureBox;
        private GroupBox fireGroup;
        private PictureBox spaceKeyPictureBox;
        private PictureBox eKeyPictureBox;
        private GroupBox pauseGroup;
        private PictureBox escapeKeyPictureBox;
        private PictureBox pKeyPictureBox;
        private GroupBox audioGroup;
        private CheckBox musicCheckBox;
        private CheckBox sfxCheckBox;
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
            movementGroup = new GroupBox();
            wasdKeysPictureBox = new PictureBox();
            arrowKeysPictureBox = new PictureBox();
            fireGroup = new GroupBox();
            eKeyPictureBox = new PictureBox();
            spaceKeyPictureBox = new PictureBox();
            pauseGroup = new GroupBox();
            pKeyPictureBox = new PictureBox();
            escapeKeyPictureBox = new PictureBox();
            audioGroup = new GroupBox();
            sfxCheckBox = new CheckBox();
            musicCheckBox = new CheckBox();
            okButton = new Button();
            movementGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wasdKeysPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrowKeysPictureBox).BeginInit();
            fireGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eKeyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spaceKeyPictureBox).BeginInit();
            pauseGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pKeyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)escapeKeyPictureBox).BeginInit();
            audioGroup.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(68, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(396, 52);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "OPTIONS";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movementGroup
            // 
            movementGroup.BackColor = Color.Transparent;
            movementGroup.Controls.Add(wasdKeysPictureBox);
            movementGroup.Controls.Add(arrowKeysPictureBox);
            movementGroup.ForeColor = Color.White;
            movementGroup.Location = new Point(53, 84);
            movementGroup.Name = "movementGroup";
            movementGroup.Size = new Size(426, 112);
            movementGroup.TabIndex = 1;
            movementGroup.TabStop = false;
            movementGroup.Text = "Movement";
            // 
            // wasdKeysPictureBox
            // 
            wasdKeysPictureBox.BackColor = Color.Transparent;
            wasdKeysPictureBox.Image = Resources.img_wasd_keys;
            wasdKeysPictureBox.Location = new Point(235, 37);
            wasdKeysPictureBox.Name = "wasdKeysPictureBox";
            wasdKeysPictureBox.Size = new Size(150, 58);
            wasdKeysPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            wasdKeysPictureBox.TabIndex = 1;
            wasdKeysPictureBox.TabStop = false;
            // 
            // arrowKeysPictureBox
            // 
            arrowKeysPictureBox.BackColor = Color.Transparent;
            arrowKeysPictureBox.Image = Resources.img_arrow_keys;
            arrowKeysPictureBox.Location = new Point(40, 37);
            arrowKeysPictureBox.Name = "arrowKeysPictureBox";
            arrowKeysPictureBox.Size = new Size(150, 58);
            arrowKeysPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            arrowKeysPictureBox.TabIndex = 0;
            arrowKeysPictureBox.TabStop = false;
            // 
            // fireGroup
            // 
            fireGroup.BackColor = Color.Transparent;
            fireGroup.Controls.Add(eKeyPictureBox);
            fireGroup.Controls.Add(spaceKeyPictureBox);
            fireGroup.ForeColor = Color.White;
            fireGroup.Location = new Point(53, 205);
            fireGroup.Name = "fireGroup";
            fireGroup.Size = new Size(426, 112);
            fireGroup.TabIndex = 2;
            fireGroup.TabStop = false;
            fireGroup.Text = "Fire";
            // 
            // eKeyPictureBox
            // 
            eKeyPictureBox.BackColor = Color.Transparent;
            eKeyPictureBox.Image = Resources.img_e_key;
            eKeyPictureBox.Location = new Point(235, 37);
            eKeyPictureBox.Name = "eKeyPictureBox";
            eKeyPictureBox.Size = new Size(70, 58);
            eKeyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            eKeyPictureBox.TabIndex = 1;
            eKeyPictureBox.TabStop = false;
            // 
            // spaceKeyPictureBox
            // 
            spaceKeyPictureBox.BackColor = Color.Transparent;
            spaceKeyPictureBox.Image = Resources.img_space_key;
            spaceKeyPictureBox.Location = new Point(40, 37);
            spaceKeyPictureBox.Name = "spaceKeyPictureBox";
            spaceKeyPictureBox.Size = new Size(84, 58);
            spaceKeyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            spaceKeyPictureBox.TabIndex = 0;
            spaceKeyPictureBox.TabStop = false;
            // 
            // pauseGroup
            // 
            pauseGroup.BackColor = Color.Transparent;
            pauseGroup.Controls.Add(pKeyPictureBox);
            pauseGroup.Controls.Add(escapeKeyPictureBox);
            pauseGroup.ForeColor = Color.White;
            pauseGroup.Location = new Point(53, 326);
            pauseGroup.Name = "pauseGroup";
            pauseGroup.Size = new Size(426, 112);
            pauseGroup.TabIndex = 3;
            pauseGroup.TabStop = false;
            pauseGroup.Text = "Pause";
            // 
            // pKeyPictureBox
            // 
            pKeyPictureBox.BackColor = Color.Transparent;
            pKeyPictureBox.Image = Resources.img_p_key;
            pKeyPictureBox.Location = new Point(235, 37);
            pKeyPictureBox.Name = "pKeyPictureBox";
            pKeyPictureBox.Size = new Size(70, 58);
            pKeyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pKeyPictureBox.TabIndex = 1;
            pKeyPictureBox.TabStop = false;
            // 
            // escapeKeyPictureBox
            // 
            escapeKeyPictureBox.BackColor = Color.Transparent;
            escapeKeyPictureBox.Image = Resources.img_esc_key;
            escapeKeyPictureBox.Location = new Point(40, 37);
            escapeKeyPictureBox.Name = "escapeKeyPictureBox";
            escapeKeyPictureBox.Size = new Size(84, 58);
            escapeKeyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            escapeKeyPictureBox.TabIndex = 0;
            escapeKeyPictureBox.TabStop = false;
            // 
            // audioGroup
            // 
            audioGroup.BackColor = Color.Transparent;
            audioGroup.Controls.Add(sfxCheckBox);
            audioGroup.Controls.Add(musicCheckBox);
            audioGroup.ForeColor = Color.White;
            audioGroup.Location = new Point(53, 447);
            audioGroup.Name = "audioGroup";
            audioGroup.Size = new Size(426, 92);
            audioGroup.TabIndex = 4;
            audioGroup.TabStop = false;
            audioGroup.Text = "Audio";
            // 
            // sfxCheckBox
            // 
            sfxCheckBox.AutoSize = true;
            sfxCheckBox.BackColor = Color.Transparent;
            sfxCheckBox.ForeColor = Color.White;
            sfxCheckBox.Location = new Point(250, 43);
            sfxCheckBox.Name = "sfxCheckBox";
            sfxCheckBox.Size = new Size(55, 24);
            sfxCheckBox.TabIndex = 1;
            sfxCheckBox.Text = "SFX";
            sfxCheckBox.UseVisualStyleBackColor = false;
            // 
            // musicCheckBox
            // 
            musicCheckBox.AutoSize = true;
            musicCheckBox.BackColor = Color.Transparent;
            musicCheckBox.ForeColor = Color.White;
            musicCheckBox.Location = new Point(55, 43);
            musicCheckBox.Name = "musicCheckBox";
            musicCheckBox.Size = new Size(69, 24);
            musicCheckBox.TabIndex = 0;
            musicCheckBox.Text = "Music";
            musicCheckBox.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            okButton.BackColor = Color.FromArgb(60, 255, 255, 255);
            okButton.FlatAppearance.BorderSize = 0;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(212, 574);
            okButton.Name = "okButton";
            okButton.Size = new Size(108, 36);
            okButton.TabIndex = 5;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            // 
            // OptionsForm
            // 
            ClientSize = new Size(532, 697);
            Controls.Add(okButton);
            Controls.Add(audioGroup);
            Controls.Add(pauseGroup);
            Controls.Add(fireGroup);
            Controls.Add(movementGroup);
            Controls.Add(titleLabel);
            Name = "OptionsForm";
            movementGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wasdKeysPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrowKeysPictureBox).EndInit();
            fireGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eKeyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)spaceKeyPictureBox).EndInit();
            pauseGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pKeyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)escapeKeyPictureBox).EndInit();
            audioGroup.ResumeLayout(false);
            audioGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}