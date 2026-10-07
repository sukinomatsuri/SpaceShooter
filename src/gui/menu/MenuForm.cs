namespace SpaceShooter.gui
{
    public partial class MenuForm : CustomForm
    {
        public MenuForm()
        {
            InitializeComponent();
            setBackgroundImage();
        }

        public void InitializeRuntime()
        {
            playButton.Click += AppManager.OnMenuOptionPlayClick;
            highscoresButton.Click += AppManager.OnMenuOptionHighscoresClick;
            optionsButton.Click += AppManager.OnMenuOptionOptionsClick;
            aboutButton.Click += AppManager.OnMenuOptionAboutClick;
        }
    }
}