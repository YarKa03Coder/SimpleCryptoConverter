
namespace SimpleCryptoConverter
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.panelDockStyle = new System.Windows.Forms.Panel();
            this.homePanel = new HomePanel();
            this.elipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components)
            {
                TargetControl = this,
                BorderRadius = 22
            };
            this.elipsePanel = new Guna.UI2.WinForms.Guna2Elipse(this.components)
            {
                TargetControl = this.panel,
                BorderRadius = 22
            };
            this.panel.SuspendLayout();
            this.panelDockStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.panel.Controls.Add(this.panelDockStyle);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(5, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(980, 474);
            this.panel.TabIndex = 0;
            // 
            // panelDockStyle
            // 
            this.panelDockStyle.Controls.Add(this.homePanel);
            this.panelDockStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDockStyle.Location = new System.Drawing.Point(0, 0);
            this.panelDockStyle.Name = "panelDockStyle";
            this.panelDockStyle.Size = new System.Drawing.Size(980, 474);
            this.panelDockStyle.TabIndex = 0;
            // 
            // homePanel
            // 
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(980, 474);
            this.homePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(990, 484);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panelDockStyle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Guna.UI2.WinForms.Guna2Elipse elipseForm;
        private Guna.UI2.WinForms.Guna2Elipse elipsePanel;
        private HomePanel homePanel;
        private System.Windows.Forms.Panel panelDockStyle;
    }
}

