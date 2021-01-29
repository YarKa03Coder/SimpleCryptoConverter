
namespace SimpleCryptoConverter
{
    partial class CryptoCurrency
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
            this.coinPicture = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // coinPicture
            // 
            this.coinPicture.Image = global::SimpleCryptoConverter.Properties.Resources.Bitcoin;
            this.coinPicture.Location = new System.Drawing.Point(13, 15);
            this.coinPicture.Name = "coinPicture";
            this.coinPicture.Size = new System.Drawing.Size(31, 31);
            this.coinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinPicture.TabIndex = 0;
            this.coinPicture.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelName.Location = new System.Drawing.Point(55, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(55, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(46, 23);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCost.Location = new System.Drawing.Point(189, 18);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(65, 23);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "$9500";
            // 
            // CryptoCurrency
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.coinPicture);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CryptoCurrency";
            this.Size = new System.Drawing.Size(277, 63);
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coinPicture;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCost;
    }
}
