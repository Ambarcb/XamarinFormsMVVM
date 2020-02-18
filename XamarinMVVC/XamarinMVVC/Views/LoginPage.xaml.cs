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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }

        void PasswordVisibility(Object sender, EventArgs e)
        {
            passwordVisibility.Source = !passwordEntry.IsPassword ? "ic_ShowPassword" : "ic_hidden";
            passwordEntry.IsPassword = !passwordEntry.IsPassword;
        }
    }
}