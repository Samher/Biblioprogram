﻿using System;
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
        List<Verk> registry;
        public registerForm(List<Verk> registryParam)
        {
            registry = registryParam;
            InitializeComponent();
            RegUpdate(registry);
        }

        private void regInsertBtn_Click(object sender, EventArgs e)
        {
            registry.Add(new Verk(regTtlBox.Text, regAuthBox.Text, 0));
            regAuthBox.Clear();
            regTtlBox.Clear();
            RegUpdate(registry);
        }

        private void RegUpdate(List<Verk> reg)
        {
            regRegBox.Clear();
            foreach (Verk work in registry)
            {
                if (work.Lent == 1)
                    regRegBox.Text += work.Title + " | " + work.Author + " | Utlånad\r\n";
                else
                    regRegBox.Text += work.Title + " | " + work.Author + " | Ej utlånad\r\n";
            }
        }

        private void regRemoveBBtn_Click(object sender, EventArgs e)
        {
            for (int i = registry.Count; i > 0; i--)
            {
                if (regTtlBox.Text.ToUpper() == registry[i - 1].Title.ToUpper())
                {
                    registry.RemoveAt(i - 1);
                    RegUpdate(registry);
                }
            }
        }

        private void regRemoveABtn_Click(object sender, EventArgs e)
        {
            for (int i = registry.Count; i > 0; i--)
            {
                if (regAuthBox.Text.ToUpper() == registry[i - 1].Author.ToUpper())
                {
                    registry.RemoveAt(i - 1);
                    RegUpdate(registry);
                }
            }
        }

    }
}
