using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentie_de_Turism___Proiect_PAW
{
    [Serializable]
    public class Turist
    {
        public string Nume;
        public string Prenume;
        public DateTime DataNasterii;
        public string CNP;
        public bool Vaccinat;

        public Turist(string _nume, string _prenume, DateTime _datan, string _cnp, bool _vaccinat)
        {
            Nume = _nume;
            Prenume = _prenume;
            DataNasterii = _datan;
            CNP = _cnp;
            Vaccinat = _vaccinat;
        }
    }
}
