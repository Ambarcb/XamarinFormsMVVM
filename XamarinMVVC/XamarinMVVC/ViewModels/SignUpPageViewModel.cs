using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVC.Models;

namespace XamarinMVVC.ViewModels
{
    public class SignUpPageViewModel : INotifyPropertyChanged
    {

        public string DisplayErrorMessage { get; set; } = "Terms of Service";

        public User User { get; set; } = new User();
        public ICommand SignUpCommand { get; set; }
        public ICommand GoToLoginCommand { get; set; }


        public SignUpPageViewModel()
        {
            SignUpCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(User.UserName) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.RepeatedPassword) || string.IsNullOrEmpty(User.Email))
                {
                    DisplayErrorMessage = "                                             Error!" +
                     "\nPlease make sure all your fields are properly filled and then try again.";


                }
                else
                {
                    DisplayErrorMessage = "Terms of Service";
                    await App.Current.MainPage.Navigation.PushModalAsync(new MainTabbedPage());
                }

            });

            GoToLoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}