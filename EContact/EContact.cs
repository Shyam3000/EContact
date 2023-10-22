using EContact.EContactClasses;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EContact
{
    public partial class EContact : Form
    {
        public EContact()
        {
            InitializeComponent();
        }
        //        ContactClass c = new ContactClass();
        readonly ContactClass c = new();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.ContactNumber = textBoxContactNumber.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = cmbGender.Text;

            //Inserting data into database using the method we created in ContactClass

            bool success = c.Insert(c);
            if (success == true)
            {
                //Successfully Data Inserted
                MessageBox.Show("New Contact Added Successfully");
                Clear();
            }
            else
            {
                // Failed to add the data in database
                MessageBox.Show("Failed Please try Again");
            }
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }


        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PCBClose_Click(object sender, EventArgs e)
        {
            //this help to close the bar  
            this.Close();

        }
        public void Clear()
        {
            textBoxAddress.Text = "";
            textBoxContactID.Text = "";
            textBoxContactNumber.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            cmbGender.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.ContactID = int.Parse(textBoxContactID.Text);
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.Gender = cmbGender.Text;
            c.ContactNumber = textBoxContactNumber.Text;
            c.Address = textBoxAddress.Text;

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Contact Updated Successfully");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Something Went Wrong Please try again");
            }

        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data  from grid view and load it to the textboxes
            int rowIndex = e.RowIndex;
            textBoxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxContactNumber.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.ContactID = Convert.ToInt32(textBoxContactID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Contact Deleted Successffully");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Deleted the Data");
            }

        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR  Address LIKE '%" + keyword + "%' OR ContactNumber LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}