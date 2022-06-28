using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
    public partial class InputTextForm : Form
    {
        public InputTextForm()
        {
            InitializeComponent();
        }

        private void myOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
