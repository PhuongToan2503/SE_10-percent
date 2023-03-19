using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDemo
{
    public partial class FormCreditCard : Form
    {
        public FormCreditCard()
        {
            InitializeComponent();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (textBoxCardNumber.Text == "" && textBoxCCV.Text == "" && textBoxExp.Text == "" && textBoxNameOnCard.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thẻ tín dụng");
            }
            else
            {
                MessageBox.Show("Mua vé thành công!");
                this.Close();
            }
        }
    }
}
