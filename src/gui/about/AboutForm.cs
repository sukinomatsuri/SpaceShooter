namespace SpaceShooter.gui
{
    public partial class AboutForm : CustomForm
    {
        public AboutForm()
        {
            InitializeComponent();
            setBackgroundImage();
            developerLabel.LinkClicked += onDeveloperLinkAreaClick;
            okButton.Click += (sender, e) => Close();
        }

        private void onDeveloperLinkAreaClick(object? sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/sukinomatsuri");
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void AboutForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
