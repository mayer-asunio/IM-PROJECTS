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
    public partial class Form3 : Form
    {
        public Form3(string mobile, string fname, string lname, string sex, string status, DateTime birthday, string location, string imagePath)
        {
            InitializeComponent();

            maskedTextBoxMobile.Text = mobile;
            txtFirstName.Text = fname;
            txtLastName.Text = lname;

            if (sex == "Male") radioMale.Checked = true;
            else radioFemale.Checked = true;

            comboBoxStatus.SelectedItem = status;
            dateTimePickerBirthday.Value = birthday;
            txtLocation.Text = location;

            if (!string.IsNullOrEmpty(imagePath))
                pictureBox.Image = new Bitmap(imagePath);
            DisableInputs();
        }
        private void DisableInputs()
        {
            maskedTextBoxMobile.Enabled = false;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            radioMale.Enabled = false;
            radioFemale.Enabled = false;
            comboBoxStatus.Enabled = false;
            dateTimePickerBirthday.Enabled = false;
            txtLocation.ReadOnly = true;
            pictureBox.Enabled = false;
        }
    }
}

