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
            var cryptoInfo = await BitcoinProcessor.LoadBitcoinInfo();

            cryptoText.Text = $" Name: { cryptoInfo.id}\n Rank: {cryptoInfo.rank}\n Price: {cryptoInfo.priceUsd}";

        }

        private async void loadEthereuminfo_Click(object sender, RoutedEventArgs e)
        {
            var cryptoInfo = await EthereumProcessor.LoadBitcoinInfo();

            cryptoText.Text = $" Name: { cryptoInfo.id}\n Rank: {cryptoInfo.rank}\n Price: {cryptoInfo.priceUsd}";
        }

        private async void loadXRPinfo_Click(object sender, RoutedEventArgs e)
        {
            var cryptoInfo = await XrpProcessor.LoadBitcoinInfo();

            cryptoText.Text = $" Name: { cryptoInfo.id}\n Rank: {cryptoInfo.rank}\n Price: {cryptoInfo.priceUsd}";
        }

        private async void loadCardanoinfo_Click(object sender, RoutedEventArgs e)
        {
            var cryptoInfo = await CardanoProcessor.LoadBitcoinInfo();

            cryptoText.Text = $" Name: { cryptoInfo.id}\n Rank: {cryptoInfo.rank}\n Price: {cryptoInfo.priceUsd}";
        }
    }
}
