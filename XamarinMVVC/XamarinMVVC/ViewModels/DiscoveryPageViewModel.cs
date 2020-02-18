using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMVVC.Models;

namespace XamarinMVVC.ViewModels
{
   public class DiscoveryPageViewModel
    {
        public string DiscoveryPageName { get; set; } = "Discovery";
        public DiscoveryOption DiscoveryHotels { get; set; } = new DiscoveryOption();
        public DiscoveryOption DiscoveryDining { get; set; } = new DiscoveryOption();
        public DiscoveryOption DiscoveryCafes { get; set; } = new DiscoveryOption();
        public DiscoveryOption DiscoveryNearby { get; set; } = new DiscoveryOption();
        public DiscoveryOption DiscoveryFastFood { get; set; } = new DiscoveryOption();
        public DiscoveryOption DiscoveryFeaturedFoods { get; set; } = new DiscoveryOption();
      
        public DiscoveryPageViewModel()
        {
          
            {
                // Bars and Hotels option 
                DiscoveryHotels.Image = "";
                DiscoveryHotels.Title = "Bars and Hotels";
                DiscoveryHotels.SubTitle = "42 Place";
            }

            {
                // Fine Dining option 
                DiscoveryDining.Image = "";
                DiscoveryDining.Title = "Fine Dining";
                DiscoveryDining.SubTitle = "15 Place";
            }

            {
                //  Cafes option 
                DiscoveryCafes.Image = "";
                DiscoveryCafes.Title = "Cafes";
                DiscoveryCafes.SubTitle = "28 Place";
            }

            {
                //  Nearby option 
                DiscoveryNearby.Image = "";
                DiscoveryNearby.Title = "Nearby";
                DiscoveryNearby.SubTitle = "34 Place";
            }

            {
                // Fast Food option 
                DiscoveryFastFood.Image = "";
                DiscoveryFastFood.Title = "Fast Foods";
                DiscoveryFastFood.SubTitle = "29 Place";
            }

            {
                // Featured Foods option 
                DiscoveryFeaturedFoods.Image = "";
                DiscoveryFeaturedFoods.Title = "Featured Foods";
                DiscoveryFeaturedFoods.SubTitle = "21 Place";
            }

        }
       

    }
}
