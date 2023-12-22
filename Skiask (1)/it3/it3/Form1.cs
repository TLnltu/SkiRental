using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it3
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mkorder_Click(object sender, EventArgs e)
        {
            Skiask f= new Skiask();
            f.ShowDialog();
        }
    }
}
