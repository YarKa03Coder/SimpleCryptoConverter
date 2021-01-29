using System.Drawing;
using System.Windows.Forms;

namespace SimpleCryptoConverter
{
    public partial class CryptoCurrency : UserControl
    {
        public CryptoCurrency()
        {
            InitializeComponent();
        }

        public Image CryptoImage
        {
            get => coinPicture.Image;
            set => coinPicture.Image = value;
        }
        
        public string CryptoTitle
        {
            get => labelTitle.Text;
            set => labelTitle.Text = value;
        }
        
        public string CryptoName
        {
            get => labelName.Text;
            set => labelName.Text = value;
        }
        
        public string CryptoValue
        {
            get => labelCost.Text;
            set => labelCost.Text = value;
        }
    }
}
