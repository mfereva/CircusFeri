using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace InfoManagementSystem
{
    public partial class ResultsPage : Form
    {
        
        private SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9NUMRJG; Initial Catalog=Circus; Integrated Security=True;");
        private User user;
        public string Date { get; set; }
        public string City { get; set; }

        public int NumPeople { get; set; }

        public ResultsPage(User user, string date, string city, int numPeople)
        { 
            InitializeComponent();
            this.user = user;
            Date = date;
            City = city;
            NumPeople = numPeople;

            DataGridViewButtonColumn bookButtonColumn = new DataGridViewButtonColumn();
            bookButtonColumn.Name = "Book";
            bookButtonColumn.Text = "Book";
            bookButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bookButtonColumn);

            dataGridView1.CellClick += (sender, e) =>
            {
                try
                {
                    if (e.ColumnIndex == dataGridView1.Columns["Book"].Index && e.RowIndex >= 0)
                    {
                        int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["circusID"].Value);
                        SelectSeatsPage selectSeats = new SelectSeatsPage(user, NumPeople, ID);
                        selectSeats.Show();
                        Hide();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. " + ex.Message);
                }
            };
            LoadData();
        }

        private void LoadData()
        {
            sqlCon.Open();

            string query = @"
            SELECT * FROM circuses c WHERE (SELECT COUNT(*) FROM takenTickets WHERE circusID = c.circusID) < (25 - @numPeople) AND city = @city AND date = @date";

            SqlCommand cmd = new SqlCommand(query, sqlCon);

            cmd.Parameters.AddWithValue("@city", City);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@numPeople", NumPeople);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
            }
            sqlCon.Close();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            FindShowsPage form2 = new FindShowsPage(user);
            form2.Show();
            Hide();
        }

    }
}
