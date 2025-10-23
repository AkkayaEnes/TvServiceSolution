using System;
using System.Windows.Forms;
using TvService.BusinessLayer.Concrete;
using TvService.DataAccessLayer.EntityFramework;
using TvService.EntityLayer.Concrete;

namespace TvService.PresentationLayer
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void LoadCustomerList()
        {
            dataGridView1.DataSource = customerManager.TGetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer c = new Customer
            {
                FullName = btnAdd.Text,
                City = txtCity.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text
            };
            customerManager.TInsert(c);
            MessageBox.Show("Müşteri eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCustomerList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CustomerID"].Value);
                var customer = customerManager.TGetById(id);
                customerManager.TDelete(customer);
                MessageBox.Show("Müşteri silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadCustomerList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CustomerID"].Value);
                var customer = customerManager.TGetById(id);
                customer.FullName = btnAdd.Text;
                customer.City = txtCity.Text;
                customer.Phone = txtPhone.Text;
                customer.Email = txtEmail.Text;
                customerManager.TUpdate(customer);
                MessageBox.Show("Müşteri bilgisi güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerList();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                btnAdd.Text = dataGridView1.CurrentRow.Cells["FullName"].Value.ToString();
                txtCity.Text = dataGridView1.CurrentRow.Cells["City"].Value.ToString();
                txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            }
        }
    }
}
