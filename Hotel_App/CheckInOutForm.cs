using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_App
{
    public partial class CheckInOutForm : Form
    {
        public CheckInOutForm()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                string query = "SELECT BookingID, FullName, RoomNumber, CheckInDate, CheckOutDate, TotalPrice, Status " +
                               "FROM Bookings b JOIN Guests g ON b.GuestID = g.GuestID " +
                               "JOIN Rooms r ON b.RoomID = r.RoomID";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvBookings.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование для заселения.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            try
            {
                string query = "UPDATE Bookings SET Status = 'CheckedIn' WHERE BookingID = @BookingID";
                var parameters = new Dictionary<string, object> { { "@BookingID", bookingID } };
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Гость успешно заселен!");
                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Кнопка "Выселить"
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование для выселения.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            try
            {
                string query = "UPDATE Bookings SET Status = 'CheckedOut' WHERE BookingID = @BookingID";
                var parameters = new Dictionary<string, object> { { "@BookingID", bookingID } };
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Гость успешно выселен!");
                LoadBookings(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронирование для отмены.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            try
            {
                string query = "DELETE FROM Bookings WHERE BookingID = @BookingID";
                var parameters = new Dictionary<string, object> { { "@BookingID", bookingID } };
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Бронирование успешно отменено!");
                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
            MessageBox.Show("Данные успешно обновлены!");
        }
    }
}