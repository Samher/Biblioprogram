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
        List<Verk> registry;
        public lendForm(List<Verk> registryParam)
        {
            InitializeComponent();
            registry = registryParam;
        }

        private void lndCtnBtn_Click(object sender, EventArgs e)
        {
            foreach (Verk element in registry)
            {
                if (element.Title.ToUpper() == lndCtnBtn.Text.ToUpper())
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
