﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace TheChromiumBowser
{
    public partial class Browser : Form
    {
        private ChromiumWebBrowser browser;

        public Browser()
        {
            InitializeComponent();
            InitializeBrowser();
            InitializeForm();
        }

        private void InitializeForm()
        {
            BrowserTabs.Height = ClientRectangle.Height -25;
        }

        private void InitializeBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://datorium.eu");
            browser.Dock = DockStyle.Fill;
            BrowserTabs.TabPages[0].Controls.Add(browser);
            browser.AddressChanged += Browser_AddressChanged;
        }

        private void toolStripGoButton_Click(object sender, EventArgs e)
        {
            Navigate(toolStripAddressBar.Text);
        }

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            //var selectedBrowser = (ChromiumWebBrowser)sender;
            this.Invoke(new MethodInvoker(() =>
            {
                toolStripAddressBar.Text = e.Address;
            }));
        }

        private void toolStripReload_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void toolStripAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Navigate(toolStripAddressBar.Text);
            }
        }

        private void Navigate(string address)
        {
            try
            {
                browser.Load(address);
            }
            catch
            {

            }
        }

        private void toolStripButtonAddTab_Click(object sender, EventArgs e)
        {
            var newTabPage = new TabPage();
            newTabPage.Text = "New Tab";
            BrowserTabs.TabPages.Add(newTabPage);
        }
    }
}
