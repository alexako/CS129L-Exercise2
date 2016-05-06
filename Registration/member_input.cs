using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Registration
{
    public partial class member_input : Form
    {
        bool nameIsValid, ageIsValid;

        public member_input()
        {
            InitializeComponent();

        }

        private void submit_Click(object sender, EventArgs e) { }

        private void memberAge_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(memberAge.Text))
            {
                errorProvider1.SetError(memberAge, String.Empty);
                ageIsValid = true;
            }
            else if (!memberAge.Text.Equals(String.Empty))
            {
                errorProvider1.SetError(memberAge, "Only enter numbers here.");
                ageIsValid = false;
            }
            enableButtonIfAllValid();
        }

        private void memberName_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Za-z]+$");
            if (regex.IsMatch(memberName.Text))
            {
                errorProvider2.SetError(memberName, String.Empty);
                nameIsValid = true;
            }
            else if (!memberName.Text.Equals(String.Empty))
            {
                errorProvider2.SetError(memberName, "Only enter letters here.");
                nameIsValid = false;
            }
            enableButtonIfAllValid();
        }

        public void enableButtonIfAllValid()
        {
            submit.Enabled = nameIsValid && ageIsValid;
        }
    }
}
