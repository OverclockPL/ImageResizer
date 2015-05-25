using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Overclock.pl_App
{
    public partial class GeneratedHTML : Form
    {
        private String code;

        public GeneratedHTML(String code)
        {
            this.code = code;

            InitializeComponent();

            textField.Text = (string)code;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(code);
        }
    }
}
