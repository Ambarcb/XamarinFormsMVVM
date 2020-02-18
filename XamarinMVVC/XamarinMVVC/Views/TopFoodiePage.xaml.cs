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
    public partial class TopFoodiePage : ContentPage
    {
        public TopFoodiePage()
        {
            InitializeComponent();
            BindingContext = new TopFoodiePageViewModel();
        }
    }
}