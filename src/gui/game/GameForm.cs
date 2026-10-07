using SpaceShooter.core;
using SpaceShooter.utils;

namespace SpaceShooter.gui
{
    public partial class GameForm : CustomForm
    {
        private const float statsPanelHeightRatio = 0.05f;

        public GameGridGui Grid { get; private set; } = null!;

        public StatsBar StatsBar { get; private set; } = null!;

        public GameForm()
        {
            InitializeComponent();
        }

        public void InitializeRuntime(IGameStateUI gameState, EventHandler onGameResume)
        {
            StartPosition = FormStartPosition.Manual;
            Location = ScreenUtils.GetLargestScreen().WorkingArea.Location;
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            int statsPanelWidth = gameState.Grid.DimensionX;
            int statsPanelHeight = (int)(statsPanelHeightRatio * gameState.Grid.DimensionY);

            ClientSize = new Size(statsPanelWidth, gameState.Grid.DimensionY + statsPanelHeight);

            Controls.Remove(gridPreviewPanel);
            Controls.Remove(statsPreviewPanel);
            gridPreviewPanel.Dispose();
            statsPreviewPanel.Dispose();

            Grid = new GameGridGui(this, gameState, onGameResume)
            {
                Top = statsPanelHeight
            };

            StatsBar = new StatsBar(this, statsPanelWidth, statsPanelHeight);
            KeyPreview = true;
        }

        public static Size GetGameGridSize()
        {
            Size largestResolution = ScreenUtils.GetLargestScreen().Bounds.Size;
            int gridHeight = (int)((float)largestResolution.Height / (float)(1 + statsPanelHeightRatio));
            return new Size(largestResolution.Width, gridHeight);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}