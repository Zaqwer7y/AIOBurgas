using System;
using System.Collections.Generic;
using NOISSystem.Models;

namespace NOISSystem.Forms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<Train> trains = BurgasService.TrainsArrival();

        }

        private void TransportButton_Click(object sender, EventArgs e)
        {
            var transportForm = new TransportForm();
            transportForm.Show();
        }

        private void publicServicesButton_Click(object sender, EventArgs e)
        {
            var publicServicesForm = new PublicServicesForm();
            publicServicesForm.Show();
        }
    }
}
