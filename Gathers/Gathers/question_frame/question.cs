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
        private void Question_create_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Add(create_Question);
            this.MainTab.SelectTab(create_Question);
        }

        private void create_question_cancel_Click(object sender, EventArgs e)
        {
            this.MainTab.TabPages.Remove(create_Question);
        }
    }
}
