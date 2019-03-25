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
        FormCollection fs = Application.OpenForms;
        public Form1()
        {
            InitializeComponent();
        }

        // Denna lista innehåller alla verk registret, lagrat som "Verk"-objekt.
        public static List<Verk> registry = new List<Verk>(); 

        // Följande tre metoder öppnar motsvarande fönster när deras knapp trycks på.
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

        // Denna metod importerar registret sparat i en textfil förra gången programmet stängdes ned.
        private void importBtn_Click(object sender, EventArgs e)
        {
            registry.Clear();
            StreamReader rfile = new StreamReader("registry.txt");
            string s, tempTtl, tempAuth;
            int tempLent;
            while ((s = rfile.ReadLine()) != null)
            {
                string[] readdata = s.Split('§');
                tempTtl = readdata[0];
                tempAuth = readdata[1];
                tempLent = int.Parse(readdata[2]);
                registry.Add(new Verk(tempTtl, tempAuth, tempLent));
            }
            rfile.Close();
        }

        /* Detta händer när programmet stängs ned. 
         * Hela registret dumpas i en textfil, 
         * så att den kan importeras nästa gång programmet körs. */
        private void Exiting(object sender, FormClosingEventArgs e)
        {
            StreamWriter wfile = new StreamWriter("registry.txt");
            foreach (Verk element in registry)
                wfile.WriteLine(element.Title + "§" + element.Author + "§" + element.Lent);
            wfile.Close();
        }
    }
}
 