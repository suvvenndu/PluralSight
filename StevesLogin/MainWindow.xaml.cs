
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
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }


        //Async void is not a good idea, a better idea is async task
        private  async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginButton.IsEnabled = false;
                BusyIndicator.Visibility = Visibility.Visible;

               var taskResult = await LoginAsync();

                LoginButton.Content = taskResult;

                LoginButton.IsEnabled = true;
                BusyIndicator.Visibility = Visibility.Hidden;

            }
            catch (Exception)
            {

                LoginButton.Content = "Internal error....";
            }




        }

        #region Explanation
        //Marking a method as Async , will have that method contain tasks that can run asynchronously , using await key word.
        //
        //When we are marking a method as async, the compiler is generating some thing for us called state machine
        //State machine is a way of keep tracl of asynchronous methods and continuations
        //When state machoine catch an exception it will try and set it some where
        //Marking Async operation return type as Task is a good idea , so that errors can also be captured 
        //and calling method can continue with task
        #endregion

        private async Task<string> LoginAsync()
       // private async Task LoginAsync()
       // private async void LoginAsync()
        {
           // throw new UnauthorizedAccessException();

            try
            {
                #region Explanation
                //When we mark something as await, that means everything after 'await' will be
                //executed as continuation. So we are scheduling a continuation

                //The difference between Task.Run(),Task.Continue() and Async and Await , is it executes on same thread, same calling context , in this case the UI thread

                //LoginButton.Content = "Login Successfull";
                //var result = await Task.Run(() =>
                //{
                // //  throw new UnauthorizedAccessException();

                //    Thread.Sleep(2000);

                //    return "Login Successfull";
                //});

                #endregion


                var loginTask =  Task.Run(() =>
                {
                    //  throw new UnauthorizedAccessException();

                    Thread.Sleep(2000);

                    return "Login Successfull";
                });

                #region Explanation
                ////UI 
                //In this case sheduling continuation and awaiting for each task
                //await Task.Delay(2000);

                ////UI 
                //await Task.Delay(2000);

                ////UI 
                //await Task.Delay(2000);

                //If we do not want to wait and want all the task to run in parallel
                //just remove await key ward and none will wait for any task

                //UI 
                #endregion


                var logTask = Task.Delay(2000);

                //UI 
                var purchaseTask  = Task.Delay(2000);


                //return result;

                //Now await all the task to be comleted before returning 

                await Task.WhenAll(loginTask, logTask, purchaseTask);

                return loginTask.Result;



                //LoginButton.Content = result;
            }
            catch (Exception)
            {

                return "Login Failed...";
            }
        }

        #region WithOnly Tasks and Without Async

        /*    private void LoginButton_Click(object sender, RoutedEventArgs e)
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


            }*/
        #endregion 
    }
}
