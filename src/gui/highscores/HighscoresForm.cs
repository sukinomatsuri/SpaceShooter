namespace SpaceShooter.gui
{
    public partial class HighscoresForm : CustomForm
    {
        private const int topEntriesCount = 10;

        public HighscoresForm()
        {
            InitializeComponent();
            setBackgroundImage();
            okButton.Click += (sender, e) => Close();
        }

        public void InitializeRuntime()
        {
            List<(int, int, string)> highscores = DatabaseManager.GetTopHighscoresEntries(topEntriesCount);

            while (highscores.Count < topEntriesCount)
                highscores.Add((0, 0, "00:00:00"));

            highscoresGrid.Rows.Clear();
            for (int i = 0; i < topEntriesCount; i++)
            {
                var entry = highscores[i];
                highscoresGrid.Rows.Add(i + 1, entry.Item1, entry.Item2, entry.Item3);
            }
        }
    }
}