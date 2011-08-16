using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace multiconvert_html
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Convert from RAW text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnRaw_Click(object sender, EventArgs e)
        {
            FillAll(txtRaw.Text);
        }

        /// <summary>
        /// Convert from URL text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnURL_Click(object sender, EventArgs e)
        {
            try
            {
                FillAll(HttpUtility.UrlDecode(txtURL.Text));
            }
            catch
            {
                MessageBox.Show("URL encoded is invalid");
            }
        }

        /// <summary>
        /// Convert from HTML text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnHTML_Click(object sender, EventArgs e)
        {
            try
            {
                FillAll(HttpUtility.HtmlDecode(txtHTML.Text));
            }
            catch
            {
                MessageBox.Show("HTML encoded is invalid");
            }
        }

        /// <summary>
        /// Fill all 3 textboxes with converted text.
        /// </summary>
        /// <param name="text">RAW text</param>

        private void FillAll(string text)
        {
            txtRaw.Text = text;
            txtHTML.Text = HttpUtility.HtmlEncode(text);
            txtURL.Text = HttpUtility.UrlEncode(text).Replace("+", "%20");
        }
    }
}
