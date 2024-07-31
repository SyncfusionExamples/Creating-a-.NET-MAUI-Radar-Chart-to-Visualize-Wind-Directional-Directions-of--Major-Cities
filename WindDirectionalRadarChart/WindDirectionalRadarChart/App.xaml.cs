namespace WindDirectionalRadarChart
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF1cWGhBYVFyWmFZfVpgdl9HZFZRQGYuP1ZhSXxXdkJhUH9Zcn1URGVZVkM=");
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
