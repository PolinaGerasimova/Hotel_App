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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            LoadGuests();
            LoadRooms();
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
        }

        private void LoadGuests()
        {
            try
            {
                string query = "SELECT GuestID, FullName FROM Guests";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cmbGuests.DataSource = dt;
                cmbGuests.DisplayMember = "FullName";
                cmbGuests.ValueMember = "GuestID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке гостей: {ex.Message}");
            }
        }

        private void LoadRooms()
        {
            try
            {
                string query = "SELECT RoomID, RoomNumber, PricePerNight FROM Rooms";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                cmbRooms.DataSource = dt;
                cmbRooms.DisplayMember = "RoomNumber";
                cmbRooms.ValueMember = "RoomID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке номеров: {ex.Message}");
            }
        }

        private void CalculateTotalPrice()
        {
            if (decimal.TryParse(txtDiscount.Text, out decimal discount) &&
                cmbRooms.SelectedValue != null)
            {
                if (discount < 0 || discount > 100)
                {
                    MessageBox.Show("Скидка должна быть в диапазоне от 0 до 100%");
                    return;
                }

                decimal pricePerNight = Convert.ToDecimal(((DataRowView)cmbRooms.SelectedItem)["PricePerNight"]);
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;

                if (checkIn >= checkOut)
                {
                    MessageBox.Show("Дата выезда должна быть позже даты заезда.");
                    return;
                }

                int nights = (checkOut - checkIn).Days;
                decimal totalPrice = pricePerNight * nights;
                decimal finalPrice = totalPrice - (totalPrice * discount / 100);

                txtTotalPrice.Text = finalPrice.ToString("F2");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для скидки.");
            }
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, выбран ли гость
                if (cmbGuests.SelectedIndex == -1 || cmbGuests.SelectedValue == null)
                {
                    MessageBox.Show("Выберите гостя.");
                    return;
                }

                // Проверяем, выбран ли номер
                if (cmbRooms.SelectedIndex == -1 || cmbRooms.SelectedValue == null)
                {
                    MessageBox.Show("Выберите номер.");
                    return;
                }

                // Получаем выбранные значения
                int guestID = Convert.ToInt32(cmbGuests.SelectedValue);
                int roomID = Convert.ToInt32(cmbRooms.SelectedValue);

                // Проверяем даты заезда и выезда
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;

                if (checkIn >= checkOut)
                {
                    MessageBox.Show("Дата выезда должна быть позже даты заезда.");
                    return;
                }

                // Проверяем поле "Итоговая стоимость"
                if (!decimal.TryParse(txtTotalPrice.Text, out decimal totalPrice) || totalPrice <= 0)
                {
                    MessageBox.Show("Пожалуйста, рассчитайте итоговую стоимость.");
                    return;
                }

                // Если все проверки пройдены, выполняем запрос к базе данных
                string query = "INSERT INTO Bookings (GuestID, RoomID, CheckInDate, CheckOutDate, TotalPrice) " +
                               "VALUES (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @TotalPrice)";
                var parameters = new Dictionary<string, object>
        {
            { "@GuestID", guestID },
            { "@RoomID", roomID },
            { "@CheckInDate", checkIn },
            { "@CheckOutDate", checkOut },
            { "@TotalPrice", totalPrice }
        };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Бронирование успешно сохранено!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}