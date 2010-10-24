using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShellLib;

namespace WindowsFormsApplication1
{
    public partial class SidleNotes : ShellLib.ApplicationDesktopToolbar
    {
       
        #region Private Variables

        private int stateFlag = 0;
        private Screen screen = System.Windows.Forms.Screen.PrimaryScreen;
       

        #endregion Private Variables
        
        public SidleNotes()
        {
            InitializeComponent();
            this.MouseHover += new EventHandler(Form1_MouseHover);
            this.Content.MouseLeave += new EventHandler(Form1_MouseLeave);
            this.Content.TextChanged += new EventHandler(Content_TextChanged);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Height = screen.WorkingArea.Height;
            this.Left = screen.Bounds.Width-2;
            this.Top = screen.WorkingArea.Top;
            Content.Height = this.Height - Content.Top;

            this.Width = Properties.Settings.Default.width;
            this.BackColor = Properties.Settings.Default.backcolour;
            Content.BackColor = Properties.Settings.Default.backcolour;
            Content.Font = Properties.Settings.Default.font;
            Content.ForeColor = Properties.Settings.Default.textcolour;
            Content.Text = Properties.Settings.Default.savedcontent;           
           
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

           if (stateFlag == 0)
            {
                this.Left = screen.Bounds.Width - this.Width;
            }
            
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (stateFlag == 0)
            {
                this.Left = screen.Bounds.Width - 2;
            }

        }

        private void dockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stateFlag == 0)
            {
                this.Left = screen.Bounds.Width;
                this.Edge = AppBarEdges.Right;
                stateFlag = 1;
            }
            else
            {
                this.Left = screen.Bounds.Width - 2;
                this.Edge = AppBarEdges.Float;
                stateFlag = 0;
            }
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedcontent = Content.Text;
            Properties.Settings.Default.Save();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionDialog options = new OptionDialog();
            options.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


