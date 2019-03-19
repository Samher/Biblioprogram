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

        private Verk Search(string s, TextBox b)
        {
            foreach (Verk element in Form1.registry)
            {
                if (element.Title.ToUpper() == b.Text.ToUpper())
                {
                    return element;
                }
            }
            return null;
        }

        private void lndCtnBtn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtl1Box.Text, lndTtl1Box) != null)
            {
                lndTtlBoxG.Text = Search(lndTtl1Box.Text, lndTtl1Box).Title;
                lndAuthBoxG.Text = Search(lndTtl1Box.Text, lndTtl1Box).Author;
                lndLendBtn.Enabled = true;
                lndCcl1Btn.Enabled = true;
            }
            else
            {
                lndTtl1Box.Clear();
                Occupied occupied = new Occupied();
                occupied.Show();
            }
        }

        private void lndLendBtn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtlBoxG.Text, lndTtl1Box).Lent == 0)
            {
                Search(lndTtlBoxG.Text, lndTtl1Box).Lent = 1;
                lndTtlBoxG.Clear();
                lndAuthBoxG.Clear();
                lndTtl1Box.Clear();
                lndLendBtn.Enabled = false;
                lndCcl1Btn.Enabled = false;
            }
            else
            {
                Occupied occupied = new Occupied();
                occupied.Show();
            }
        }

        private void lndCcl1Btn_Click(object sender, EventArgs e)
        {
            lndTtlBoxG.Clear();
            lndAuthBoxG.Clear();
            lndTtl1Box.Clear();
            lndLendBtn.Enabled = false;
            lndCcl1Btn.Enabled = false;
        }

        private void lndCtn2Btn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtl2Box.Text, lndTtl2Box) != null)
            {
                lndTtl2BoxG.Text = Search(lndTtl2Box.Text, lndTtl2Box).Title;
                lndAuth2BoxG.Text = Search(lndTtl2Box.Text, lndTtl2Box).Author;
                lndRtnBtn.Enabled = true;
                lndCcl2Btn.Enabled = true;
            }
            else
            {
                lndTtl2Box.Clear();
                Occupied occupied = new Occupied();
                occupied.Show();
            }
        }

        private void lndRtnBtn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtl2Box.Text, lndTtl2Box).Lent == 1)
            {
                Search(lndTtl2BoxG.Text, lndTtl2Box).Lent = 0;
                lndTtl2BoxG.Clear();
                lndAuth2BoxG.Clear();
                lndTtl2Box.Clear();
                lndRtnBtn.Enabled = false;
                lndCcl2Btn.Enabled = false;
            }
            else
            {
                Occupied occupied = new Occupied();
                occupied.Show();
            }
        }

        private void lndCcl2Btn_Click(object sender, EventArgs e)
        {
            lndTtl2BoxG.Clear();
            lndAuth2BoxG.Clear();
            lndTtl2Box.Clear();
            lndRtnBtn.Enabled = false;
            lndCcl2Btn.Enabled = false;
        }
    }
}
