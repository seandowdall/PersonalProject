using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProjectLibrary
{
    public class CryptoModel
    {
        public string name { get; set; }
        public int  rank { get; set; }
        public decimal priceUsd { get; set; }
        public string symbol { get; set; }
        public decimal marketCapUsd { get; set; }
        public decimal volumeUsd24Hr { get; set; }
        public decimal changePercent24Hr { get; set; }
    }
}
