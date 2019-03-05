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

        private void AddWork()
        {
            Form1.registry.Add(new Verk(regTtlBox.Text, regAuthBox.Text, 0));
            regAuthBox.Clear();
            regTtlBox.Clear();
            RegUpdate(Form1.registry);
        }

        private void regInsertBtn_Click(object sender, EventArgs e)
        {
            foreach (Verk work in Form1.registry)
            {
                if (work.Title.ToUpper() == regTtlBox.Text.ToUpper())
                {
                    Occupied occupied = new Occupied();
                    occupied.Show();
                    return;
                }
                else
                {
                    AddWork();
                }
            }
            if (Form1.registry.Count < 1)
                AddWork();
        }

        private void RegUpdate(List<Verk> reg)
        {
            regRegBox.Clear();
            foreach (Verk work in Form1.registry)
            {
                if (work.Lent == 1)
                    regRegBox.Text += work.Title + " | " + work.Author + " | Utlånad\r\n";
                else
                    regRegBox.Text += work.Title + " | " + work.Author + " | Ej utlånad\r\n";
            }
        }

        private void regRemoveBBtn_Click(object sender, EventArgs e)
        {
            for (int i = Form1.registry.Count; i > 0; i--)
            {
                if (regTtlBox.Text.ToUpper() == Form1.registry[i - 1].Title.ToUpper())
                {
                    Form1.registry.RemoveAt(i - 1);
                    RegUpdate(Form1.registry);
                }
            }
        }

        private void regRemoveABtn_Click(object sender, EventArgs e)
        {
            for (int i = Form1.registry.Count; i > 0; i--)
            {
                if (regAuthBox.Text.ToUpper() == Form1.registry[i - 1].Author.ToUpper())
                {
                    Form1.registry.RemoveAt(i - 1);
                    RegUpdate(Form1.registry);
                }
            }
        }

    }
}
