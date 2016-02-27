namespace NOISSystem.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.publicServicesButton = new DevExpress.XtraEditors.SimpleButton();
            this.transportButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // publicServicesButton
            // 
            this.publicServicesButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicServicesButton.Appearance.Options.UseFont = true;
            this.publicServicesButton.Location = new System.Drawing.Point(126, 77);
            this.publicServicesButton.Name = "publicServicesButton";
            this.publicServicesButton.Size = new System.Drawing.Size(176, 110);
            this.publicServicesButton.TabIndex = 6;
            this.publicServicesButton.Text = "Обществени\r\nУслуги";
            this.publicServicesButton.Click += new System.EventHandler(this.publicServicesButton_Click);
            // 
            // transportButton
            // 
            this.transportButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportButton.Appearance.Options.UseFont = true;
            this.transportButton.Location = new System.Drawing.Point(323, 77);
            this.transportButton.Name = "transportButton";
            this.transportButton.Size = new System.Drawing.Size(176, 110);
            this.transportButton.TabIndex = 7;
            this.transportButton.Text = "Транспорт";
            this.transportButton.Click += new System.EventHandler(this.TransportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 281);
            this.Controls.Add(this.transportButton);
            this.Controls.Add(this.publicServicesButton);
            this.LookAndFeel.SkinName = "Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MainForm";
            this.Text = "AIOBurgas";
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton publicServicesButton;
        private DevExpress.XtraEditors.SimpleButton transportButton;
    }
}

