using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InfoManagementSystem
{
    public partial class SelectSeatsPage : Form
    {
        private User user;
        private int numPeople;
        private int selectedSeats = 0;
        private int ID;
      
        public SelectSeatsPage(User user, int numPeople, int ID)
        {
            InitializeComponent();
            this.user = user;
            this.numPeople = numPeople;
            this.ID = ID;
            seatselect.Text = $"{user.username}, please select seats!";

            Update();
        }

        private void Update()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Circus; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT seatID FROM takenTickets WHERE circusID = @ID";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@ID", ID);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int seatID = reader.GetInt32(0);

                    Button seatButton = this.Controls.Find("seat" + seatID, true).FirstOrDefault() as Button;
                    if (seatButton != null)
                    {
                        seatButton.Enabled = false;
                        seatButton.BackColor = Color.Red;
                    }
                }
            }


            for (int i = 1; i <= 25; i++)
            {
                Button seatButton = this.Controls.Find("seat" + i, true).FirstOrDefault() as Button;
                Button seatButtonA = this.Controls.Find("seat" + i + "A", true).FirstOrDefault() as Button;

                if (seatButton != null && seatButton.Enabled)
                {
                    seatButton.BackColor = Color.Green;
                }

                if (seatButtonA != null && seatButtonA.Enabled)
                {
                    seatButtonA.BackColor = Color.Green;
                }
            }
        }

        private void seatClick(int seatID, int circusID)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Circus; Integrated Security=True;"))
            {
                sqlCon.Open();
                string add = "INSERT INTO takenTickets (seatID, circusID, userID) VALUES (@seatID, @circusID, @userID)";
                SqlCommand cmd = new SqlCommand(add, sqlCon);
                cmd.Parameters.AddWithValue("@seatID", seatID);
                cmd.Parameters.AddWithValue("@circusID", circusID);
                cmd.Parameters.AddWithValue("@userID", user.ID);

                cmd.ExecuteNonQuery();
                Update();
                MessageBox.Show("Seat Booked!");
                selectedSeats++;
                if (selectedSeats == numPeople)
                {
                    MessageBox.Show("You have booked your flights for departure and return!");
                    UserSummary usersummary = new UserSummary(user);
                    usersummary.Show();
                    Hide();
                }
            }
        }

        private void seat1_Click(object sender, EventArgs e)
        {
            seatClick(1, ID);
        }

        private void seat2_Click(object sender, EventArgs e)
        {
            seatClick(2, ID);
        }

        private void seat3_Click(object sender, EventArgs e)
        {
            seatClick(3, ID);
        }

        private void seat4_Click(object sender, EventArgs e)
        {
            seatClick(4, ID);
        }

        private void seat5_Click(object sender, EventArgs e)
        {
            seatClick(5, ID);
        }

        private void seat6_Click(object sender, EventArgs e)
        {
            seatClick(6, ID);
        }

        private void seat7_Click(object sender, EventArgs e)
        {
            seatClick(7, ID);
        }

        private void seat8_Click(object sender, EventArgs e)
        {
            seatClick(8, ID);
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            seatClick(9, ID);
        }

        private void seat10_Click(object sender, EventArgs e)
        {
            seatClick(10, ID);
        }

        private void seat11_Click(object sender, EventArgs e)
        {
            seatClick(11, ID);
        }

        private void seat12_Click(object sender, EventArgs e)
        {
            seatClick(12, ID);
        }

        private void seat13_Click(object sender, EventArgs e)
        {
            seatClick(13, ID);
        }

        private void seat14_Click(object sender, EventArgs e)
        {
            seatClick(14, ID);
        }

        private void seat15_Click(object sender, EventArgs e)
        {
            seatClick(15, ID);
        }

        private void seat16_Click(object sender, EventArgs e)
        {
            seatClick(16, ID);
        }

        private void seat17_Click(object sender, EventArgs e)
        {
            seatClick(17, ID);
        }

        private void seat18_Click(object sender, EventArgs e)
        {
            seatClick(18, ID);
        }

        private void seat19_Click(object sender, EventArgs e)
        {
            seatClick(19, ID);
        }

        private void seat20_Click(object sender, EventArgs e)
        {
            seatClick(20, ID);
        }

        private void seat21_Click(object sender, EventArgs e)
        {
            seatClick(21, ID);
        }

        private void seat22_Click(object sender, EventArgs e)
        {
            seatClick(22, ID);
        }

        private void seat23_Click(object sender, EventArgs e)
        {
            seatClick(23, ID);
        }

        private void seat24_Click(object sender, EventArgs e)
        {
            seatClick(24, ID);
        }

        private void seat25_Click(object sender, EventArgs e)
        {
            seatClick(25, ID);
        }
        private void goBack_Click(object sender, EventArgs e)
        {
            
            FindShowsPage form2 = new FindShowsPage(user);
            form2.Show();
            Hide();
        }
    }
}
