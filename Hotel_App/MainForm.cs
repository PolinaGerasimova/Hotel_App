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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            AddGuestForm addGuestForm = new AddGuestForm();
            addGuestForm.Show();
        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            RoomInfoForm roomInfoForm = new RoomInfoForm();
            roomInfoForm.Show();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            CheckInOutForm checkInOutForm = new CheckInOutForm();
            checkInOutForm.Show();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomForm addRoomForm = new AddRoomForm();
            addRoomForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите выйти из программы?",
                "Подтверждение выхода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}