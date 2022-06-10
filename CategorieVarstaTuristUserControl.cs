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
    public partial class CategorieVarstaTuristUserControl : UserControl
    {
        public CategorieVarstaTuristUserControl()
        {
            InitializeComponent();
        }
        public CategoriiVarsta SelectedCategorie
        {
            get
                {
                return (CategoriiVarsta)comboBox1.SelectedItem;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategorieVarstaTuristUserControl_Load(object sender, EventArgs e)
        {
            List < CategoriiVarsta > lista= new List<CategoriiVarsta>();
            lista.Add(new CategoriiVarsta() { limita_sup = 14, Denumire = "Copil" });
            lista.Add(new CategoriiVarsta() { limita_sup = 18, Denumire = "Minor" });
            lista.Add(new CategoriiVarsta() { limita_sup = 65, Denumire = "Adult" });
            lista.Add(new CategoriiVarsta() { limita_sup = 100, Denumire = "Batran" });
            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "Denumire";
            comboBox1.ValueMember = "limita_sup";
        }
    }
}
