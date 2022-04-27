using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProjectLibrary
{
    public class EthereumProcessor
    {

        public static async Task<CryptoModel> LoadBitcoinInfo()
        {
            string url = "https://api.coincap.io/v2/assets/ethereum";

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
