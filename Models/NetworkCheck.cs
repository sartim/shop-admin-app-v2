namespace ShopAdminApp.Models
{
	public class NetworkCheck
	{
        public static bool IsInternet()
        {
            NetworkAccess accessType = Connectivity.Current.NetworkAccess;

            if (accessType == NetworkAccess.Internet)
            {
                // Connection to internet is available
                return true;
            } else {
                // write your code if there is no Internet available      
                return false;
            }
        }
    }
}

