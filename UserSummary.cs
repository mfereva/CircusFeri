using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace InfoManagementSystem
{
    public partial class UserSummary : Form
    {
        private User user;
        private string UserName;
        private int UserID;
        private SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Circus; Integrated Security=True;");

        public UserSummary(User user)
        {
            InitializeComponent();
            UserName = user.username;
            UserID = user.ID;
            hello.Text = $"Hello, {user.username}! Here are your booked shows:";
            LoadDataIntoDataGridView();
            summary.CellClick += summary_CellClick;
        }

        private void summary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                int seatID = Convert.ToInt32(summary.Rows[e.RowIndex].Cells["seat number"].Value);
                int circusID = Convert.ToInt32(summary.Rows[e.RowIndex].Cells["circusID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to cancel this ticket?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DeleteRecordFromTakenTickets(seatID, circusID);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row before attempting to cancel a flight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRecordFromTakenTickets(int seatID, int circusID)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string query = "DELETE FROM takenTickets WHERE seatID = @SeatID AND circusID = @CircusID";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    command.Parameters.AddWithValue("@SeatID", seatID);
                    command.Parameters.AddWithValue("@CircusID", circusID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ticket cancelled successfully.");
                        LoadDataIntoDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful cancellation.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                string query = @"
                    SELECT t.circusID, date, city, seatID as 'seat number'
                    FROM takenTickets t
                    JOIN circuses c
                    ON t.circusID = c.circusID
                    WHERE userID = @UserID";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        summary.DataSource = dataTable;
                        summary.Columns["circusID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading taken seats: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            WelcomePage Form1 = new WelcomePage();
            Hide();
            Form1.Show();
        }

        private void findflights_Click(object sender, EventArgs e)
        {
            User user = new User(UserID,UserName);
            FindShowsPage form2 = new FindShowsPage(user);
            form2.Show();
            Hide();
        }

       
        
    }
}

