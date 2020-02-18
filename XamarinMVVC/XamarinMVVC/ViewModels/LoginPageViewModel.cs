using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;
using XamarinMVVC.Models;
namespace XamarinMVVC.ViewModels

{
    public class LoginPageViewModel : INotifyPropertyChanged
    {

        public string DisplayErrorMessage { get; set; } = "Login with";

        public User User { get; set; } = new User();
        public ICommand LoginCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        public ICommand GoToSignUpCommand { get; set; }

        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User.UserName) || string.IsNullOrEmpty(User.Password))
                {
                    DisplayErrorMessage = "                                             Error!" +
                    "\nPlease make sure all your fields are properly filled and then try again.";

                }
                else
                {
                    DisplayErrorMessage = "Login with";
                    await App.Current.MainPage.Navigation.PushModalAsync(new MainTabbedPage());
                }

            });

            GoToSignUpCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage(User.UserName));
            });

            SignUpCommand = new Command(() =>
            {
                var x = 1;
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}