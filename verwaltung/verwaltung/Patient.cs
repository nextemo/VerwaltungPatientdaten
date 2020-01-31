using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verwaltung
{
    class Patient
    {
        private string vorname;
        private string name;
        private DateTime geburtsDatum;
        private int alter;
        private string geschlecht;
        //private int telNum;
        //private string email;

        public Patient(string vorname, string name, DateTime gebDatum, string geschlecht)
        {
            this.vorname = vorname;
            this.name = name;
            this.geburtsDatum = gebDatum;
            this.geschlecht = geschlecht;
            int yearNow = DateTime.Now.Year;
            alter = yearNow - gebDatum.Year;
        }

        public string Vorname{
            get { return vorname; }
            set { vorname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Geburtsdatum
        {
            get { return geburtsDatum; }
            set { geburtsDatum = value; }
        }

        public int Alter
        {
            get { return alter; }
            set { alter = value; }
        }

        public string Geschlecht
        {
            get { return geschlecht; }
            set { geschlecht = value; }
        }
    }
}
