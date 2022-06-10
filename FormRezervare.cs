using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentie_de_Turism___Proiect_PAW
{
    public partial class FormRezervare : Form
    {
        Rezervare rezervare;
        public FormRezervare(Rezervare rez)
        {
            InitializeComponent();
            rezervare = rez;
            textBoxCodServiciu.Text = rez.ServiciulAles.CodServiciu;
            textBoxTipTransport.Text = Convert.ToString(rez.ServiciulAles.Transport);
            textBoxTipCazare.Text = Convert.ToString(rez.ServiciulAles.Cazare);
            textBoxDestinatie.Text = rez.ServiciulAles.Destinatie;
            textBoxNrStele.Text = Convert.ToString(rez.ServiciulAles.NrStele);
            textBoxPretPerPersoanaPerNoapte.Text = Convert.ToString(rez.ServiciulAles.PretPerPersoanaPerNoapte);
            textBoxNume.Text = rez.TuristCareARezervat.Nume;
            textBoxPrenume.Text = rez.TuristCareARezervat.Prenume;
            textBoxCNP.Text = rez.TuristCareARezervat.CNP;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rezervare.CodRezervare = Convert.ToInt32(textBoxCodRezervare.Text);
            rezervare.NrNopti = Convert.ToInt32(textBoxNrNopti.Text);
            rezervare.NumarTuristi = Convert.ToInt32(textBoxNrTuristi.Text);
            rezervare.PretTotal = rezervare.ServiciulAles.PretPerPersoanaPerNoapte*rezervare.NrNopti*rezervare.NumarTuristi;
            this.DialogResult = DialogResult.OK;
        }

        private void FormRezervare_Load(object sender, EventArgs e)
        {

        }
    }
}
