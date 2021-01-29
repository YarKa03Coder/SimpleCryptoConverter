
namespace SimpleCryptoConverter
{
    partial class HomePanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.convertionPanel = new System.Windows.Forms.Panel();
            this.resultTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.swapBox = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelPictureLeft = new System.Windows.Forms.PictureBox();
            this.panelLabelLeft = new System.Windows.Forms.Label();
            this.coinsComboBoxFirst = new System.Windows.Forms.ComboBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelPictureRight = new System.Windows.Forms.PictureBox();
            this.panelLabelRight = new System.Windows.Forms.Label();
            this.coinsComboBoxSecond = new System.Windows.Forms.ComboBox();
            this.leftDockPanel = new System.Windows.Forms.Panel();
            this.cryptoLtc = new CryptoCurrency();
            this.cryptoXmr = new CryptoCurrency();
            this.cryptoDot = new CryptoCurrency();
            this.cryptoEth = new CryptoCurrency();
            this.cryptoBtc = new CryptoCurrency();
            this.panelTop = new System.Windows.Forms.Panel();
            this.currentCostButton = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.convertionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swapBox)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPictureLeft)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPictureRight)).BeginInit();
            this.leftDockPanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentCostButton)).BeginInit();
            this.SuspendLayout();
            // 
            // convertionPanel
            // 
            this.convertionPanel.BackColor = System.Drawing.Color.White;
            this.convertionPanel.Controls.Add(this.resultTextBox);
            this.convertionPanel.Controls.Add(this.inputTextBox);
            this.convertionPanel.Controls.Add(this.convertButton);
            this.convertionPanel.Controls.Add(this.swapBox);
            this.convertionPanel.Controls.Add(this.panelLeft);
            this.convertionPanel.Controls.Add(this.panelRight);
            this.convertionPanel.Location = new System.Drawing.Point(320, 87);
            this.convertionPanel.Name = "convertionPanel";
            this.convertionPanel.Size = new System.Drawing.Size(568, 291);
            this.convertionPanel.TabIndex = 0;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultTextBox.BorderRadius = 14;
            this.resultTextBox.BorderThickness = 2;
            this.resultTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultTextBox.DefaultText = "";
            this.resultTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.resultTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.resultTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resultTextBox.DisabledState.Parent = this.resultTextBox;
            this.resultTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resultTextBox.Enabled = false;
            this.resultTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resultTextBox.FocusedState.Parent = this.resultTextBox;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resultTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resultTextBox.HoverState.Parent = this.resultTextBox;
            this.resultTextBox.Location = new System.Drawing.Point(328, 158);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.PasswordChar = '\0';
            this.resultTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.resultTextBox.PlaceholderText = "Result";
            this.resultTextBox.SelectedText = "";
            this.resultTextBox.ShadowDecoration.Parent = this.resultTextBox;
            this.resultTextBox.Size = new System.Drawing.Size(188, 36);
            this.resultTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.resultTextBox.TabIndex = 5;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputTextBox.BorderRadius = 14;
            this.inputTextBox.BorderThickness = 2;
            this.inputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTextBox.DefaultText = "";
            this.inputTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputTextBox.DisabledState.Parent = this.inputTextBox;
            this.inputTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputTextBox.FocusedState.Parent = this.inputTextBox;
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputTextBox.HoverState.Parent = this.inputTextBox;
            this.inputTextBox.Location = new System.Drawing.Point(21, 158);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.inputTextBox.PlaceholderText = "Input numerical value";
            this.inputTextBox.SelectedText = "";
            this.inputTextBox.ShadowDecoration.Parent = this.inputTextBox;
            this.inputTextBox.Size = new System.Drawing.Size(190, 36);
            this.inputTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.inputTextBox.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.Black;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(185, 230);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(176, 40);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert Now";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // swapBox
            // 
            this.swapBox.Image = global::SimpleCryptoConverter.Properties.Resources.SwapButton;
            this.swapBox.Location = new System.Drawing.Point(251, 61);
            this.swapBox.Name = "swapBox";
            this.swapBox.Size = new System.Drawing.Size(41, 33);
            this.swapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.swapBox.TabIndex = 2;
            this.swapBox.TabStop = false;
            this.swapBox.Click += new System.EventHandler(this.SwapBox_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.panelPictureLeft);
            this.panelLeft.Controls.Add(this.panelLabelLeft);
            this.panelLeft.Controls.Add(this.coinsComboBoxFirst);
            this.panelLeft.Location = new System.Drawing.Point(23, 51);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(188, 68);
            this.panelLeft.TabIndex = 1;
            // 
            // panelPictureLeft
            // 
            this.panelPictureLeft.Image = global::SimpleCryptoConverter.Properties.Resources.Bitcoin;
            this.panelPictureLeft.Location = new System.Drawing.Point(141, 4);
            this.panelPictureLeft.Name = "panelPictureLeft";
            this.panelPictureLeft.Size = new System.Drawing.Size(34, 30);
            this.panelPictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelPictureLeft.TabIndex = 2;
            this.panelPictureLeft.TabStop = false;
            // 
            // panelLabelLeft
            // 
            this.panelLabelLeft.AutoSize = true;
            this.panelLabelLeft.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.panelLabelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLabelLeft.Location = new System.Drawing.Point(12, 10);
            this.panelLabelLeft.Name = "panelLabelLeft";
            this.panelLabelLeft.Size = new System.Drawing.Size(72, 23);
            this.panelLabelLeft.TabIndex = 1;
            this.panelLabelLeft.Text = "Bitcoin";
            // 
            // coinsComboBoxFirst
            // 
            this.coinsComboBoxFirst.BackColor = System.Drawing.Color.WhiteSmoke;
            this.coinsComboBoxFirst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.coinsComboBoxFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coinsComboBoxFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coinsComboBoxFirst.Location = new System.Drawing.Point(0, 44);
            this.coinsComboBoxFirst.Name = "coinsComboBoxFirst";
            this.coinsComboBoxFirst.Size = new System.Drawing.Size(188, 24);
            this.coinsComboBoxFirst.TabIndex = 0;
            this.coinsComboBoxFirst.SelectedIndexChanged += new System.EventHandler(this.CoinsComboBox_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRight.Controls.Add(this.panelPictureRight);
            this.panelRight.Controls.Add(this.panelLabelRight);
            this.panelRight.Controls.Add(this.coinsComboBoxSecond);
            this.panelRight.Location = new System.Drawing.Point(328, 51);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(188, 68);
            this.panelRight.TabIndex = 0;
            // 
            // panelPictureRight
            // 
            this.panelPictureRight.Image = global::SimpleCryptoConverter.Properties.Resources.Ethereum;
            this.panelPictureRight.Location = new System.Drawing.Point(140, 5);
            this.panelPictureRight.Name = "panelPictureRight";
            this.panelPictureRight.Size = new System.Drawing.Size(32, 32);
            this.panelPictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelPictureRight.TabIndex = 3;
            this.panelPictureRight.TabStop = false;
            // 
            // panelLabelRight
            // 
            this.panelLabelRight.AutoSize = true;
            this.panelLabelRight.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.panelLabelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLabelRight.Location = new System.Drawing.Point(13, 10);
            this.panelLabelRight.Name = "panelLabelRight";
            this.panelLabelRight.Size = new System.Drawing.Size(96, 23);
            this.panelLabelRight.TabIndex = 2;
            this.panelLabelRight.Text = "Ethereum";
            // 
            // coinsComboBoxSecond
            // 
            this.coinsComboBoxSecond.BackColor = System.Drawing.Color.WhiteSmoke;
            this.coinsComboBoxSecond.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.coinsComboBoxSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coinsComboBoxSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coinsComboBoxSecond.Location = new System.Drawing.Point(0, 44);
            this.coinsComboBoxSecond.Name = "coinsComboBoxSecond";
            this.coinsComboBoxSecond.Size = new System.Drawing.Size(188, 24);
            this.coinsComboBoxSecond.TabIndex = 1;
            this.coinsComboBoxSecond.SelectedIndexChanged += new System.EventHandler(this.CoinsComboBox_SelectedIndexChanged);
            // 
            // leftDockPanel
            // 
            this.leftDockPanel.Controls.Add(this.cryptoLtc);
            this.leftDockPanel.Controls.Add(this.cryptoXmr);
            this.leftDockPanel.Controls.Add(this.cryptoDot);
            this.leftDockPanel.Controls.Add(this.cryptoEth);
            this.leftDockPanel.Controls.Add(this.cryptoBtc);
            this.leftDockPanel.Controls.Add(this.panelTop);
            this.leftDockPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftDockPanel.Location = new System.Drawing.Point(0, 0);
            this.leftDockPanel.Name = "leftDockPanel";
            this.leftDockPanel.Size = new System.Drawing.Size(303, 450);
            this.leftDockPanel.TabIndex = 1;
            // 
            // cryptoLtc
            // 
            this.cryptoLtc.CryptoImage = global::SimpleCryptoConverter.Properties.Resources.Litecoin;
            this.cryptoLtc.CryptoName = "Litecoin";
            this.cryptoLtc.CryptoTitle = "LTC";
            this.cryptoLtc.CryptoValue = "$125.15";
            this.cryptoLtc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptoLtc.Location = new System.Drawing.Point(3, 363);
            this.cryptoLtc.Name = "cryptoLtc";
            this.cryptoLtc.Size = new System.Drawing.Size(297, 63);
            this.cryptoLtc.TabIndex = 5;
            // 
            // cryptoXmr
            // 
            this.cryptoXmr.CryptoImage = global::SimpleCryptoConverter.Properties.Resources.Monero;
            this.cryptoXmr.CryptoName = "Monero";
            this.cryptoXmr.CryptoTitle = "XMR";
            this.cryptoXmr.CryptoValue = "$129.65";
            this.cryptoXmr.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptoXmr.Location = new System.Drawing.Point(3, 294);
            this.cryptoXmr.Name = "cryptoXmr";
            this.cryptoXmr.Size = new System.Drawing.Size(297, 63);
            this.cryptoXmr.TabIndex = 4;
            // 
            // cryptoDot
            // 
            this.cryptoDot.CryptoImage = global::SimpleCryptoConverter.Properties.Resources.Polkadot;
            this.cryptoDot.CryptoName = "Polkadot";
            this.cryptoDot.CryptoTitle = "DOT";
            this.cryptoDot.CryptoValue = "$15.59";
            this.cryptoDot.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptoDot.Location = new System.Drawing.Point(3, 225);
            this.cryptoDot.Name = "cryptoDot";
            this.cryptoDot.Size = new System.Drawing.Size(297, 63);
            this.cryptoDot.TabIndex = 3;
            // 
            // cryptoEth
            // 
            this.cryptoEth.CryptoImage = global::SimpleCryptoConverter.Properties.Resources.Ethereum;
            this.cryptoEth.CryptoName = "Ethereum";
            this.cryptoEth.CryptoTitle = "ETH";
            this.cryptoEth.CryptoValue = "$1291.01";
            this.cryptoEth.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptoEth.Location = new System.Drawing.Point(3, 156);
            this.cryptoEth.Name = "cryptoEth";
            this.cryptoEth.Size = new System.Drawing.Size(297, 63);
            this.cryptoEth.TabIndex = 2;
            // 
            // cryptoBtc
            // 
            this.cryptoBtc.CryptoImage = ((System.Drawing.Image)(resources.GetObject("cryptoBtc.CryptoImage")));
            this.cryptoBtc.CryptoName = "Bitcoin";
            this.cryptoBtc.CryptoTitle = "BTC";
            this.cryptoBtc.CryptoValue = "31246.45";
            this.cryptoBtc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cryptoBtc.Location = new System.Drawing.Point(3, 87);
            this.cryptoBtc.Name = "cryptoBtc";
            this.cryptoBtc.Size = new System.Drawing.Size(297, 63);
            this.cryptoBtc.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.currentCostButton);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(303, 76);
            this.panelTop.TabIndex = 0;
            // 
            // currentCostButton
            // 
            this.currentCostButton.Image = global::SimpleCryptoConverter.Properties.Resources.SwapButton;
            this.currentCostButton.Location = new System.Drawing.Point(237, 29);
            this.currentCostButton.Name = "currentCostButton";
            this.currentCostButton.Size = new System.Drawing.Size(41, 33);
            this.currentCostButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.currentCostButton.TabIndex = 6;
            this.currentCostButton.TabStop = false;
            this.currentCostButton.Click += new System.EventHandler(this.CurrentCostButton_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(219, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Cryptocurrencies ";
            // 
            // HomePanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.leftDockPanel);
            this.Controls.Add(this.convertionPanel);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(910, 450);
            this.convertionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.swapBox)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPictureLeft)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelPictureRight)).EndInit();
            this.leftDockPanel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentCostButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel convertionPanel;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ComboBox coinsComboBoxFirst;
        private System.Windows.Forms.ComboBox coinsComboBoxSecond;
        private System.Windows.Forms.PictureBox swapBox;
        private System.Windows.Forms.Button convertButton;
        private Guna.UI2.WinForms.Guna2TextBox inputTextBox;
        private Guna.UI2.WinForms.Guna2TextBox resultTextBox;
        private System.Windows.Forms.Label panelLabelLeft;
        private System.Windows.Forms.Label panelLabelRight;
        private System.Windows.Forms.PictureBox panelPictureLeft;
        private System.Windows.Forms.PictureBox panelPictureRight;
        private System.Windows.Forms.Panel leftDockPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox currentCostButton;
        private CryptoCurrency cryptoBtc;
        private CryptoCurrency cryptoEth;
        private CryptoCurrency cryptoDot;
        private CryptoCurrency cryptoXmr;
        private CryptoCurrency cryptoLtc;
    }
}
