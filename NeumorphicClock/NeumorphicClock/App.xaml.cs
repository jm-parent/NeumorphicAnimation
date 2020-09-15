using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeumorphicClock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
                MainPage = new MainPage();

            Sharpnado.Shades.Initializer.Initialize(true, true);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
