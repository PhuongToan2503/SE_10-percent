using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppDemo
{
    public partial class FormMain : Form
    {
	// Sửa Connection String ở đây
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-D737E79;Initial Catalog=SE_Ticket_Vendor_Machine;Integrated Security=True");
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            connect.Open();
            textBoxPrice.Text = "Vui lòng chọn phương tiện và địa điểm để hiển thị giá vé ❤";
            radioButtonCredit.Checked = true;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (comboBoxVehicles.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phương tiện !");
                comboBoxVehicles.Focus();
            }
            else if (comboBoxDestinations.Text == "")
            {
                MessageBox.Show("Vui lòng chọn điểm đến !");
                comboBoxDestinations.Focus();
            }
            double price = -1;
            bool isAPrice = double.TryParse(textBoxPrice.Text, out price);
            if (price > 0)
            {
                if (radioButtonQR.Checked == true)
                {
                    FormQR formQR = new FormQR();
                    formQR.ShowDialog();
                }
                else if (radioButtonCredit.Checked == true)
                {
                    FormCreditCard formCreditCard = new FormCreditCard();
                    formCreditCard.ShowDialog();
                }
            }

        }

        private void comboBoxVehicles_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT price FROM Ticket WHERE vehicle = N'{0}' AND destination = N'{1}'"
                    , comboBoxVehicles.Text, comboBoxDestinations.Text);
            SqlCommand cm = new SqlCommand(sql, connect);
            var price = cm.ExecuteScalar();

            textBoxPrice.Text = price == null ? "Chọn địa điểm muốn đến": price.ToString();
            if (comboBoxVehicles.SelectedIndex < 0)
            {
                textBoxPrice.Text = "Phương tiện chọn không có sẵn hoặc không hợp lệ !";
            }
         
        }

        private void comboBoxDestinations_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT price FROM Ticket WHERE vehicle = N'{0}' AND destination = N'{1}'"
                    , comboBoxVehicles.Text, comboBoxDestinations.Text);
            SqlCommand cm = new SqlCommand(sql, connect);
            var price = cm.ExecuteScalar();

            textBoxPrice.Text = price == null ? "Chọn phương tiện mà bạn muốn đi" : price.ToString();
            if (comboBoxDestinations.SelectedIndex < 0)
            {
                textBoxPrice.Text = "Không tìm thấy điểm đến hoặc điểm đến không hợp lệ !";
            }
   
        }
    }
}
