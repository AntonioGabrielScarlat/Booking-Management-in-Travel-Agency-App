using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentie_de_Turism___Proiect_PAW
{
    public partial class Form1 : Form
    {
        private DialogResult rezultat;
        public Form1()
        {
            InitializeComponent();
            Serviciu s1 = new Serviciu("A1", TipTransport.Autocar, TipCazare.HalfBoard, "Instanbul", 4, 45.25);
            Serviciu s2 = new Serviciu("B2", TipTransport.Avion, TipCazare.BedAndBreakfast, "Paris", 3, 58.75);
            Serviciu s3 = new Serviciu("C3", TipTransport.Personal, TipCazare.AllInclusive, "Nessebar", 5, 100.5);
            Serviciu s4 = new Serviciu("D4",TipTransport.Avion,TipCazare.AllInclusive,"Antalya",5,102.8);
            Serviciu s5 = new Serviciu("E5",TipTransport.Autocar,TipCazare.BedAndBreakfast,"Sighisoara",3,30.2);
            ListViewItem lvi1 = new ListViewItem(s1.CodServiciu);
            lvi1.SubItems.Add(s1.Transport.ToString());
            lvi1.SubItems.Add(s1.Cazare.ToString());
            lvi1.SubItems.Add(s1.Destinatie);
            lvi1.SubItems.Add(s1.NrStele.ToString());
            lvi1.SubItems.Add(s1.PretPerPersoanaPerNoapte.ToString());
            lvi1.UseItemStyleForSubItems = false;
            lvi1.Tag = s1;
            listView1.Items.Add(lvi1);

            ListViewItem lvi2 = new ListViewItem(s2.CodServiciu);
            lvi2.SubItems.Add(s2.Transport.ToString());
            lvi2.SubItems.Add(s2.Cazare.ToString());
            lvi2.SubItems.Add(s2.Destinatie);
            lvi2.SubItems.Add(s2.NrStele.ToString());
            lvi2.SubItems.Add(s2.PretPerPersoanaPerNoapte.ToString());
            lvi2.UseItemStyleForSubItems = false;
            lvi2.Tag = s2;
            listView1.Items.Add(lvi2);

            ListViewItem lvi3 = new ListViewItem(s3.CodServiciu);
            lvi3.SubItems.Add(s3.Transport.ToString());
            lvi3.SubItems.Add(s3.Cazare.ToString());
            lvi3.SubItems.Add(s3.Destinatie);
            lvi3.SubItems.Add(s3.NrStele.ToString());
            lvi3.SubItems.Add(s3.PretPerPersoanaPerNoapte.ToString());
            lvi3.UseItemStyleForSubItems = false;
            lvi3.Tag = s3;
            listView1.Items.Add(lvi3);

            ListViewItem lvi4 = new ListViewItem(s4.CodServiciu);
            lvi4.SubItems.Add(s4.Transport.ToString());
            lvi4.SubItems.Add(s4.Cazare.ToString());
            lvi4.SubItems.Add(s4.Destinatie);
            lvi4.SubItems.Add(s4.NrStele.ToString());
            lvi4.SubItems.Add(s4.PretPerPersoanaPerNoapte.ToString());
            lvi4.UseItemStyleForSubItems = false;
            lvi4.Tag = s4;
            listView1.Items.Add(lvi4);

            ListViewItem lvi5 = new ListViewItem(s5.CodServiciu);
            lvi5.SubItems.Add(s5.Transport.ToString());
            lvi5.SubItems.Add(s5.Cazare.ToString());
            lvi5.SubItems.Add(s5.Destinatie);
            lvi5.SubItems.Add(s5.NrStele.ToString());
            lvi5.SubItems.Add(s5.PretPerPersoanaPerNoapte.ToString());
            lvi5.UseItemStyleForSubItems = false;
            lvi5.Tag = s5;
            listView1.Items.Add(lvi5);

            Turist t1 = new Turist("Scarlat", "Antonio", new DateTime(2000, 03, 28, 11, 35, 30), "5000328030013", true);
            Turist t2 = new Turist("Ivan", "Cristian", new DateTime(2000, 12, 27, 05, 45, 50), "5000348391932", true);
            Turist t3 = new Turist("Marinache", "Ruxandra", new DateTime(2000, 03, 05, 10, 50, 50), "6000234245324", false);
            Turist t4 = new Turist("Iancu","Maria",new DateTime(2003,09,10,06,03,40),"6000343545472",true);
            Turist t5 = new Turist("Zimbru", "Robert", new DateTime(1995, 05, 06, 08, 23, 25), "5000343452472", true);
            ListViewItem lvit1 = new ListViewItem(t1.Nume);
            lvit1.SubItems.Add(t1.Prenume);
            lvit1.SubItems.Add(t1.DataNasterii.ToString());
            lvit1.SubItems.Add(t1.CNP);
            lvit1.SubItems.Add(t1.Vaccinat.ToString());
            lvit1.Tag = t1;
            listView2.Items.Add(lvit1);

            ListViewItem lvit2 = new ListViewItem(t2.Nume);
            lvit2.SubItems.Add(t2.Prenume);
            lvit2.SubItems.Add(t2.DataNasterii.ToString());
            lvit2.SubItems.Add(t2.CNP);
            lvit2.SubItems.Add(t2.Vaccinat.ToString());
            lvit2.Tag = t2;
            listView2.Items.Add(lvit2);

            ListViewItem lvit3 = new ListViewItem(t3.Nume);
            lvit3.SubItems.Add(t3.Prenume);
            lvit3.SubItems.Add(t3.DataNasterii.ToString());
            lvit3.SubItems.Add(t3.CNP);
            lvit3.SubItems.Add(t3.Vaccinat.ToString());
            lvit3.Tag = t3;
            listView2.Items.Add(lvit3);

            ListViewItem lvit4 = new ListViewItem(t4.Nume);
            lvit4.SubItems.Add(t4.Prenume);
            lvit4.SubItems.Add(t4.DataNasterii.ToString());
            lvit4.SubItems.Add(t4.CNP);
            lvit4.SubItems.Add(t4.Vaccinat.ToString());
            lvit4.Tag = t4;
            listView2.Items.Add(lvit4);

            ListViewItem lvit5 = new ListViewItem(t5.Nume);
            lvit5.SubItems.Add(t5.Prenume);
            lvit5.SubItems.Add(t5.DataNasterii.ToString());
            lvit5.SubItems.Add(t5.CNP);
            lvit5.SubItems.Add(t5.Vaccinat.ToString());
            lvit5.Tag = t5;
            listView2.Items.Add(lvit5);

            TreeNode tree1 = treeView1.Nodes.Add("Serviciu: " + s1.CodServiciu + " - Destinatia: " + s1.Destinatie + " - Tip de transport: " + s1.Transport.ToString() +
                " - Tip de cazare: " + s1.Cazare.ToString() + " - Numar de Stele ale Hotelului: " + s1.NrStele + "* - Pret/Persoana/Noapte: " + s1.PretPerPersoanaPerNoapte + "€");
            tree1.Tag = s1;
            TreeNode tree2 = treeView1.Nodes.Add("Serviciu: " + s2.CodServiciu + " - Destinatia: " + s2.Destinatie + " - Tip de transport: " + s2.Transport.ToString() +
                " - Tip de cazare: " + s2.Cazare.ToString() + " - Numar de Stele ale Hotelului: " + s2.NrStele + "* - Pret/Persoana/Noapte: " + s2.PretPerPersoanaPerNoapte + "€");
            tree2.Tag = s2;
            TreeNode tree3 = treeView1.Nodes.Add("Serviciu: " + s3.CodServiciu + " - Destinatia: " + s3.Destinatie + " - Tip de transport: " + s3.Transport.ToString() +
                " - Tip de cazare: " + s3.Cazare.ToString() + " - Numar de Stele ale Hotelului: " + s3.NrStele + "* - Pret/Persoana/Noapte: " + s3.PretPerPersoanaPerNoapte + "€");
            tree3.Tag = s3;
            TreeNode tree4 = treeView1.Nodes.Add("Serviciu: " + s4.CodServiciu + " - Destinatia: " + s4.Destinatie + " - Tip de transport: " + s4.Transport.ToString() +
                " - Tip de cazare: " + s4.Cazare.ToString() + " - Numar de Stele ale Hotelului: " + s4.NrStele + "* - Pret/Persoana/Noapte: " + s4.PretPerPersoanaPerNoapte + "€");
            tree4.Tag = s4;
            TreeNode tree5 = treeView1.Nodes.Add("Serviciu: " + s5.CodServiciu + " - Destinatia: " + s5.Destinatie + " - Tip de transport: " + s5.Transport.ToString() +
                " - Tip de cazare: " + s5.Cazare.ToString() + " - Numar de Stele ale Hotelului: " + s5.NrStele + "* - Pret/Persoana/Noapte: " + s5.PretPerPersoanaPerNoapte + "€");
            tree5.Tag = s5;
        }
        public void UpdateItemsServicii()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                Serviciu s = (Serviciu)lvi.Tag;
                lvi.Text = s.CodServiciu;
                lvi.SubItems[1].Text = Convert.ToString(s.Transport);
                lvi.SubItems[2].Text = Convert.ToString(s.Cazare);
                lvi.SubItems[3].Text = s.Destinatie;
                lvi.SubItems[4].Text = Convert.ToString(s.NrStele);
                lvi.SubItems[5].Text = Convert.ToString(s.PretPerPersoanaPerNoapte);

            }
        }
        public void UpdateItemsTuristi()
        {
            foreach (ListViewItem lvi in listView2.Items)
            {
                Turist t = (Turist)lvi.Tag;
                lvi.Text = t.Nume;
                lvi.SubItems[1].Text = t.Prenume;
                lvi.SubItems[2].Text = Convert.ToString(t.DataNasterii);
                lvi.SubItems[3].Text = t.CNP;
                lvi.SubItems[4].Text = Convert.ToString(t.Vaccinat);

            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void adaugaServiciuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "", "", "" });
            listView1.Items.Add(lvi);
            Serviciu s = new Serviciu("", TipTransport.Personal, TipCazare.SelfCatering, "", 0, 0);
            lvi.Tag = s;

            FormServiciu fs = new FormServiciu();
            fs.serviciu = s;
            fs.parinte = this;
            fs.Text = "Adaugare Serviciu";
            fs.ShowDialog();
            if (fs.DialogResult != DialogResult.OK) lvi.Remove();
        }

        private void adaugaTuristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "", "" });
            listView2.Items.Add(lvi);
            Turist t = new Turist("", "", DateTime.Now, "", false);
            lvi.Tag = t;

            FormTurist ft = new FormTurist();
            ft.turist = t;
            ft.parinte = this;
            ft.Text = "Adaugare Turist";
            ft.ShowDialog();
            if (ft.DialogResult != DialogResult.OK) lvi.Remove();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
                listView2.DoDragDrop(listView2.SelectedItems[0], DragDropEffects.Copy);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }
        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            Turist t = (Turist)((ListViewItem)e.Data.GetData(typeof(ListViewItem))).Tag;
            Point px = listView1.PointToClient(new Point(e.X, e.Y));
            ListViewItem lv = listView1.GetItemAt(px.X, px.Y);
            if (lv != null)
            {
                Serviciu s = (Serviciu)lv.Tag;
                Rezervare rez = new Rezervare(s, t);
                FormRezervare fr = new FormRezervare(rez);
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    List<TreeNode> listanoduri = treeView1.Nodes.Cast<TreeNode>().ToList();
                    TreeNode nodserviciu = listanoduri.Find(x => ((Serviciu)x.Tag).CodServiciu == s.CodServiciu);
                    TreeNode trezervare = nodserviciu.Nodes.Add("Nr. Rezervare: " + rez.CodRezervare + " - Turistul care a rezervat: " +
                        rez.TuristCareARezervat.Nume + " " + rez.TuristCareARezervat.Prenume + " - CNP: " + rez.TuristCareARezervat.CNP + " - Nr. Nopti: " + rez.NrNopti + " - Nr.Turisti: " + rez.NumarTuristi
                        + " - PRET TOTAL SEJUR: " + rez.PretTotal + "€");
                    trezervare.Tag = rez;
                }
            }
        }

        private void listView1_ColumnReordered(object sender, ColumnReorderedEventArgs e)
        {

        }

        private void stergeTuristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                Turist t = (Turist)listView2.SelectedItems[0].Tag;

                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea turistului " + t.Nume + " " + t.Prenume + "?", "Confirmare stergere!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rezultat == DialogResult.Yes) listView2.SelectedItems[0].Remove();
            }
        }

        private void modificaTuristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                FormTurist ft = new FormTurist();
                listView2.SelectedIndexChanged += new EventHandler(ft.ActualizeazaControale);
                ft.ActualizeazaControale(listView2, e);
                ft.parinte = this;
                ft.Text = "Modificare date turist";
                ft.ShowDialog();
            }
        }

        private void stergeServiciuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Serviciu s = (Serviciu)listView1.SelectedItems[0].Tag;

                DialogResult rezultat = MessageBox.Show("Sunteti sigur ca doriti stergerea serviciului cu codul " + s.CodServiciu + "?", "Confirmare stergere!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rezultat == DialogResult.Yes) listView1.SelectedItems[0].Remove();
            }
        }

        private void modificaServiciuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                FormServiciu fs = new FormServiciu();
                listView1.SelectedIndexChanged += new EventHandler(fs.ActualizeazaControale);
                fs.ActualizeazaControale(listView1, e);
                fs.parinte = this;
                fs.Text = "Modificare date serviciu";
                fs.ShowDialog();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                stergeServiciuToolStripMenuItem1.Enabled = true;
                modificaServiciuToolStripMenuItem1.Enabled = true;
            }
            else
            {
                stergeServiciuToolStripMenuItem1.Enabled = false;
                modificaServiciuToolStripMenuItem1.Enabled = false;
            }
        }
        private void adaugaServiciuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugaServiciuToolStripMenuItem_Click(sender, e);
        }
        private void stergeServiciuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stergeServiciuToolStripMenuItem_Click(sender, e);
        }

        private void modificaServiciuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modificaServiciuToolStripMenuItem_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                stergeTuristToolStripMenuItem1.Enabled = true;
                modificaTuristToolStripMenuItem1.Enabled = true;
            }
            else
            {
                stergeTuristToolStripMenuItem1.Enabled = false;
                modificaTuristToolStripMenuItem1.Enabled = false;
            }
        }

        private void adaugaTuristToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugaTuristToolStripMenuItem_Click(sender, e);
        }

        private void stergeTuristToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stergeTuristToolStripMenuItem_Click(sender, e);
        }

        private void modificaTuristToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modificaTuristToolStripMenuItem_Click(sender, e);
        }

        private void listView2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listView2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                adaugaServiciuToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.S)
            {
                stergeServiciuToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.M)
            {
                modificaServiciuToolStripMenuItem_Click(sender, e);
            }
        }
        private void listView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                adaugaTuristToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.S)
            {
                stergeTuristToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.M)
            {
                modificaTuristToolStripMenuItem_Click(sender, e);
            }
        }

        private void deschideChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafic fr = new FormGrafic();
            fr.ShowDialog();
        }

        private void chartPretMediuTipCazareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafic2 fr = new FormGrafic2();
            fr.ShowDialog();
        }

        private void printAsigurareDeCalatorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrint fp = new FormPrint();
            fp.ShowDialog();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "(*.txt)|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(fd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                List<Turist> lista = listView2.Items.Cast<ListViewItem>()
                                   .Select(item => (Turist)item.Tag)
                                   .ToList();
                foreach (Turist t in lista)
                {
                    sw.WriteLine(t.Nume);
                    sw.WriteLine(t.Prenume);
                    sw.WriteLine(t.DataNasterii.ToString());
                    sw.WriteLine(t.CNP);
                    sw.WriteLine(t.Vaccinat.ToString());
                }
                sw.Close();
                fs.Close();
                listView2.Items.Clear();
            }
        }

        private void saveInFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] fileLines = File.ReadAllLines(@"D:\turisti.txt");

            for (int i = 0; i + 4 < fileLines.Length; i += 5)
            {
                listView2.Items.Add(
                    new ListViewItem(new[]
                    {
                fileLines[i],
                fileLines[i + 1],
                fileLines[i + 2],
                fileLines[i + 3],
                fileLines[i + 4]
                    }));
            }
        }

        private void salveazaInFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.CheckPathExists = true;
            fd.Filter = "(*.serviciu)|*.serviciu";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.Create(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                ListViewItem[] items = new ListViewItem[listView1.Items.Count];
                listView1.Items.CopyTo(items, 0);
                serializator.Serialize(fs, items);
                fs.Close();
            }
            listView1.Items.Clear();
        }

        private void restaureazaDinFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckPathExists = true;
            fd.CheckFileExists = true;
            fd.Filter = "(*.serviciu)|*.serviciu";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenRead(fd.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();
                ListViewItem[] items = null;
                items = (ListViewItem[])deserializator.Deserialize(fs);
                listView1.Items.AddRange(items);
                fs.Close();
            }
        }

        private void asigurariDeCalatorieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void acceseazaBazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIstoricTuristi fit = new FormIstoricTuristi();
            fit.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
