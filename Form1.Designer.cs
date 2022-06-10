
namespace Agentie_de_Turism___Proiect_PAW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderCodServiciu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipTransport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipCazare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDestinatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNrStele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaServiciuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeServiciuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaServiciuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviciiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaServiciuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeServiciuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaServiciuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turistiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaTuristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeTuristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaTuristToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartPretMediuTipCazareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asigurariDeCalatorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAsigurareDeCalatorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaInFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaDinFisierBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateCuTuristiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acceseazaBazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataNasterii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVaccinat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaTuristToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeTuristToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaTuristToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.Color.Turquoise;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodServiciu,
            this.columnHeaderTipTransport,
            this.columnHeaderTipCazare,
            this.columnHeaderDestinatie,
            this.columnHeaderNrStele,
            this.columnHeaderPret});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 105);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(640, 324);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnReordered += new System.Windows.Forms.ColumnReorderedEventHandler(this.listView1_ColumnReordered);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            // 
            // columnHeaderCodServiciu
            // 
            this.columnHeaderCodServiciu.Text = "Cod";
            this.columnHeaderCodServiciu.Width = 118;
            // 
            // columnHeaderTipTransport
            // 
            this.columnHeaderTipTransport.Text = "Transport";
            this.columnHeaderTipTransport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTipTransport.Width = 117;
            // 
            // columnHeaderTipCazare
            // 
            this.columnHeaderTipCazare.Text = "Cazare";
            this.columnHeaderTipCazare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTipCazare.Width = 100;
            // 
            // columnHeaderDestinatie
            // 
            this.columnHeaderDestinatie.Text = "Destinatie";
            this.columnHeaderDestinatie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDestinatie.Width = 135;
            // 
            // columnHeaderNrStele
            // 
            this.columnHeaderNrStele.Text = "Nr. Stele";
            this.columnHeaderNrStele.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderNrStele.Width = 96;
            // 
            // columnHeaderPret
            // 
            this.columnHeaderPret.Text = "Pret";
            this.columnHeaderPret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPret.Width = 90;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaServiciuToolStripMenuItem1,
            this.stergeServiciuToolStripMenuItem1,
            this.modificaServiciuToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugaServiciuToolStripMenuItem1
            // 
            this.adaugaServiciuToolStripMenuItem1.Name = "adaugaServiciuToolStripMenuItem1";
            this.adaugaServiciuToolStripMenuItem1.Size = new System.Drawing.Size(192, 24);
            this.adaugaServiciuToolStripMenuItem1.Text = "Adauga Serviciu";
            this.adaugaServiciuToolStripMenuItem1.Click += new System.EventHandler(this.adaugaServiciuToolStripMenuItem1_Click);
            // 
            // stergeServiciuToolStripMenuItem1
            // 
            this.stergeServiciuToolStripMenuItem1.Name = "stergeServiciuToolStripMenuItem1";
            this.stergeServiciuToolStripMenuItem1.Size = new System.Drawing.Size(192, 24);
            this.stergeServiciuToolStripMenuItem1.Text = "Sterge Serviciu";
            this.stergeServiciuToolStripMenuItem1.Click += new System.EventHandler(this.stergeServiciuToolStripMenuItem1_Click);
            // 
            // modificaServiciuToolStripMenuItem1
            // 
            this.modificaServiciuToolStripMenuItem1.Name = "modificaServiciuToolStripMenuItem1";
            this.modificaServiciuToolStripMenuItem1.Size = new System.Drawing.Size(192, 24);
            this.modificaServiciuToolStripMenuItem1.Text = "Modifica Serviciu";
            this.modificaServiciuToolStripMenuItem1.Click += new System.EventHandler(this.modificaServiciuToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciiToolStripMenuItem,
            this.turistiToolStripMenuItem,
            this.graficToolStripMenuItem,
            this.asigurariDeCalatorieToolStripMenuItem,
            this.fisiereToolStripMenuItem,
            this.bazaDeDateCuTuristiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1259, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviciiToolStripMenuItem
            // 
            this.serviciiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaServiciuToolStripMenuItem,
            this.stergeServiciuToolStripMenuItem,
            this.modificaServiciuToolStripMenuItem});
            this.serviciiToolStripMenuItem.Name = "serviciiToolStripMenuItem";
            this.serviciiToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.serviciiToolStripMenuItem.Text = "Servicii";
            // 
            // adaugaServiciuToolStripMenuItem
            // 
            this.adaugaServiciuToolStripMenuItem.Name = "adaugaServiciuToolStripMenuItem";
            this.adaugaServiciuToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.adaugaServiciuToolStripMenuItem.Text = "Adauga Serviciu";
            this.adaugaServiciuToolStripMenuItem.Click += new System.EventHandler(this.adaugaServiciuToolStripMenuItem_Click);
            // 
            // stergeServiciuToolStripMenuItem
            // 
            this.stergeServiciuToolStripMenuItem.Name = "stergeServiciuToolStripMenuItem";
            this.stergeServiciuToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.stergeServiciuToolStripMenuItem.Text = "Sterge Serviciu";
            this.stergeServiciuToolStripMenuItem.Click += new System.EventHandler(this.stergeServiciuToolStripMenuItem_Click);
            // 
            // modificaServiciuToolStripMenuItem
            // 
            this.modificaServiciuToolStripMenuItem.Name = "modificaServiciuToolStripMenuItem";
            this.modificaServiciuToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.modificaServiciuToolStripMenuItem.Text = "Modifica Serviciu";
            this.modificaServiciuToolStripMenuItem.Click += new System.EventHandler(this.modificaServiciuToolStripMenuItem_Click);
            // 
            // turistiToolStripMenuItem
            // 
            this.turistiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaTuristToolStripMenuItem,
            this.stergeTuristToolStripMenuItem,
            this.modificaTuristToolStripMenuItem});
            this.turistiToolStripMenuItem.Name = "turistiToolStripMenuItem";
            this.turistiToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.turistiToolStripMenuItem.Text = "Turisti";
            // 
            // adaugaTuristToolStripMenuItem
            // 
            this.adaugaTuristToolStripMenuItem.Name = "adaugaTuristToolStripMenuItem";
            this.adaugaTuristToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.adaugaTuristToolStripMenuItem.Text = "Adauga Turist";
            this.adaugaTuristToolStripMenuItem.Click += new System.EventHandler(this.adaugaTuristToolStripMenuItem_Click);
            // 
            // stergeTuristToolStripMenuItem
            // 
            this.stergeTuristToolStripMenuItem.Name = "stergeTuristToolStripMenuItem";
            this.stergeTuristToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.stergeTuristToolStripMenuItem.Text = "Sterge Turist";
            this.stergeTuristToolStripMenuItem.Click += new System.EventHandler(this.stergeTuristToolStripMenuItem_Click);
            // 
            // modificaTuristToolStripMenuItem
            // 
            this.modificaTuristToolStripMenuItem.Name = "modificaTuristToolStripMenuItem";
            this.modificaTuristToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.modificaTuristToolStripMenuItem.Text = "Modifica Turist";
            this.modificaTuristToolStripMenuItem.Click += new System.EventHandler(this.modificaTuristToolStripMenuItem_Click);
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideChartToolStripMenuItem,
            this.chartPretMediuTipCazareToolStripMenuItem});
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.graficToolStripMenuItem.Text = "Charts";
            // 
            // deschideChartToolStripMenuItem
            // 
            this.deschideChartToolStripMenuItem.Name = "deschideChartToolStripMenuItem";
            this.deschideChartToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.deschideChartToolStripMenuItem.Text = "Chart - Rezervari / Destinatie";
            this.deschideChartToolStripMenuItem.Click += new System.EventHandler(this.deschideChartToolStripMenuItem_Click);
            // 
            // chartPretMediuTipCazareToolStripMenuItem
            // 
            this.chartPretMediuTipCazareToolStripMenuItem.Name = "chartPretMediuTipCazareToolStripMenuItem";
            this.chartPretMediuTipCazareToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.chartPretMediuTipCazareToolStripMenuItem.Text = "Chart - Pret Mediu / Tip Cazare";
            this.chartPretMediuTipCazareToolStripMenuItem.Click += new System.EventHandler(this.chartPretMediuTipCazareToolStripMenuItem_Click);
            // 
            // asigurariDeCalatorieToolStripMenuItem
            // 
            this.asigurariDeCalatorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printAsigurareDeCalatorieToolStripMenuItem});
            this.asigurariDeCalatorieToolStripMenuItem.Name = "asigurariDeCalatorieToolStripMenuItem";
            this.asigurariDeCalatorieToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.asigurariDeCalatorieToolStripMenuItem.Text = "Print - Asigurari de Calatorie";
            this.asigurariDeCalatorieToolStripMenuItem.Click += new System.EventHandler(this.asigurariDeCalatorieToolStripMenuItem_Click);
            // 
            // printAsigurareDeCalatorieToolStripMenuItem
            // 
            this.printAsigurareDeCalatorieToolStripMenuItem.Name = "printAsigurareDeCalatorieToolStripMenuItem";
            this.printAsigurareDeCalatorieToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.printAsigurareDeCalatorieToolStripMenuItem.Text = "Print Asigurare de Calatorie";
            this.printAsigurareDeCalatorieToolStripMenuItem.Click += new System.EventHandler(this.printAsigurareDeCalatorieToolStripMenuItem_Click);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveInFileToolStripMenuItem,
            this.salveazaInFisierBinarToolStripMenuItem,
            this.restaureazaDinFisierBinarToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.openFileToolStripMenuItem.Text = "Salveaza Turisti in Fisier Text";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveInFileToolStripMenuItem
            // 
            this.saveInFileToolStripMenuItem.Name = "saveInFileToolStripMenuItem";
            this.saveInFileToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.saveInFileToolStripMenuItem.Text = "Restaureaza Turisti din Fisier Text";
            this.saveInFileToolStripMenuItem.Click += new System.EventHandler(this.saveInFileToolStripMenuItem_Click);
            // 
            // salveazaInFisierBinarToolStripMenuItem
            // 
            this.salveazaInFisierBinarToolStripMenuItem.Name = "salveazaInFisierBinarToolStripMenuItem";
            this.salveazaInFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.salveazaInFisierBinarToolStripMenuItem.Text = "Salveaza Servicii in Fisier Binar";
            this.salveazaInFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.salveazaInFisierBinarToolStripMenuItem_Click);
            // 
            // restaureazaDinFisierBinarToolStripMenuItem
            // 
            this.restaureazaDinFisierBinarToolStripMenuItem.Name = "restaureazaDinFisierBinarToolStripMenuItem";
            this.restaureazaDinFisierBinarToolStripMenuItem.Size = new System.Drawing.Size(324, 26);
            this.restaureazaDinFisierBinarToolStripMenuItem.Text = "Restaureaza Servicii din Fisier Binar";
            this.restaureazaDinFisierBinarToolStripMenuItem.Click += new System.EventHandler(this.restaureazaDinFisierBinarToolStripMenuItem_Click);
            // 
            // bazaDeDateCuTuristiToolStripMenuItem
            // 
            this.bazaDeDateCuTuristiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceseazaBazaDeDateToolStripMenuItem});
            this.bazaDeDateCuTuristiToolStripMenuItem.Name = "bazaDeDateCuTuristiToolStripMenuItem";
            this.bazaDeDateCuTuristiToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.bazaDeDateCuTuristiToolStripMenuItem.Text = "Baza de date cu Turisti";
            // 
            // acceseazaBazaDeDateToolStripMenuItem
            // 
            this.acceseazaBazaDeDateToolStripMenuItem.Name = "acceseazaBazaDeDateToolStripMenuItem";
            this.acceseazaBazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.acceseazaBazaDeDateToolStripMenuItem.Text = "Acceseaza Baza de Date";
            this.acceseazaBazaDeDateToolStripMenuItem.Click += new System.EventHandler(this.acceseazaBazaDeDateToolStripMenuItem_Click);
            // 
            // listView2
            // 
            this.listView2.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView2.AllowColumnReorder = true;
            this.listView2.AutoArrange = false;
            this.listView2.BackColor = System.Drawing.Color.Turquoise;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderDataNasterii,
            this.columnHeaderCNP,
            this.columnHeaderVaccinat});
            this.listView2.ContextMenuStrip = this.contextMenuStrip2;
            this.listView2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(705, 105);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(528, 324);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView2_KeyUp);
            this.listView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDown);
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 92;
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "Prenume";
            this.columnHeaderPrenume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPrenume.Width = 112;
            // 
            // columnHeaderDataNasterii
            // 
            this.columnHeaderDataNasterii.Text = "Data Nasterii";
            this.columnHeaderDataNasterii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDataNasterii.Width = 120;
            // 
            // columnHeaderCNP
            // 
            this.columnHeaderCNP.Text = "CNP";
            this.columnHeaderCNP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCNP.Width = 100;
            // 
            // columnHeaderVaccinat
            // 
            this.columnHeaderVaccinat.Text = "Vaccinat";
            this.columnHeaderVaccinat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderVaccinat.Width = 70;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaTuristToolStripMenuItem1,
            this.stergeTuristToolStripMenuItem1,
            this.modificaTuristToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(178, 76);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // adaugaTuristToolStripMenuItem1
            // 
            this.adaugaTuristToolStripMenuItem1.Name = "adaugaTuristToolStripMenuItem1";
            this.adaugaTuristToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.adaugaTuristToolStripMenuItem1.Text = "Adauga Turist";
            this.adaugaTuristToolStripMenuItem1.Click += new System.EventHandler(this.adaugaTuristToolStripMenuItem1_Click);
            // 
            // stergeTuristToolStripMenuItem1
            // 
            this.stergeTuristToolStripMenuItem1.Name = "stergeTuristToolStripMenuItem1";
            this.stergeTuristToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.stergeTuristToolStripMenuItem1.Text = "Sterge Turist";
            this.stergeTuristToolStripMenuItem1.Click += new System.EventHandler(this.stergeTuristToolStripMenuItem1_Click);
            // 
            // modificaTuristToolStripMenuItem1
            // 
            this.modificaTuristToolStripMenuItem1.Name = "modificaTuristToolStripMenuItem1";
            this.modificaTuristToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.modificaTuristToolStripMenuItem1.Text = "Modifica Turist";
            this.modificaTuristToolStripMenuItem1.Click += new System.EventHandler(this.modificaTuristToolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(36, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 38);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "SERVICII";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(705, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 38);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "TURISTI";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Turquoise;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(36, 492);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(1197, 127);
            this.treeView1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(36, 447);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 38);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "REZERVARI";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 632);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Agentie de Turism";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTipTransport;
        private System.Windows.Forms.ColumnHeader columnHeaderTipCazare;
        private System.Windows.Forms.ColumnHeader columnHeaderDestinatie;
        private System.Windows.Forms.ColumnHeader columnHeaderNrStele;
        private System.Windows.Forms.ColumnHeader columnHeaderPret;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviciiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaServiciuToolStripMenuItem;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderDataNasterii;
        private System.Windows.Forms.ColumnHeader columnHeaderCNP;
        private System.Windows.Forms.ColumnHeader columnHeaderVaccinat;
        private System.Windows.Forms.ToolStripMenuItem turistiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaTuristToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ColumnHeader columnHeaderCodServiciu;
        private System.Windows.Forms.ToolStripMenuItem stergeTuristToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaTuristToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeServiciuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaServiciuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaServiciuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeServiciuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaServiciuToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adaugaTuristToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeTuristToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaTuristToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartPretMediuTipCazareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asigurariDeCalatorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAsigurareDeCalatorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaInFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaureazaDinFisierBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateCuTuristiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acceseazaBazaDeDateToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
    }
}

