using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ingenious.Licensing.FactoryUtilities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_GenKey_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();

            string strGuid = guid.ToString();

            byte[] guidBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(strGuid);

            uint crc = Crc32.Compute(guidBytes);

            strGuid += "-" + crc.ToString("x8");

            tbx_LicKey.Text = strGuid;
        }
    }
}
