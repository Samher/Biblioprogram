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

        /* Metoden tar en titel och returnerar ett verk 
         * med den titeln från registret om det finns. */
        private Verk Search(string s) 
        {
            foreach (Verk element in Form1.registry)
            {
                if (element.Title.ToUpper() == s.ToUpper())
                {
                    return element;
                }
            }
            return null;
        }

        // Metoden fyller i de grå rutorna på låna-sidan av fönstret med relevant information om verket. 
        private void lndCtnBtn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtl1Box.Text) != null)
            {
                lndTtlBoxG.Text = Search(lndTtl1Box.Text).Title;
                lndAuthBoxG.Text = Search(lndTtl1Box.Text).Author;
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

        /* När knappen klickas rensas alla textrutor på låna-sidan, 
         * och verkets "lent"-egenskap sätts till 1 (lånad). */
        private void lndLendBtn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtlBoxG.Text).Lent == 0)
            {
                Search(lndTtlBoxG.Text).Lent = 1;
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

        // När knappen trycks rensar metoden informationen på låna-sidan. 
        private void lndCcl1Btn_Click(object sender, EventArgs e)
        {
            lndTtlBoxG.Clear();
            lndAuthBoxG.Clear();
            lndTtl1Box.Clear();
            lndLendBtn.Enabled = false;
            lndCcl1Btn.Enabled = false;
        }

        // Metoden fyller i de grå rutorna på lämna-sidan av fönstret med relevant information om verket. 
        private void lndCtn2Btn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtl2Box.Text) != null)
            {
                lndTtl2BoxG.Text = Search(lndTtl2Box.Text).Title;
                lndAuth2BoxG.Text = Search(lndTtl2Box.Text).Author;
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

        /* När knappen klickas rensas alla textrutor på låna-sidan, 
         * och verkets "lent"-egenskap sätts till 0 (ej lånad). */
        private void lndRtnBtn_Click(object sender, EventArgs e)
        {
            if (Search(lndTtl2Box.Text).Lent == 1)
            {
                Search(lndTtl2BoxG.Text).Lent = 0;
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

        // När knappen trycks rensar metoden informationen på lämna-sidan. 
        private void lndCcl2Btn_Click(object sender, EventArgs e)
        {
            lndTtl2BoxG.Clear();
            lndAuth2BoxG.Clear();
            lndTtl2Box.Clear();
            lndRtnBtn.Enabled = false;
            lndCcl2Btn.Enabled = false;
        }

        /* Följande metod körs när man dubbelklickar på ett verk i sökfönstret. 
         * Beroende på om verket är lånat eller inte 
         * fyller den i relevant information i rätt text-rutor. */
        public void AutoFill(string title) 
        {
            if (Search(title).Lent == 1)
            {
                lndTtl2Box.Text = title;
                lndCtn2Btn.PerformClick();
            }
            else if (Search(title).Lent == 0)
            {
                lndTtl1Box.Text = title;
                lndCtnBtn.PerformClick();
            }
        }
    }
}
