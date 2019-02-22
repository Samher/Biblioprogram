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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            RegUpdate(Form1.registry);
        }

        private void regInsertBtn_Click(object sender, EventArgs e)
        {
            Form1.registry.Add(new Verk(regTtlBox.Text, regAuthBox.Text, 0));
            regAuthBox.Clear();
            regTtlBox.Clear();
            RegUpdate(Form1.registry);
        }

        private void RegUpdate(List<Verk> reg)
        {
            regRegBox.Clear();
            foreach (Verk work in Form1.registry)
            {
                regRegBox.Text += work.Title + " " + work.Author + " " + work.Lent.ToString() + "\r\n";
            }
        }
    }
}
