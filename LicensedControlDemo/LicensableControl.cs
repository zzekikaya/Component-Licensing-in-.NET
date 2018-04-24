using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ingenious.Licensing;

namespace LicensedControlDemo
{
    [LicenseProvider(typeof(Ingenious.Licensing.ComponentLicenseProvider))]
    public partial class LicensableControl : UserControl
    {

        #region Fields

        private bool _isDemo = true;
        private static string _licKey = "";

        #endregion

        #region Properties



        /// <summary>
        /// Gets/sets the developer key for use on this control.
        /// </summary>
        [Category("License"), Description("Sets the license key for use on the control.")]
        public string LicenseKey 
        {
            get { return LicensableControl.DeveloperKey; }
            set 
            {
                LicensableControl.DeveloperKey = value;
                CheckLicense();
                this.Invalidate();
            }
        }

        [Browsable(false)]
        public static string DeveloperKey { get; set; }

        #endregion

        #region Construction / Deconstruction 

        public LicensableControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            
            CheckLicense();
        }

        #endregion

        #region Protected Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            string text = (_isDemo ? "This control is running in demo mode." : "This is a fully licensed control.");

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
            e.Graphics.DrawString(text, Font, Brushes.Black, ClientRectangle, sf);
        }

        #endregion

        #region Private Methods

        private void CheckLicense()
        {
            ComponentLicense lic = LicenseManager.Validate(typeof(LicensableControl), this) as ComponentLicense;

            if (lic != null)
            {
                _isDemo = lic.IsDemo;
            }
        }

        #endregion

    }
}
