using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PersonalProjectLibrary;
using System.Data.SqlClient;

namespace PersonalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();

            
        }

        private async void loadBitcoinInfo_Click(object sender, RoutedEventArgs e)
        {
            var cryptoInfo = await BitcoinProcessor.LoadCryptoInfo();
            
            cryptoText.Text = $" Name:   { cryptoInfo.name}\n Symbol:   {cryptoInfo.symbol}\n Rank:   {cryptoInfo.rank}\n Price:   ${Math.Round(cryptoInfo.priceUsd, 2)}\n Market Cap:   ${Math.Round(cryptoInfo.marketCapUsd, 2)}\n Volume(24Hr):   ${Math.Round(cryptoInfo.volumeUsd24Hr, 2)}\n Change(24Hr):   {Math.Round(cryptoInfo.changePercent24Hr, 2)}%";

        }

        private async void loadEthereuminfo_Click(object sender, RoutedEventArgs e)
        {
            var cryptoInfo = await EthereumProcessor.LoadCryptoInfo();

            cryptoText.Text = $" Name:   { cryptoInfo.name}\n Symbol:   {cryptoInfo.symbol}\n Rank:   {cryptoInfo.rank}\n Price:   ${Math.Round(cryptoInfo.priceUsd, 2)}\n Market Cap:   ${Math.Round(cryptoInfo.marketCapUsd, 2)}\n Volume(24Hr):   ${Math.Round(cryptoInfo.volumeUsd24Hr, 2)}\n Change(24Hr):   {Math.Round(cryptoInfo.changePercent24Hr, 2)}%";
        }

        private async void loadXRPinfo_Click(object sender, RoutedEventArgs e)
        {
            var cryptoInfo = await XrpProcessor.LoadCryptoInfo();

            cryptoText.Text = $" Name:   { cryptoInfo.name}\n Symbol:   {cryptoInfo.symbol}\n Rank:   {cryptoInfo.rank}\n Price:   ${Math.Round(cryptoInfo.priceUsd, 2)}\n Market Cap:   ${Math.Round(cryptoInfo.marketCapUsd, 2)}\n Volume(24Hr):   ${Math.Round(cryptoInfo.volumeUsd24Hr, 2)}\n Change(24Hr):   {Math.Round(cryptoInfo.changePercent24Hr, 2)}%";
        }

        private async void loadCardanoinfo_Click(object sender, RoutedEventArgs e)
        {
            var cryptoInfo = await CardanoProcessor.LoadCryptoInfo();

            cryptoText.Text = $" Name:   { cryptoInfo.name}\n Symbol:   {cryptoInfo.symbol}\n Rank:   {cryptoInfo.rank}\n Price:   ${Math.Round(cryptoInfo.priceUsd, 2)}\n Market Cap:   ${Math.Round(cryptoInfo.marketCapUsd, 2)}\n Volume(24Hr):   ${Math.Round(cryptoInfo.volumeUsd24Hr, 2)}\n Change(24Hr):   {Math.Round(cryptoInfo.changePercent24Hr, 2)}%";
        }

        private async void loadSolanainfo_Click(object sender, RoutedEventArgs e)
        {
            var cryptoInfo = await SolanaProcessor.LoadCryptoInfo();

            cryptoText.Text = $" Name:   { cryptoInfo.name}\n Symbol:   {cryptoInfo.symbol}\n Rank:   {cryptoInfo.rank}\n Price:   ${Math.Round(cryptoInfo.priceUsd, 2)}\n Market Cap:   ${Math.Round(cryptoInfo.marketCapUsd, 2)}\n Volume(24Hr):   ${Math.Round(cryptoInfo.volumeUsd24Hr, 2)}\n Change(24Hr):   {Math.Round(cryptoInfo.changePercent24Hr, 2)}%";
        }

        private async void CryptoTable_Loaded(object sender, RoutedEventArgs e)
        {
            var cryptoInfo1 = await BitcoinProcessor.LoadCryptoInfo();
            var cryptoInfo2 = await EthereumProcessor.LoadCryptoInfo();
            var cryptoInfo3 = await XrpProcessor.LoadCryptoInfo();
            var cryptoInfo4 = await CardanoProcessor.LoadCryptoInfo();
            var cryptoInfo5 = await SolanaProcessor.LoadCryptoInfo();

            DataGridCrypto.Items.Add(cryptoInfo1);
            DataGridCrypto.Items.Add(cryptoInfo2);
            DataGridCrypto.Items.Add(cryptoInfo3);
            DataGridCrypto.Items.Add(cryptoInfo4);
            DataGridCrypto.Items.Add(cryptoInfo5);
        }

        private async void Save_Grid_Data(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\seani\Downloads\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30");

            var cryptoInfo1 = await BitcoinProcessor.LoadCryptoInfo();
            var cryptoInfo2 = await EthereumProcessor.LoadCryptoInfo();
            var cryptoInfo3 = await XrpProcessor.LoadCryptoInfo();
            var cryptoInfo4 = await CardanoProcessor.LoadCryptoInfo();
            var cryptoInfo5 = await SolanaProcessor.LoadCryptoInfo();


            SqlCommand cmd1 = new SqlCommand(@"INSERT INTO CryptoTable (Name, Symbol, Rank, Price, MarketCap, Volume, Change) VALUES ('"+cryptoInfo1.name+"','"+cryptoInfo1.symbol + "','" + cryptoInfo1.rank+"','"+cryptoInfo1.priceUsd+"','"+cryptoInfo1.marketCapUsd+"','"+cryptoInfo1.volumeUsd24Hr+"','"+cryptoInfo1.changePercent24Hr+"')",con);
            SqlCommand cmd2 = new SqlCommand(@"INSERT INTO CryptoTable (Name, Symbol, Rank, Price, MarketCap, Volume, Change) VALUES ('" + cryptoInfo2.name + "','" + cryptoInfo2.symbol + "','" + cryptoInfo2.rank + "','" + cryptoInfo2.priceUsd + "','" + cryptoInfo2.marketCapUsd + "','" + cryptoInfo2.volumeUsd24Hr + "','" + cryptoInfo2.changePercent24Hr + "')", con);
            SqlCommand cmd3 = new SqlCommand(@"INSERT INTO CryptoTable (Name, Symbol, Rank, Price, MarketCap, Volume, Change) VALUES ('" + cryptoInfo3.name + "','" + cryptoInfo3.symbol + "','" + cryptoInfo3.rank + "','" + cryptoInfo3.priceUsd + "','" + cryptoInfo3.marketCapUsd + "','" + cryptoInfo3.volumeUsd24Hr + "','" + cryptoInfo3.changePercent24Hr + "')", con);
            SqlCommand cmd4 = new SqlCommand(@"INSERT INTO CryptoTable (Name, Symbol, Rank, Price, MarketCap, Volume, Change) VALUES ('" + cryptoInfo4.name + "','" + cryptoInfo4.symbol + "','" + cryptoInfo4.rank + "','" + cryptoInfo4.priceUsd + "','" + cryptoInfo4.marketCapUsd + "','" + cryptoInfo4.volumeUsd24Hr + "','" + cryptoInfo4.changePercent24Hr + "')", con);
            SqlCommand cmd5 = new SqlCommand(@"INSERT INTO CryptoTable (Name, Symbol, Rank, Price, MarketCap, Volume, Change) VALUES ('" + cryptoInfo5.name + "','" + cryptoInfo5.symbol + "','" + cryptoInfo5.rank + "','" + cryptoInfo5.priceUsd + "','" + cryptoInfo5.marketCapUsd + "','" + cryptoInfo5.volumeUsd24Hr + "','" + cryptoInfo5.changePercent24Hr + "')", con);

            con.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            con.Close();


            successMessage.Text = $"Success! - This Data has been added to your database!";

            
            
            DataGridCrypto.Items.Clear();

        }
    }
}
