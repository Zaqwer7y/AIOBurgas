using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NOISSystem.Forms
{
    public partial class TaxiForm : DevExpress.XtraEditors.XtraForm
    {
        public TaxiForm()
        {
            InitializeComponent();
            this.locationView.OptionsView.ShowGroupPanel = false;
        }
    }
}