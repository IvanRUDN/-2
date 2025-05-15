using System.Windows;

namespace задание__2
{
    public class App : Application
    {
        private readonly MainWindow mainWindow;
        public App(MainWindow mainWindow)
        {
            mainWindow = mainWindow;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
