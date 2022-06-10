using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentie_de_Turism___Proiect_PAW
{
    [Serializable]
    public class Rezervare
    {
        public int CodRezervare;
        public Serviciu ServiciulAles;
        public int NrNopti;
        public int NumarTuristi;
        public double PretTotal;
        public Turist TuristCareARezervat;
        public Rezervare(int cod, Serviciu serviciu,int nrnopti,int nrturisti, Turist turist)
        {
            CodRezervare = cod;
            ServiciulAles = serviciu;
            NrNopti = nrnopti;
            NumarTuristi = nrturisti;
            PretTotal = serviciu.PretPerPersoanaPerNoapte * nrnopti * nrturisti;
            TuristCareARezervat = turist;
        }
        public Rezervare(Serviciu serviciu, Turist turist)
        {
            ServiciulAles = serviciu;
            TuristCareARezervat = turist;
        }
    }
}
