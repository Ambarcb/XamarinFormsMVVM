using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMVVC.ViewModels;

namespace XamarinMVVC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string name)
        {
            InitializeComponent();
            emailLabel.Text = name;
            BindingContext = new SignUpPageViewModel();
        }

        private void ShowPassword_Tapped(object sender, EventArgs e)
        {
            icon.Source = !passwordEntry.IsPassword ? "ic_ShowPassword" : "ic_hidden";
            passwordEntry.IsPassword = !passwordEntry.IsPassword;
        }

        private void ShowPassword_Tappedx(object sender, EventArgs e)
        {
            icon1.Source = !rPasswordEntry.IsPassword ? "ic_ShowPassword1" : "ic_hidden";
            rPasswordEntry.IsPassword = !rPasswordEntry.IsPassword;
        }
    }
}