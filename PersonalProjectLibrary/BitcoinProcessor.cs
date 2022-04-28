using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProjectLibrary
{
    public class BitcoinProcessor
    {
        public static async Task<CryptoModel> LoadCryptoInfo()
        {
            string url = "https://api.coincap.io/v2/assets/bitcoin";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CryptoResultModel result = await response.Content.ReadAsAsync<CryptoResultModel>();

                    return result.data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }
    }
}
