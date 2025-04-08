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
    public partial class RoomInfoForm : Form
    {
        public RoomInfoForm()
        {
            InitializeComponent();
            LoadRooms();
        }

        // Метод для загрузки данных о номерах в таблицу
        private void LoadRooms()
        {
            try
            {
                string query = "SELECT RoomNumber, Capacity, ComfortLevel, Equipment, PricePerNight " +
                               "FROM Rooms";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvRooms.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        // Кнопка "Обновить"
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRooms(); // Перезагружаем данные в таблицу
            MessageBox.Show("Данные успешно обновлены!");
        }
    }
}