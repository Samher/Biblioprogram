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
            foreach (Verk work in Form1.registry)
            {
                if ((work.Author.ToUpper().Contains(srhBox.Text.ToUpper()) || 
                    work.Title.ToUpper().Contains(srhBox.Text.ToUpper())) && 
                    !srhResBox.Text.Contains(work.Title))
                {
                    if (work.Lent == 1)
                        srhResBox.Text += work.Title + " | " + work.Author + " | Utlånad\r\n";
                    else
                        srhResBox.Text += work.Title + " | " + work.Author + " | Ej utlånad\r\n";
                }
            }
        }
    }
}
