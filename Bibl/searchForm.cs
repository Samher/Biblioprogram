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
                        srhLstBox.Items.Add(work.Title + " | " + work.Author + " | Utlånad\r\n");
                    else
                        srhLstBox.Items.Add(work.Title + " | " + work.Author + " | Ej Utlånad\r\n");
                }
            }
        }
        private void srhBox_dblClick()
        {
            
        }
    }
}
