using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Weeks_OnClicked(object sender, EventArgs e)
        {
          Navigation.PushAsync(new CampWeeks());
        }
    }
}
