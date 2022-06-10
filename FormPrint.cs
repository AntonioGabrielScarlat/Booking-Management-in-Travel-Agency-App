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
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBoxAsigurareDeCalatorie.Text,new Font("Times New Roman",14,FontStyle.Bold),
                Brushes.Black,new PointF(100,100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAsigurareDeCalatorie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
