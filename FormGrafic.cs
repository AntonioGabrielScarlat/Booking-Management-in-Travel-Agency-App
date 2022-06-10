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
    public partial class FormGrafic : Form
    {
        public FormGrafic()
        {
            InitializeComponent();
            chartDestinatii.Series["Destinatii"].IsValueShownAsLabel = true;
            chartDestinatii.Series["Destinatii"].Points.AddXY("Barcelona",256);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Nessebar", 133);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Roma", 344);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Istanbul", 199);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Paris", 477);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Berlin", 156);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Moscova", 79);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Stockholm", 102);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Atena", 219);
            chartDestinatii.Series["Destinatii"].Points.AddXY("Praga", 299);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void FormGrafic_Load(object sender, EventArgs e)
        {

        }
    }
}
