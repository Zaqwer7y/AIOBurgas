namespace NOISSystem.Forms
{
    partial class PublicServicesForm
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
            this.blueZoneMapButton = new DevExpress.XtraEditors.SimpleButton();
            this.taxiServiceButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // blueZoneMapButton
            // 
            this.blueZoneMapButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueZoneMapButton.Appearance.Options.UseFont = true;
            this.blueZoneMapButton.Location = new System.Drawing.Point(12, 12);
            this.blueZoneMapButton.Name = "blueZoneMapButton";
            this.blueZoneMapButton.Size = new System.Drawing.Size(176, 110);
            this.blueZoneMapButton.TabIndex = 6;
            this.blueZoneMapButton.Text = "Синя Зона\r\nБургас\r\n";
            this.blueZoneMapButton.Click += new System.EventHandler(this.BlueZoneMapButton_Click);
            // 
            // taxiServiceButton
            // 
            this.taxiServiceButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxiServiceButton.Appearance.Options.UseFont = true;
            this.taxiServiceButton.Location = new System.Drawing.Point(272, 12);
            this.taxiServiceButton.Name = "taxiServiceButton";
            this.taxiServiceButton.Size = new System.Drawing.Size(176, 110);
            this.taxiServiceButton.TabIndex = 7;
            this.taxiServiceButton.Text = "Таксиметрови\r\nУслуги\r\n";
            this.taxiServiceButton.Click += new System.EventHandler(this.TaxiServiceButton_Click);
            // 
            // PublicServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 285);
            this.Controls.Add(this.taxiServiceButton);
            this.Controls.Add(this.blueZoneMapButton);
            this.LookAndFeel.SkinName = "Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "PublicServicesForm";
            this.Text = "AIOBurgas - PublicServices";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton blueZoneMapButton;
        private DevExpress.XtraEditors.SimpleButton taxiServiceButton;
    }
}