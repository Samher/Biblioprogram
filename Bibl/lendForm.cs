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

        private Verk Search(string s)
        {
            foreach (Verk element in Form1.registry)
            {
                if (element.Title.ToUpper() == lndTtl1Box.Text.ToUpper())
                {
                    return element;
                }
            }
            return null;
        }

        private void lndCtnBtn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtl1Box.Text) != null)
            {
                lndTtlBoxG.Text = Search(lndTtl1Box.Text).Title;
                lndAuthBoxG.Text = Search(lndTtl1Box.Text).Author;
                lndLendBtn.Enabled = true;
                lndCcl1Btn.Enabled = true;
            }
        }

        private void lndLendBtn_Click(object sender, EventArgs e)
        {
            Search(lndTtlBoxG.Text).Lent = 1;
            lndTtlBoxG.Clear();
            lndAuthBoxG.Clear();
            lndTtl1Box.Clear();
            lndLendBtn.Enabled = false;
            lndCcl1Btn.Enabled = false;
        }

        private void lndCcl1Btn_Click(object sender, EventArgs e)
        {
            lndTtlBoxG.Clear();
            lndAuthBoxG.Clear();
            lndTtl1Box.Clear();
            lndLendBtn.Enabled = false;
            lndCcl1Btn.Enabled = false;
        }
    }
}
