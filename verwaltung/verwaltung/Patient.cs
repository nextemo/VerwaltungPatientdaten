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
        private int telNum;
        private string email;
        private string krankheit;

        public Patient(string vorname, string name, DateTime gebDatum, string geschlecht, string email, int nummer, string krankheit)
        {
            this.vorname = vorname;
            this.name = name;
            this.geburtsDatum = gebDatum;
            this.geschlecht = geschlecht;
            int yearNow = DateTime.Now.Year;
            alter = yearNow - gebDatum.Year;
            this.email = email;
            this.telNum = nummer;
            this.krankheit = krankheit;
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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Nummer
        {
            get { return telNum; }
            set { telNum = value; }
        }

        public string Krankheit
        {
            get { return krankheit; }
            set { krankheit = value; }
        }
    }
}
