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
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        private void srhSearchBtn_Click(object sender, EventArgs e)
        {
            srhLstBox.Items.Clear();
            foreach (Verk work in Form1.registry)
            {
                if (work.Author.ToUpper().Contains(srhBox.Text.ToUpper()) || 
                    work.Title.ToUpper().Contains(srhBox.Text.ToUpper()))
                {
                    if (work.Lent == 1)
                        srhLstBox.Items.Add(work.Title + "|" + work.Author + "|Utlånad");
                    else
                        srhLstBox.Items.Add(work.Title + "|" + work.Author + "|Ej Utlånad");
                }
            }
        }

        /* Metoden gör så att när ett element i listboxen dubbel-
         * klickas på, körs AutoFill-funktionen från lendForm. */
        private void srhLstBox_DoubleClick(object sender, EventArgs e)
        {
            lendForm lndfrm = new lendForm();
            lndfrm.Show();
            string s = srhLstBox.SelectedItem.ToString();
            string[] mrkdString = s.Split('|');
            lndfrm.AutoFill(mrkdString[0]);
            this.Close();
        }
    }
}
