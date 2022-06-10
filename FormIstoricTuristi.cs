using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agentie_de_Turism___Proiect_PAW
{
    public partial class FormIstoricTuristi : Form
    {

        string stringConexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB-1053;Integrated Security=True";

        DataSet DSTuristi = new DataSet();

        string SelectCommand = "Select * from dbo.Turisti";
        public FormIstoricTuristi()
        {
            InitializeComponent();
            IncarcaDate();
        }

        private void FormIstoricTuristi_Load(object sender, EventArgs e)
        {
            this.turistiTableAdapter.Fill(this.dataSetTuristi.Turisti);

        }
        void IncarcaDate()
        {
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(SelectCommand, conexiune);
            adaptor.Fill(DSTuristi, "Turisti");
            DSTuristi.Tables["Turisti"].PrimaryKey = new DataColumn[1]
            {DSTuristi.Tables["Turisti"].Columns["ID"] };
            conexiune.Close();

            //legatura databinding cu combobox

            comboBox1.DataSource = DSTuristi.Tables["Turisti"];
            comboBox1.DisplayMember = "CNP";
            comboBox1.ValueMember = "ID";

            textBoxNume.DataBindings.Add("Text", DSTuristi.Tables["Turisti"], "Nume");
            textBoxPrenume.DataBindings.Add("Text", DSTuristi.Tables["Turisti"], "Prenume");
            dateTimePickerDataNasterii.DataBindings.Add("Value", DSTuristi.Tables["Turisti"], "DataNasterii");
            textBoxCNP.DataBindings.Add("Text", DSTuristi.Tables["Turisti"], "CNP");
            checkBoxVaccinat.DataBindings.Add("Text", DSTuristi.Tables["Turisti"], "Vaccinat");
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.turistiBindingSource.EndEdit();
                this.turistiTableAdapter.Update(this.dataSetTuristi.Turisti);
                MessageBox.Show("Salvare cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            BindingManagerBase legatura = BindingContext[DSTuristi.Tables["Turisti"]];
            legatura.EndCurrentEdit();

            string UpdateCommand = "update dbo.Turisti set Nume=@Nume,Prenume=@Prenume,"
                + "DataNasterii=@DataNasterii, CNP=@CNP, Vaccinat=@Vaccinat " +
                " where ID=@ID";

            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(SelectCommand, conexiune);
            adaptor.UpdateCommand = conexiune.CreateCommand();
            adaptor.UpdateCommand.CommandText = UpdateCommand;
            adaptor.UpdateCommand.Parameters.AddWithValue("@Nume", textBoxNume.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Prenume", textBoxPrenume.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@DataNasterii", dateTimePickerDataNasterii.Value);
            adaptor.UpdateCommand.Parameters.AddWithValue("@CNP", textBoxCNP.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Vaccinat", checkBoxVaccinat.Text);
            int ID = Int32.Parse(comboBox1.SelectedValue.ToString());

            adaptor.UpdateCommand.Parameters.AddWithValue("@ID", ID);

            DataSet DSTuristiModificari = DSTuristi.GetChanges(DataRowState.Modified);

            if (DSTuristiModificari != null)
            {
                int i = adaptor.Update(DSTuristiModificari, "Turisti");
                MessageBox.Show("Au fost actualizate " + i + " linii");
                DSTuristi.Tables["Turisti"].AcceptChanges();

            }

            conexiune.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
