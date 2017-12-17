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
        private void create_new_ref_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Add(reference_create);
            this.MainTab.SelectTab(reference_create);
        }

        private void ref_cancel_btn_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Remove(reference_create);
            this.MainTab.SelectTab(reference);
        }

    }
}