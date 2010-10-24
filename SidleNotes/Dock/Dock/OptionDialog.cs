using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class OptionDialog : Form
    {


        private Screen screen = System.Windows.Forms.Screen.PrimaryScreen;

        public OptionDialog()
        {
            InitializeComponent();
        }

        private void OptionDialog_Load(object sender, EventArgs e)
        {
            //scrollWidth. = screen.Bounds.Width;
            lblFont.Text = Properties.Settings.Default.font.Name + ", " + Properties.Settings.Default.font.Size;
            lblBackColour.BackColor = Properties.Settings.Default.backcolour;
            lblBackColour.Text = Properties.Settings.Default.backcolour.Name.ToUpper();
            lblBackColour.ForeColor = Properties.Settings.Default.textcolour;
            lblFontColour.BackColor = Properties.Settings.Default.textcolour;
            lblFontColour.Text = Properties.Settings.Default.textcolour.Name.ToUpper();
        }
    }
}
