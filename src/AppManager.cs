using SpaceShooter.gui;
using SpaceShooter.resources;
using SpaceShooter.utils;
using static SpaceShooter.utils.CustomExceptions;

namespace SpaceShooter
{
    internal static class AppManager
    {
        private static MenuForm menuForm = new MenuForm();

        public static void Start()
        {
            InitAudioPlayer();
            menuForm.InitializeRuntime();
            Application.Run(menuForm);
        }

        public static void OnMenuOptionPlayClick(object? sender, EventArgs e) 
        {
            menuForm.Hide();
            GameManager.StartNewGame();
        }

        public static void OnMenuOptionHighscoresClick(object? sender, EventArgs e)
        {
            menuForm.Hide();
            HighscoresForm form = new();
            form.InitializeRuntime();
            showSubForm(form);
        }

        public static void OnMenuOptionOptionsClick(object? sender, EventArgs e)
        {
            menuForm.Hide();
            OptionsForm form = new();
            form.InitializeRuntime();
            showSubForm(form);
        }

        public static void OnMenuOptionAboutClick(object? sender, EventArgs e)
        {
            menuForm.Hide();
            showSubForm(new AboutForm());
        }

        public static void OnPauseMenuOptionOptionsClick(object? sender, EventArgs e)
        {
            OptionsForm form = new();
            form.InitializeRuntime();
            form.ShowDialog();
        }

        public static void OnSubFormClosed(object? sender, EventArgs e) => menuForm.Show();

        private static void showSubForm(Form form)
        {
            form.FormClosed += OnSubFormClosed;
            form.Show();
        }

        public static void InitAudioPlayer()
        {
            AudioPlayer.Player.SetBackgroundMusic(Resources.aud_background_music);

            try
            {
                if (DatabaseManager.GetOptionValue("Music"))
                    AudioPlayer.Player.PlayBackgroundMusic();
            }
            catch (EntryNotFoundException)
            {
                AudioPlayer.Player.PlayBackgroundMusic();
            }

            try
            {
                if (DatabaseManager.GetOptionValue("SFX"))
                    AudioPlayer.Player.ActivateOutputDevice();
            }
            catch (EntryNotFoundException)
            {
                AudioPlayer.Player.ActivateOutputDevice();
            }
        }
    }
}
