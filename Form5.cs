using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace AracKullanimlari
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a sample application demonstrating menu usage in C# Windows Forms.", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oculusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://youtu.be/dYJrxezWLUk?si=HaZX3iE2eiU4leH9");
            label1.Text = oculusToolStripMenuItem.Text;
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://youtu.be/hEJnMQG9ev8?si=2b1j4a0g3k6c7d5B");
            label1.Text = madMaxToolStripMenuItem.Text;
        }

        private void theTrumanShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://youtu.be/dlnmQbPGuls?si=qtxtUhS98WPTrtK2");
            label1.Text = theTrumanShowToolStripMenuItem.Text;
        }

        private void ınterstellarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://youtu.be/zSWdZVtXT7E?si=puW8Y5cSTrYy40xB");
            label1.Text = ınterstellarToolStripMenuItem.Text;
        }
    }
}
