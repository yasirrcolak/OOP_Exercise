using System;
using System.Windows.Forms;

namespace ObjectOrientedProgramming_Exercise
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Admin button method. Go to Admin Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminButton_Click(object sender, EventArgs e)
        {
            var adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }

        /// <summary>
        /// User button method. Go to User Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Click(object sender, EventArgs e)
        {
            var userPage = new UserPage();
            userPage.Show();
            this.Hide();
        }
    }
}
