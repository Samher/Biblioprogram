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

        /*När funktionen nedan aktiveras av sökknappen töms sökresultatsfältet och programmet börjar söka
        på det nya angivna sökordet. Det gör detta genom att jämföra både titel och författare med det
        användaren skrev in i sökfältet*/
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

        /*Om man dubbelklickar på sökresultatsfältet aktiveras denna funktion som tar användaren till
        låneformuläret. Den skickar med titeln på det markerade objektet i listboxen till en funktion 
        i låneformuläret och stänger sedan sökformen*/
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
