using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Price_Comparison
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            lblDesigned.Show();
            lblLoading.Show();
            lblWelcome.Show();
        }
    }

    
}
