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
                regRegBox.Text += work.Title + " " + work.Author + " " + work.Lent.ToString() + "\r\n";
            }
        }
    }
}
