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
    public partial class FormGrafic2 : Form
    {
        public FormGrafic2()
        {
            InitializeComponent();
            chartPreturi.Series["Preturi (€)"].IsValueShownAsLabel = true;
            chartPreturi.Series["Preturi (€)"].Points.AddXY("Self Catering",25.8);
            chartPreturi.Series["Preturi (€)"].Points.AddXY("Bed And Breakfast", 37.5);
            chartPreturi.Series["Preturi (€)"].Points.AddXY("Half Board", 49.3);
            chartPreturi.Series["Preturi (€)"].Points.AddXY("All Inclusive", 82.2);
            chartPreturi.Series["Preturi (€)"].Points.AddXY("Ultra All Inclusive", 102.7);
        }

        private void FormGrafic2_Load(object sender, EventArgs e)
        {

        }
    }
}
