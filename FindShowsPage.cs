using System;
using System.CodeDom;
using System.Windows.Forms;

namespace InfoManagementSystem
{
    public partial class FindShowsPage : Form
    {
        private User user;
        public FindShowsPage(User user)
        {
            InitializeComponent();
            this.user = user;
            welcome.Text = $"Hello, {user.username}! You can find flights here";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSummary usersummary = new UserSummary(user);
            usersummary.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(city.Text) || string.IsNullOrEmpty(peopleNumber.Text) || dateCalendar.SelectionStart == null)
            {
                MessageBox.Show("Please fill out all fields.");
            }
            else if (dateCalendar.SelectionStart < DateTime.Now)
            {
                MessageBox.Show("Sorry to dissapoint, but you can only book for the future.");
            }
            else
            {
                if (int.TryParse(peopleNumber.Text, out int numPeope))
                {  
                    try
                    {
                        ResultsPage results = new ResultsPage(user, dateCalendar.SelectionStart.ToShortDateString(), city.Text, numPeope);
                        results.Show();
                        Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for travellers!");
                }
            }

        }
    }
}
