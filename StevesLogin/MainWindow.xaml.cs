
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace StevesLogin
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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = false;
            string userName = UserName.Text;

            var task = Task.Run(() => {

                //If we are using task and any exception are being thrown , 
                //that need to be captured in , probably in continuation task
                //if (userName == "a")
                //{
                //    throw new UnauthorizedAccessException();
                //}
                Thread.Sleep(2000);

                return "Login Successfull";
            });

            task.ConfigureAwait(true)
                .GetAwaiter().
                OnCompleted(()=> 
                {
                    LoginButton.Content = task.Result;
                    LoginButton.IsEnabled = true;
                });

            //Task.Result , locks up the resource , till Rsult is available
            //So do it in Continue With    
            //LoginButton.Content = task.Result;

            //task.ContinueWith(t => {

            //    if (t.IsFaulted)
            //    {
            //        Dispatcher.Invoke(() => {
            //            LoginButton.Content ="Login Failed";
            //        LoginButton.IsEnabled = true;
            //        });
            //    }

            //    Dispatcher.Invoke(() => {
            //        LoginButton.Content = t.Result;
            //        LoginButton.IsEnabled = true;
            //    });
            //});

            //Thread.Sleep(2000);


        }
    }
}
