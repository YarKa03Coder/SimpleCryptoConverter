using System;
using System.Globalization;
using System.Windows.Forms;

namespace SimpleCryptoConverter
{
    public partial class HomePanel : UserControl
    {
        public HomePanel()
        {
            InitializeComponent();

            var comboList = new object[]
                { cryptoBtc.CryptoName, cryptoEth.CryptoName, cryptoDot.CryptoName, cryptoXmr.CryptoName, cryptoLtc.CryptoName};

            coinsComboBoxFirst.Parent = this.panelLeft;
            coinsComboBoxSecond.Parent = this.panelRight;

            coinsComboBoxFirst.Items.AddRange(comboList);
            coinsComboBoxSecond.Items.AddRange(comboList);

            // 'Default' selected items
            coinsComboBoxFirst.SelectedItem = coinsComboBoxFirst.Items[0];
            coinsComboBoxSecond.SelectedItem = coinsComboBoxSecond.Items[1];
        }

        private void SwapLabelInfo()
        {
            var tempLabelText = panelLabelLeft.Text;
            panelLabelLeft.Text = panelLabelRight.Text;
            panelLabelRight.Text = tempLabelText;
        }

        private void SwapPictures()
        {
            var tempPicture = panelPictureLeft.Image;
            panelPictureLeft.Image = panelPictureRight.Image;
            panelPictureRight.Image = tempPicture;

        }

        private void SwapComboBoxInfo()
        {
            var tempItem = coinsComboBoxFirst.SelectedItem;
            coinsComboBoxFirst.SelectedItem = coinsComboBoxSecond.SelectedItem;
            coinsComboBoxSecond.SelectedItem = tempItem;
        }

        private void SwapBox_Click(object sender, EventArgs e)
        {
            SwapLabelInfo();
            SwapPictures();
            SwapComboBoxInfo();
            inputTextBox.Clear();
            resultTextBox.Clear();
        }

        private void CoinsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBox)sender);
            var selectedItemValue = selectedItem.SelectedItem.ToString();

            if (selectedItem.Parent.Name == nameof(panelLeft))
            {
                panelLabelLeft.Text = selectedItemValue;
                panelPictureLeft.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(selectedItemValue);
            }
            else
            {
                panelLabelRight.Text = selectedItemValue;
                panelPictureRight.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(selectedItemValue);
            }
        }

        private async void ConvertButton_Click(object sender, EventArgs e)
        {
            var baseCurrencyName = coinsComboBoxFirst.SelectedItem.ToString();
            var quoteCurrencyName = coinsComboBoxSecond.SelectedItem.ToString();

            var baseCurrencyTitle = FindTitleByName(baseCurrencyName);
            var quoteCurrencyTitle = FindTitleByName(quoteCurrencyName);
            
            try
            {
                var convertResult = await CoinPaprika.Convert(string.Concat(new[] { baseCurrencyTitle, "-", baseCurrencyName}),
                string.Concat(new[] { quoteCurrencyTitle, "-", quoteCurrencyName}),
                Convert.ToDouble(inputTextBox.Text, CultureInfo.InvariantCulture));

                resultTextBox.Text = convertResult;
            }
            catch (Exception exception)
            {
                string messageBoxText = $"{exception.Message}\r\n1. Check the entered value.\r\n2. Check your internet connection.";
                MessageBox.Show(messageBoxText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static string FindTitleByName(string name)
        {
            var foundedTitle = string.Empty;
            
            switch (name)
            {
                case "Bitcoin":
                    foundedTitle = "BTC".ToLower();
                    break;
                case "Ethereum":
                    foundedTitle = "ETH".ToLower();
                    break;
                case "Polkadot":
                    foundedTitle = "DOT".ToLower();
                    break;
                case "Monero":
                    foundedTitle = "XMR".ToLower();
                    break;
                case "Litecoin":
                    foundedTitle = "LTC".ToLower();
                    break;
            }

            return foundedTitle;
        }

        private async void CurrentCostButton_Click(object sender, EventArgs e)
        {
            var currencies = new[]{cryptoBtc, cryptoDot, cryptoEth, cryptoLtc, cryptoXmr};
            try
            {
                foreach (var currency in currencies)
                {
                    string price = await CoinPaprika.GetCoinInfo(currency.CryptoTitle, currency.CryptoName);
                    currency.CryptoValue = price;
                }
            }
            catch (Exception exception)
            {
                string messageBoxText = $"{exception.Message}\r\n1. Check the entered value.\r\n2. Check your internet connection.";
                MessageBox.Show(messageBoxText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
