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
            RegUpdate();
        }

        //Denna funktion lägger till ett verk i registret och tömmer inmatningstexten
        private void AddWork()
        {
            Form1.registry.Add(new Verk(regTtlBox.Text, regAuthBox.Text, 0));
            regAuthBox.Clear();
            regTtlBox.Clear();
            RegUpdate();
        }

        /*Denna funktion aktiverar föregående funktion förutsatt att verket inte redan finns i registret.
        Annars visas error-fönstret*/
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
            }
            AddWork();
        }

        /*Här uppdateras registret som visas i fönstret. Den skriver ut alla data som lagras i ett verk.
        Den körs varje gång registret ändras*/
        private void RegUpdate()
        {
            regLstBox.Items.Clear();
            foreach (Verk work in Form1.registry)
            {
                if (work.Lent == 1)
                    regLstBox.Items.Add(work.Title + "|" + work.Author + "|Utlånad");
                else
                    regLstBox.Items.Add(work.Title + "|" + work.Author + "|Ej utlånad");
            }
        }

        /*Denna funktion tar bort verket som är markerat i register-boxen vid knapptrycket genom att dela 
        upp verket som en sträng och jämföra titeln med verken i registerlistan*/
        private void regRemoveBBtn_Click(object sender, EventArgs e)
        {
            string s = regLstBox.SelectedItem.ToString();
            string[] mrkdString = s.Split('|');
            for (int i = Form1.registry.Count; i > 0; i--)
            {
                if (Form1.registry[i - 1].Title == mrkdString[0])
                {
                    Form1.registry.Remove(Form1.registry[i - 1]);
                }
            }
            RegUpdate();
        }

        //Här utförs i princip samma sak som i föregående funktion men den jämför författare istället
        private void regRemoveABtn_Click(object sender, EventArgs e)
        {
            string s = regLstBox.SelectedItem.ToString();
            string[] mrkdString = s.Split('|');
            for (int i = Form1.registry.Count; i > 0; i--)
            {
                if (Form1.registry[i - 1].Author == mrkdString[1])
                {
                    Form1.registry.Remove(Form1.registry[i - 1]);
                }
            }
            RegUpdate();
        }
    }
}
