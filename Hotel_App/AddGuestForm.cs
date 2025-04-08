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
    public partial class AddGuestForm : Form
    {
        public AddGuestForm()
        {
            InitializeComponent();
        }

        private void btnSaveGuest_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            try
            {
                string query = "INSERT INTO Guests (FullName, PhoneNumber, Email) VALUES (@FullName, @PhoneNumber, @Email)";
                var parameters = new Dictionary<string, object>
                {
                    { "@FullName", fullName },
                    { "@PhoneNumber", phone },
                    { "@Email", email }
                };
                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Постоялец успешно добавлен!");
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