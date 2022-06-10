using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentie_de_Turism___Proiect_PAW
{
    [Serializable]
    public enum TipTransport
    {
        Personal,
        Autocar,
        Avion
    }
    public enum TipCazare
    {
        SelfCatering,
        BedAndBreakfast,
        HalfBoard,
        AllInclusive
    }
    public class Serviciu
    {
        public string CodServiciu;
        public TipTransport Transport;
        public TipCazare Cazare;
        public string Destinatie;
        public int NrStele;
        public double PretPerPersoanaPerNoapte;

        public Serviciu(string cod, TipTransport transport,TipCazare cazare, string destinatie,int nr, double pret)
        {
            CodServiciu = cod;
            Transport = transport;
            Cazare = cazare;
            Destinatie = destinatie;
            NrStele = nr;
            PretPerPersoanaPerNoapte = pret;
        }
    }
}
