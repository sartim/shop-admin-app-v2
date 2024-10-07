

using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace ShopAdmin.Helpers
{
    public class Alert
    {
        public static async Task ToastAlert(string text)
        {
            ToastDuration duration = ToastDuration.Short;
            double fontSize = 14;
            var toast = Toast.Make(text, duration, fontSize);
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
            await toast.Show(cts.Token);
        }
    }
}
