using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibl
{
    public class Verk
    {
        private string title, author;
        private int lent;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Lent
        {
            get { return lent; }
            set { lent = value; }
        }

        public Verk(string t, string a, int l)
        {
            Title = t;
            Author = a;
            Lent = l;
        }
    }
}
