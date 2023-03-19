
namespace AppDemo
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVehicles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDestinations = new System.Windows.Forms.ComboBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCredit = new System.Windows.Forms.RadioButton();
            this.radioButtonQR = new System.Windows.Forms.RadioButton();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.comboBoxDestinations);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.comboBoxVehicles);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Location = new System.Drawing.Point(5, 6);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(375, 117);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicles";
            // 
            // comboBoxVehicles
            // 
            this.comboBoxVehicles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxVehicles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxVehicles.FormattingEnabled = true;
            this.comboBoxVehicles.Items.AddRange(new object[] {
            "Xe buýt điện",
            "Xe buýt",
            "Xe lửa"});
            this.comboBoxVehicles.Location = new System.Drawing.Point(7, 32);
            this.comboBoxVehicles.Name = "comboBoxVehicles";
            this.comboBoxVehicles.Size = new System.Drawing.Size(360, 21);
            this.comboBoxVehicles.TabIndex = 1;
            this.comboBoxVehicles.TextChanged += new System.EventHandler(this.comboBoxVehicles_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination";
            // 
            // comboBoxDestinations
            // 
            this.comboBoxDestinations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDestinations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDestinations.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Hà Nội",
            "Bình Dương"});
            this.comboBoxDestinations.Location = new System.Drawing.Point(7, 72);
            this.comboBoxDestinations.Name = "comboBoxDestinations";
            this.comboBoxDestinations.Size = new System.Drawing.Size(360, 21);
            this.comboBoxDestinations.TabIndex = 3;
            this.comboBoxDestinations.TextChanged += new System.EventHandler(this.comboBoxDestinations_TextChanged);
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.textBoxCurrency);
            this.groupBoxInfo.Controls.Add(this.textBoxPrice);
            this.groupBoxInfo.Controls.Add(this.label3);
            this.groupBoxInfo.Location = new System.Drawing.Point(5, 130);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(374, 63);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Information\'s Ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(35, 23);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(295, 20);
            this.textBoxPrice.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQR);
            this.groupBox1.Controls.Add(this.radioButtonCredit);
            this.groupBox1.Location = new System.Drawing.Point(5, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode of Payment";
            // 
            // radioButtonCredit
            // 
            this.radioButtonCredit.AutoSize = true;
            this.radioButtonCredit.Location = new System.Drawing.Point(10, 19);
            this.radioButtonCredit.Name = "radioButtonCredit";
            this.radioButtonCredit.Size = new System.Drawing.Size(110, 17);
            this.radioButtonCredit.TabIndex = 0;
            this.radioButtonCredit.TabStop = true;
            this.radioButtonCredit.Text = "Pay by credit card";
            this.radioButtonCredit.UseVisualStyleBackColor = true;
            // 
            // radioButtonQR
            // 
            this.radioButtonQR.AutoSize = true;
            this.radioButtonQR.Location = new System.Drawing.Point(10, 42);
            this.radioButtonQR.Name = "radioButtonQR";
            this.radioButtonQR.Size = new System.Drawing.Size(144, 17);
            this.radioButtonQR.TabIndex = 1;
            this.radioButtonQR.TabStop = true;
            this.radioButtonQR.Text = "Pay by e-wallet/QR code";
            this.radioButtonQR.UseVisualStyleBackColor = true;
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPay.Location = new System.Drawing.Point(5, 281);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(373, 70);
            this.buttonPay.TabIndex = 2;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Enabled = false;
            this.textBoxCurrency.Location = new System.Drawing.Point(336, 23);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.ReadOnly = true;
            this.textBoxCurrency.Size = new System.Drawing.Size(32, 20);
            this.textBoxCurrency.TabIndex = 2;
            this.textBoxCurrency.Text = "VNĐ";
            this.textBoxCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Vendor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.ComboBox comboBoxDestinations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVehicles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonQR;
        private System.Windows.Forms.RadioButton radioButtonCredit;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBoxCurrency;
    }
}

