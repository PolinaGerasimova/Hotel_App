using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App
{
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();

            // Инициализация выпадающего списка "Уровень комфорта"
            cmbComfortLevel.Items.AddRange(new string[] { "эконом", "стандарт", "премиум", "люкс" });
            cmbComfortLevel.SelectedIndex = 0; // Устанавливаем значение по умолчанию
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            string roomNumber = txtRoomNumber.Text;
            int capacity = Convert.ToInt32(txtCapacity.Text);
            string comfortLevel = cmbComfortLevel.SelectedItem.ToString();
            string equipment = txtEquipment.Text;
            decimal pricePerNight = Convert.ToDecimal(txtPricePerNight.Text);

            if (string.IsNullOrEmpty(roomNumber) || capacity <= 0 || string.IsNullOrEmpty(equipment) ||
                pricePerNight <= 0)
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля корректно.");
                return;
            }

            try
            {
                string query = "INSERT INTO Rooms (RoomNumber, Capacity, ComfortLevel, Equipment, PricePerNight) " +
                               "VALUES (@RoomNumber, @Capacity, @ComfortLevel, @Equipment, @PricePerNight)";
                var parameters = new Dictionary<string, object>
                {
                    { "@RoomNumber", roomNumber },
                    { "@Capacity", capacity },
                    { "@ComfortLevel", comfortLevel },
                    { "@Equipment", equipment },
                    { "@PricePerNight", pricePerNight }
                };
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Номер успешно добавлен!");
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