using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Splashscreen;

namespace CSharp_ProgressBarAndStatusLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Idle += new EventHandler(OnLoaded);
        }

        /// <summary>
        /// Custom "OnLoaded" event.  Fired after form finished loaded & displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected virtual void OnLoaded(object sender, EventArgs args)
        {
            Application.Idle -= new EventHandler(OnLoaded);
            
            //Shut down the splashscreen
            SplashscreenController.CloseSplash();
        }

        #region Sample application logic
        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            ds.ReadXml(Application.StartupPath + @"\GoogleLocations.DataSet1.xml");
            UrlBindingSource.DataSource = ds;

            URLDropDown.SelectedIndex = 0;
        }

        private void FetchButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Fetching Google Map...";
            toolStripStatusLabel1.Visible = true;
            toolStripProgressBar1.Visible = true;

            webBrowser1.Url = new Uri(URLDropDown.SelectedValue.ToString());

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Visible = false;
            toolStripProgressBar1.Visible = false;
        }
        #endregion
    }
}