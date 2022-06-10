
namespace Agentie_de_Turism___Proiect_PAW
{
    partial class FormTurist
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonActualizareTuristi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxprenume = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.errorProviderCNP = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCategorieVarsta = new System.Windows.Forms.Button();
            this.categorieVarstaTuristUserControl1 = new Agentie_de_Turism___Proiect_PAW.CategorieVarstaTuristUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCNP)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox1.Location = new System.Drawing.Point(233, 271);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 23);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Vaccinat";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonActualizareTuristi
            // 
            this.buttonActualizareTuristi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizareTuristi.Location = new System.Drawing.Point(14, 436);
            this.buttonActualizareTuristi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonActualizareTuristi.Name = "buttonActualizareTuristi";
            this.buttonActualizareTuristi.Size = new System.Drawing.Size(267, 72);
            this.buttonActualizareTuristi.TabIndex = 1;
            this.buttonActualizareTuristi.Text = "Actualizeaza";
            this.buttonActualizareTuristi.UseVisualStyleBackColor = true;
            this.buttonActualizareTuristi.Click += new System.EventHandler(this.buttonActualizareTuristi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenume";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(50, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Nasterii";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(50, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "CNP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNume.Location = new System.Drawing.Point(233, 57);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(312, 27);
            this.textBoxNume.TabIndex = 6;
            // 
            // textBoxprenume
            // 
            this.textBoxprenume.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxprenume.Location = new System.Drawing.Point(233, 110);
            this.textBoxprenume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxprenume.Name = "textBoxprenume";
            this.textBoxprenume.Size = new System.Drawing.Size(312, 27);
            this.textBoxprenume.TabIndex = 7;
            // 
            // dateTimePickerDataNasterii
            // 
            this.dateTimePickerDataNasterii.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataNasterii.Location = new System.Drawing.Point(233, 164);
            this.dateTimePickerDataNasterii.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDataNasterii.Name = "dateTimePickerDataNasterii";
            this.dateTimePickerDataNasterii.Size = new System.Drawing.Size(312, 27);
            this.dateTimePickerDataNasterii.TabIndex = 8;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNP.Location = new System.Drawing.Point(233, 217);
            this.textBoxCNP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(312, 27);
            this.textBoxCNP.TabIndex = 9;
            // 
            // errorProviderCNP
            // 
            this.errorProviderCNP.ContainerControl = this;
            // 
            // buttonCategorieVarsta
            // 
            this.buttonCategorieVarsta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategorieVarsta.Location = new System.Drawing.Point(292, 436);
            this.buttonCategorieVarsta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCategorieVarsta.Name = "buttonCategorieVarsta";
            this.buttonCategorieVarsta.Size = new System.Drawing.Size(253, 27);
            this.buttonCategorieVarsta.TabIndex = 11;
            this.buttonCategorieVarsta.Text = "Afiseaza Categoria de Varsta";
            this.buttonCategorieVarsta.UseVisualStyleBackColor = true;
            this.buttonCategorieVarsta.Click += new System.EventHandler(this.buttonCategorieVarsta_Click);
            // 
            // categorieVarstaTuristUserControl1
            // 
            this.categorieVarstaTuristUserControl1.Location = new System.Drawing.Point(54, 305);
            this.categorieVarstaTuristUserControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categorieVarstaTuristUserControl1.Name = "categorieVarstaTuristUserControl1";
            this.categorieVarstaTuristUserControl1.Size = new System.Drawing.Size(381, 77);
            this.categorieVarstaTuristUserControl1.TabIndex = 12;
            // 
            // FormTurist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(628, 534);
            this.Controls.Add(this.categorieVarstaTuristUserControl1);
            this.Controls.Add(this.buttonCategorieVarsta);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.dateTimePickerDataNasterii);
            this.Controls.Add(this.textBoxprenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonActualizareTuristi);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTurist";
            this.Text = "FormTurist";
            this.Load += new System.EventHandler(this.FormTurist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCNP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonActualizareTuristi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxprenume;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasterii;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.ErrorProvider errorProviderCNP;
        private System.Windows.Forms.Button buttonCategorieVarsta;
        private CategorieVarstaTuristUserControl categorieVarstaTuristUserControl1;
    }
}