using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeumorphicClock
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();

            ResourcesHelper.SetNeumorphismMode();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
