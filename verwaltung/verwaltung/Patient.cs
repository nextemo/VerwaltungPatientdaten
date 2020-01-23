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
        //private DateTime geburtsDatum;
        //private int alter;
        //private string geschlecht;

        public Patient(string vorname, string name)
        {
            this.vorname = vorname;
            this.name = name;
        }
    }
}
