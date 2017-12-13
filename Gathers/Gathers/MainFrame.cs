using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gathers
{
    public partial class MainFrame : Form
    {
        int Display_Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        int Display_Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        

        public MainFrame()
        {
            InitializeComponent();

            this.MainTab.SizeMode = TabSizeMode.FillToRight;

            this.MainTab.Multiline = true;
            this.MainTab.Location = new Point(0, 25);
            this.MainTab.Size = new Size(Display_Width, Display_Height);
            this.MainTab.SizeMode = TabSizeMode.Normal;

            this.Size = new Size(300, 300);
            this.Controls.Add(MainTab);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(Display_Width, Display_Height);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
