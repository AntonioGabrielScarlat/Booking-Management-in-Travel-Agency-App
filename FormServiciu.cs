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
    public partial class FormServiciu : Form
    {
        public Serviciu serviciu;
        public Form1 parinte;
        public FormServiciu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void ActualizeazaControale(object sender, EventArgs e)
        {
            ListView listamea = (ListView)sender;
            if (listamea.SelectedItems.Count > 0)
                serviciu = (Serviciu)listamea.SelectedItems[0].Tag;
            if (serviciu != null)
            {
                textBoxCodServiciu.Text = serviciu.CodServiciu;
                comboBoxTipTransport.Text = serviciu.Transport.ToString();
                comboBoxTipCazare.Text = serviciu.Cazare.ToString();
                textBoxDestinatie.Text = serviciu.Destinatie;
                textBoxNrStele.Text = serviciu.NrStele.ToString();
                textBoxPretPersoanaNoapte.Text = serviciu.PretPerPersoanaPerNoapte.ToString();
            }
        }
        private void buttonActualizare_Click(object sender, EventArgs e)
        {
            bool eroare = false;
            if (Convert.ToInt32(textBoxNrStele.Text)>5)
            {
                eroare = true;
                errorProviderStele.SetError(textBoxNrStele, "Nr. de stele invalid");
            }
            else
            {
                errorProviderStele.SetError(textBoxNrStele, "Nr. de stele invalid");
            }
            if (!eroare)
            {
                if (serviciu != null)
                {
                    serviciu.CodServiciu = textBoxCodServiciu.Text;
                    serviciu.Transport = (TipTransport)Enum.Parse(typeof(TipTransport), comboBoxTipTransport.Text);
                    serviciu.Cazare = (TipCazare)Enum.Parse(typeof(TipCazare), comboBoxTipCazare.Text);
                    serviciu.Destinatie = textBoxDestinatie.Text;
                    serviciu.NrStele = Convert.ToInt32(textBoxNrStele.Text);
                    serviciu.PretPerPersoanaPerNoapte = Convert.ToDouble(textBoxPretPersoanaNoapte.Text);
                }
                parinte.UpdateItemsServicii();
                this.DialogResult = DialogResult.OK;
            }

        }

        private void FormServiciu_Load(object sender, EventArgs e)
        {

        }
    }
}
