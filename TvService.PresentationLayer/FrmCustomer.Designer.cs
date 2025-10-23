namespace TvService.PresentationLayer
{
    partial class FrmCustomer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Size = new System.Drawing.Size(600, 250);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(120, 25);
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 65);
            this.txtCity.Size = new System.Drawing.Size(200, 22);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 105);
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 145);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 25);
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(350, 65);
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(350, 105);
            this.btnUpdate.Size = new System.Drawing.Size(120, 30);
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(350, 145);
            this.btnList.Size = new System.Drawing.Size(120, 30);
            this.btnList.Text = "Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.Text = "Ad Soyad:";
            this.lblFullName.Location = new System.Drawing.Point(30, 25);
            // 
            // lblCity
            // 
            this.lblCity.Text = "Şehir:";
            this.lblCity.Location = new System.Drawing.Point(30, 65);
            // 
            // lblPhone
            // 
            this.lblPhone.Text = "Telefon:";
            this.lblPhone.Location = new System.Drawing.Point(30, 105);
            // 
            // lblEmail
            // 
            this.lblEmail.Text = "E-Posta:";
            this.lblEmail.Location = new System.Drawing.Point(30, 145);
            // 
            // FrmCustomer
            // 
            this.ClientSize = new System.Drawing.Size(630, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Text = "Müşteri Yönetimi";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
    }
}
