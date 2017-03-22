using System.Net;
using System.Threading;
using System.Windows;

namespace AsyncProgrammeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var client = new WebClient();

          //  var data = client.DownloadString("http://flilipekberg.rss.se/rss/");
            Thread.Sleep(5000);

            rss.Text = "SomeText";
        }
    }
}
