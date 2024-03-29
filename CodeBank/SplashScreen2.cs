﻿using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeBank
{
    public partial class SplashScreen2 : SplashScreen
    {
        public SplashScreen2()
        {
            InitializeComponent();
            this.labelCopyright.Text = DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreen2_Load(object sender, EventArgs e)
        {
            label1.Parent = peImage; 
            label1.BackColor = Color.Transparent;
        }
    }
}