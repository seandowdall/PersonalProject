using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PersonalProjectLibrary
{
    //allows us to make calls on the internet
    public class ApiHelper
    {
        //static - to open once per application
        public static HttpClient ApiClient { get; set; }

        //setup the api client
        public static void InitializeClient()
        {
            

            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
