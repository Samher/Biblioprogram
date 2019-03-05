using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            searchForm search = new searchForm();
            search.Show();
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

        private void importBtn_Click(Object sender, EventArgs e)
        {
            StreamReader rfile = new StreamReader("registry.txt");
            string s, tempTtl, tempAuth;
            int tempLent;
            while ((s = rfile.ReadLine()) != null)
            {
                string[] readdata = s.Split(',');
                tempTtl = readdata[0];
                tempAuth = readdata[1];
                tempLent = int.Parse(readdata[2]);
                registry.Add(new Verk(tempTtl, tempAuth, tempLent));
            }
            rfile.Close();
        }

        private void Exiting(object sender, FormClosingEventArgs e)
        {
            StreamWriter wfile = new StreamWriter("registry.txt");
            foreach (Verk element in registry)
                wfile.WriteLine(element.Title + "," + element.Author + "," + element.Lent);
            wfile.Close();
        }
    }
}