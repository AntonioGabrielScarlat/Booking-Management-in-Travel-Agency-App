
namespace Agentie_de_Turism___Proiect_PAW
{
    partial class FormServiciu
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
            this.comboBoxTipTransport = new System.Windows.Forms.ComboBox();
            this.comboBoxTipCazare = new System.Windows.Forms.ComboBox();
            this.textBoxDestinatie = new System.Windows.Forms.TextBox();
            this.textBoxNrStele = new System.Windows.Forms.TextBox();
            this.textBoxPretPersoanaNoapte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonActualizare = new System.Windows.Forms.Button();
            this.textBoxCodServiciu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderStele = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStele)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipTransport
            // 
            this.comboBoxTipTransport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipTransport.FormattingEnabled = true;
            this.comboBoxTipTransport.Items.AddRange(new object[] {
            "Personal",
            "Autocar",
            "Avion"});
            this.comboBoxTipTransport.Location = new System.Drawing.Point(216, 102);
            this.comboBoxTipTransport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTipTransport.Name = "comboBoxTipTransport";
            this.comboBoxTipTransport.Size = new System.Drawing.Size(211, 27);
            this.comboBoxTipTransport.TabIndex = 0;
            // 
            // comboBoxTipCazare
            // 
            this.comboBoxTipCazare.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipCazare.FormattingEnabled = true;
            this.comboBoxTipCazare.Items.AddRange(new object[] {
            "SelfCatering",
            "BedAndBreakfast",
            "HalfBoard",
            "AllInclusive"});
            this.comboBoxTipCazare.Location = new System.Drawing.Point(216, 166);
            this.comboBoxTipCazare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTipCazare.Name = "comboBoxTipCazare";
            this.comboBoxTipCazare.Size = new System.Drawing.Size(211, 27);
            this.comboBoxTipCazare.TabIndex = 1;
            // 
            // textBoxDestinatie
            // 
            this.textBoxDestinatie.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestinatie.Location = new System.Drawing.Point(216, 230);
            this.textBoxDestinatie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDestinatie.Name = "textBoxDestinatie";
            this.textBoxDestinatie.Size = new System.Drawing.Size(211, 27);
            this.textBoxDestinatie.TabIndex = 2;
            // 
            // textBoxNrStele
            // 
            this.textBoxNrStele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNrStele.Location = new System.Drawing.Point(216, 292);
            this.textBoxNrStele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNrStele.Name = "textBoxNrStele";
            this.textBoxNrStele.Size = new System.Drawing.Size(211, 27);
            this.textBoxNrStele.TabIndex = 3;
            // 
            // textBoxPretPersoanaNoapte
            // 
            this.textBoxPretPersoanaNoapte.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretPersoanaNoapte.Location = new System.Drawing.Point(216, 354);
            this.textBoxPretPersoanaNoapte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPretPersoanaNoapte.Name = "textBoxPretPersoanaNoapte";
            this.textBoxPretPersoanaNoapte.Size = new System.Drawing.Size(211, 27);
            this.textBoxPretPersoanaNoapte.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 106);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tip Transport";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 170);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tip Cazare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 234);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destinatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 302);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nr. Stele";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 360);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pret/Persoana/Noapte";
            // 
            // buttonActualizare
            // 
            this.buttonActualizare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonActualizare.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizare.Location = new System.Drawing.Point(30, 419);
            this.buttonActualizare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonActualizare.Name = "buttonActualizare";
            this.buttonActualizare.Size = new System.Drawing.Size(397, 66);
            this.buttonActualizare.TabIndex = 10;
            this.buttonActualizare.Text = "Actualizeaza";
            this.buttonActualizare.UseVisualStyleBackColor = true;
            this.buttonActualizare.Click += new System.EventHandler(this.buttonActualizare_Click);
            // 
            // textBoxCodServiciu
            // 
            this.textBoxCodServiciu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodServiciu.Location = new System.Drawing.Point(216, 40);
            this.textBoxCodServiciu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCodServiciu.Name = "textBoxCodServiciu";
            this.textBoxCodServiciu.Size = new System.Drawing.Size(211, 27);
            this.textBoxCodServiciu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cod Serviciu";
            // 
            // errorProviderStele
            // 
            this.errorProviderStele.ContainerControl = this;
            // 
            // FormServiciu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(465, 557);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCodServiciu);
            this.Controls.Add(this.buttonActualizare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPretPersoanaNoapte);
            this.Controls.Add(this.textBoxNrStele);
            this.Controls.Add(this.textBoxDestinatie);
            this.Controls.Add(this.comboBoxTipCazare);
            this.Controls.Add(this.comboBoxTipTransport);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormServiciu";
            this.Text = "FormServiciu";
            this.Load += new System.EventHandler(this.FormServiciu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipTransport;
        private System.Windows.Forms.ComboBox comboBoxTipCazare;
        private System.Windows.Forms.TextBox textBoxDestinatie;
        private System.Windows.Forms.TextBox textBoxNrStele;
        private System.Windows.Forms.TextBox textBoxPretPersoanaNoapte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonActualizare;
        private System.Windows.Forms.TextBox textBoxCodServiciu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProviderStele;
    }
}