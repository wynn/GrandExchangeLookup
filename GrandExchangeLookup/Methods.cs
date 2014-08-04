using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;

namespace GrandExchangeLookup
{
    class Methods
    {
        public static GEItem Lookup(int ItemID)
        {
            WebClient Client = new WebClient();
            String downloadedString;

            try
            {
                downloadedString = Client.DownloadString("http://services.runescape.com/m=itemdb_rs/api/catalogue/detail.json?item=" + ItemID);
            }
            catch 
            {
                return null;
            }

            return JsonConvert.DeserializeObject<GEItem>(downloadedString);
        }

        public static int getIntPrice(GEItem Item)
        {
            String Price = Item.item.current.price;

            if (Price.IndexOf('.') != -1)
            {
                if (Price.IndexOf('b') != -1)
                {
                    Price = Price.Substring(0, Price.IndexOf('.')) +
                        Price[Price.IndexOf('.') + 1] + "00000000";
                }

                else if (Price.IndexOf('m') != -1)
                {
                    Price = Price.Substring(0, Price.IndexOf('.')) +
                        Price[Price.IndexOf('.') + 1] + "00000";
                }

                else if (Price.IndexOf('k') != -1)
                {
                    Price = Price.Substring(0, Price.IndexOf('.')) +
                        Price[Price.IndexOf('.') + 1] + "00";
                }
            }

            return Convert.ToInt32(Price);
        }
    }
}
