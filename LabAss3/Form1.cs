using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace LabAss3
{
    public partial class frmCustomerDataEntry : Form
    {
        public frmCustomerDataEntry()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bangladwsh_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status;

            if (radioMale.Checked) Gender = "Male";
            else Gender = "Female";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "Married";
            else Status = "Unmarried";
            try
            {
                CustomerValidation objVal = new CustomerValidation();
                objVal.CheckCustomerName(txtCustomerName.Text);


                frmCustomerPreview objPreview = new frmCustomerPreview();
                objPreview.SetValues(txtCustomerName.Text, comCountry.Text, Gender, Hobby, Status);

                objPreview.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCustomerDataEntry_Load(object sender, EventArgs e)
        {
            loadCustomer();
        }
        private void loadCustomer()
        {
            string strConnection = "Data Source=NHYE;Initial Catalog=CustonerDB;Persist Security Info=True;User ID=sa;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strcommand = "Select + From Customer";
            SqlCommand objCommand = new SqlCommand(strcommand, objConnection);

            DataSet objDataSet = new DataSet();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
            objDataAdapter.Fill(objDataSet);
            dtgCustomer.DataSource = objDataSet.Tables[0];

            objConnection.Close();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status;
            if (radioMale.Checked) Gender = "Male";
            else Gender = "Female";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "1";
            else Status = "0";

            string strConnection = "Data Source=NHYE;Initial Catalog=CustonerDB;Persist Security Info=True;User ID=sa;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            string strcommand = "insert into Customer(Customer,Country,Gender,Hobby,Married) values('" + txtCustomerName + "','" + comCountry.Text + "','" + Gender + "','" + Hobby + "'," + Status + ")";
            SqlCommand objCommand = new SqlCommand(strcommand, objConnection);
            objCommand.ExecuteNonQuery();

            objConnection.Close();
            loadCustomer();

        }


        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearForm();
            string id = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            displayCustomer(id);
        }
        private void displayCustomer(string id)
        {
            string strConnection = "Data Source=NHYE;Initial Catalog=CustonerDB;Persist Security Info=True;User ID=sa;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strcommand = "Select+From Customer where id=" + id;
            SqlCommand objCommand = new SqlCommand(strcommand, objConnection);

            DataSet objDataSet = new DataSet();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
            objDataAdapter.Fill(objDataSet);
            objConnection.Close();
            lblID.Text = objDataSet.Tables[0].Rows[0][0].ToString().Trim();
            txtCustomerName.Text = objDataSet.Tables[0].Rows[0][1].ToString().Trim();
            comCountry.Text = objDataSet.Tables[0].Rows[0][2].ToString().Trim();
            string Gender = objDataSet.Tables[0].Rows[0][3].ToString().Trim();
            if (Gender.Equals("Male")) radioMale.Checked = true;
            else radioFemale.Checked = true;
            string Hobby = objDataSet.Tables[0].Rows[0][4].ToString().Trim();
            if (Hobby.Equals("Reading")) chkReading.Checked = true;
            else chkPainting.Checked = true;
            string Married = objDataSet.Tables[0].Rows[0][5].ToString().Trim();
            if (Married.Equals("Reading")) radioMarried.Checked = true;
            else radioUnmarried.Checked = true;
        }
        private void clearForm()
        {
            txtCustomerName.Text = "";
            comCountry.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
            chkReading.Checked = false;
            chkPainting.Checked = false;
            radioMarried.Checked = false;
            radioUnmarried.Checked = false;
                
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status;
            if (radioMale.Checked) Gender = "Male";
            else Gender = "Female";
            if (chkReading.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioMarried.Checked) Status = "1";
            else Status = "0";


            string strConnection = "Data Source=NHYE;Initial Catalog=CustonerDB;Persist Security Info=True;User ID=sa;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            string strcommand = "UPDATE Customer SET CustomerName =@CustomerName, Country=@Country, " + "Gender=@Gender,Hobby=@Hobby,Married= @Married WHERE id=@id";
            SqlCommand objCommand = new SqlCommand(strcommand, objConnection);
            objCommand.Parameters.AddWithValue("@Customer", txtCustomerName.Text.Trim());
            objCommand.Parameters.AddWithValue("@Country", comCountry.Text.ToString().Trim());
            objCommand.Parameters.AddWithValue("@Gender", Gender);
            objCommand.Parameters.AddWithValue("@Hobby", Hobby);
            objCommand.Parameters.AddWithValue("@Married", Status);
            objCommand.Parameters.AddWithValue("@id", lblID.Text.Trim());
            objCommand.ExecuteNonQuery();

            objConnection.Close();
            clearForm();
            loadCustomer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strConnection = "Data Source=NHYE;Initial Catalog=CustonerDB;Persist Security Info=True;User ID=sa;Pooling=False";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            string strcommand = "Select+From Customer where id='" + lblID.Text+"'";
            SqlCommand objCommand = new SqlCommand(strcommand, objConnection);
            objCommand.ExecuteNonQuery();

            objConnection.Close();
            clearForm();
            loadCustomer();
        }
    }
}
