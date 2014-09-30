using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAppUsingSetGet
{
    public partial class PersonAppUI : Form
    {
        public PersonAppUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            person aPerson=new person();

            aPerson.FirstName = firstNameTextBox.Text;

            aPerson.MiddleName = middleNameTextBox.Text;
            aPerson.LastName = lastNameTextBox.Text;

            fullNameTextBox.Text = aPerson.GetFulName();
            reversNameTextBox.Text = aPerson.GetReversName();
        }
    }
}
