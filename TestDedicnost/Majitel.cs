using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    internal class Majitel
    {
        private string jmeno;
        private string prijmeni;
        private Auto auto;

        public Majitel(string jmeno, string prijmeni, Auto auto)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.auto = auto;
        }

        public string Jmeno { 
            get { return this.jmeno; }
            set { this.jmeno = value; }
        }
        public string Prijmeni
        {
            get { return this.prijmeni; }
            set { this.prijmeni = value; }
        }
        public string Auto
        {
            get { return this.Auto; }
            set { this.Auto = value; }
        }

        public override string ToString()
        {
            return "Majitel "+this.jmeno+" "+this.prijmeni+" má "+this.auto;
        }
    }
}
