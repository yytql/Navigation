using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace YY_Navigation
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "YY Navigation";
            WebsiteInfos.Init();
            InitializeComponent();
        }

        private void WebTapped(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var myItem = (WebsiteInfos.Website)myListView.SelectedItem;
            myListView.SelectedItem = null;
            Browser.OpenAsync(myItem.Uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}
