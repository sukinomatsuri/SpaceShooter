using SpaceShooter.utils;
using static SpaceShooter.utils.CustomExceptions;

namespace SpaceShooter.gui
{
    public partial class OptionsForm : CustomForm
    {
        private bool runtimeInitialized;

        public OptionsForm()
        {
            InitializeComponent();
            setBackgroundImage();
            okButton.Click += (sender, e) => Close();
        }

        public void InitializeRuntime()
        {
            if (runtimeInitialized)
                return;

            runtimeInitialized = true;
            musicCheckBox.Checked = getOptionValueOrDefault("Music");
            sfxCheckBox.Checked = getOptionValueOrDefault("SFX");

            musicCheckBox.CheckedChanged += (sender, e) =>
            {
                if (musicCheckBox.Checked)
                    AudioPlayer.Player.PlayBackgroundMusic();
                else
                    AudioPlayer.Player.StopBackgroundMusic();
            };

            sfxCheckBox.CheckedChanged += (sender, e) =>
            {
                if (sfxCheckBox.Checked)
                    AudioPlayer.Player.ActivateOutputDevice();
                else
                    AudioPlayer.Player.MuteOutputDevice();
            };

            FormClosing += onFormClosing;
        }

        private static bool getOptionValueOrDefault(string name)
        {
            try
            {
                return DatabaseManager.GetOptionValue(name);
            }
            catch (EntryNotFoundException)
            {
                return true;
            }
        }

        private void onFormClosing(object? sender, FormClosingEventArgs e)
        {
            DatabaseManager.AddOrUpdateOptionEntry("Music", musicCheckBox.Checked);
            DatabaseManager.AddOrUpdateOptionEntry("SFX", sfxCheckBox.Checked);
        }
    }
}