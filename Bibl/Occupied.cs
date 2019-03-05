using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibl
{
    public partial class Occupied: Form
    {
        public Occupied()
        {
            InitializeComponent();
        }

        private void occClsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
