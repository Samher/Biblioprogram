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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Verk> registry = new List<Verk>();

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            register.Show();
        }

        private void lendBtn_Click(object sender, EventArgs e)
        {
            lendForm lend = new lendForm();
            lend.Show();
        }
    }
}
