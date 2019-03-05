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
    public partial class lendForm : Form
    {
        public lendForm()
        {
            InitializeComponent();
        }

        private void lndCtnBtn_Click(object sender, EventArgs e)
        {
            foreach (Verk element in Form1.registry)
            {
                if (element.Title.ToUpper() == lndTtl1Box.Text.ToUpper())
                {
                    lndTtlBoxG.Text = element.Title;
                    lndAuthBoxG.Text = element.Author;
                }
            }
        }

        private void lndLendBtn_Click(object sender, EventArgs e)
        {

        }

        private void lndCcl1Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
