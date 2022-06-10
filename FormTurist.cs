using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agentie_de_Turism___Proiect_PAW
{
    public partial class FormTurist : Form
    {
        public Turist turist;
        public Form1 parinte;
        public FormTurist()
        {
            InitializeComponent();
        }

        public void ActualizeazaControale(object sender, EventArgs e)
        {
            ListView listamea = (ListView)sender;
            if (listamea.SelectedItems.Count > 0)
                turist = (Turist)listamea.SelectedItems[0].Tag;
            if (turist != null)
            {
                textBoxNume.Text = turist.Nume;
                textBoxprenume.Text = turist.Prenume;
                dateTimePickerDataNasterii.Value = turist.DataNasterii;
                textBoxCNP.Text = turist.CNP;
                checkBox1.Checked = turist.Vaccinat;
            }
        }
        private void buttonActualizareTuristi_Click(object sender, EventArgs e)
        {
            bool eroare = false;
            if (textBoxCNP.Text.Length != 13)
            {
                eroare = true;
                errorProviderCNP.SetError(textBoxCNP, "CNP invalid");
            }
            else
            {
                errorProviderCNP.SetError(textBoxCNP, "CNP invalid");
            }
            if (!eroare)
            {
                if (turist != null)
                {
                    turist.Nume = textBoxNume.Text;
                    turist.Prenume = textBoxprenume.Text;
                    turist.DataNasterii = dateTimePickerDataNasterii.Value;
                    turist.CNP = textBoxCNP.Text;
                    turist.Vaccinat = checkBox1.Checked;
                }
                parinte.UpdateItemsTuristi();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FormTurist_Load(object sender, EventArgs e)
        {

        }

        private void buttonCategorieVarsta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Turistul {0} {1} are sub {2} ani, deci este {3}!", textBoxNume.Text, textBoxprenume.Text,
                categorieVarstaTuristUserControl1.SelectedCategorie.limita_sup, categorieVarstaTuristUserControl1.SelectedCategorie.Denumire));
        }
    }
}
