using PeopleViewer.Presentation;
using System.Windows;

namespace PeopleViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PeopleViewerWindow : Window
    {

        public PeopleViewerWindow(PeopleViewerViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
