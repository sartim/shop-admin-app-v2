using Newtonsoft.Json;
using ShopAdminApp.Models;
using ShopAdminApp.Services;

namespace ShopAdmin
{
    public partial class StatusPage : ContentPage
    {
        public StatusPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}

