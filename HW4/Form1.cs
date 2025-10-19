using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCardRegistration
{
    public partial class Form1 : Form
    {
        string imagePath = "";
        private string mobilePlaceholder = "xxxx-xxx-xxxx";

        public Form1()
        {
            InitializeComponent();
            btnSubmit.Click += btnSubmit_Click;
            btnBrowse.Click += btnBrowse_Click;
            maskedTextBoxMobile.Text = mobilePlaceholder;
            maskedTextBoxMobile.ForeColor = Color.Gray;
            maskedTextBoxMobile.Enter += maskedTextBoxMobile_Enter;
            maskedTextBoxMobile.Leave += maskedTextBoxMobile_Leave;

        }
        private void maskedTextBoxMobile_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxMobile.Text == mobilePlaceholder)
            {
                maskedTextBoxMobile.Text = "";
                maskedTextBoxMobile.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxMobile_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxMobile.Text.Replace("-", "").Trim()))
            {
                maskedTextBoxMobile.Text = mobilePlaceholder;
                maskedTextBoxMobile.ForeColor = Color.Gray;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox.Image = new Bitmap(imagePath);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string mobile = maskedTextBoxMobile.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string sex = radioMale.Checked ? "Male" : "Female";
            string status = comboBoxStatus.SelectedItem.ToString();
            DateTime birthday = dateTimePickerBirthday.Value;
            string location = txtLocation.Text;

            Form3 detailsForm = new Form3(mobile, fname, lname, sex, status, birthday, location, imagePath);
            detailsForm.Show();
        }

        
    }

}
