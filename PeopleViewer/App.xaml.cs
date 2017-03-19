using PeopleViewer.Presentation;
using PersonRepository.CachingDecorator;
using PersonRepository.Service;
using System.Windows;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ComposeObjects();
            Application.Current.MainWindow.Title = "Loose coupling - People Viewer";
            Application.Current.MainWindow.Show();
        }

        private static void ComposeObjects()
        {
            //var repository = new ServiceRepository();
            //var repository = new CSVRepository();
            //var repository = new SQLRepository();

            var wrappRepository = new ServiceRepository();
            var repository = new CachingRepository(wrappRepository);

            var viewModel = new PeopleViewerViewModel(repository);

            Application.Current.MainWindow = new PeopleViewerWindow(viewModel);
        }
    }
}
