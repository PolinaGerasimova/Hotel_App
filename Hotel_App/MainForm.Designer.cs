namespace Hotel_App
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnViewRooms = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.btnCheckInOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Location = new System.Drawing.Point(27, 33);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(190, 72);
            this.btnAddGuest.TabIndex = 0;
            this.btnAddGuest.Text = "Добавить постояльца";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnViewRooms
            // 
            this.btnViewRooms.Location = new System.Drawing.Point(27, 267);
            this.btnViewRooms.Name = "btnViewRooms";
            this.btnViewRooms.Size = new System.Drawing.Size(190, 72);
            this.btnViewRooms.TabIndex = 1;
            this.btnViewRooms.Text = "Просмотреть номера";
            this.btnViewRooms.UseVisualStyleBackColor = true;
            this.btnViewRooms.Click += new System.EventHandler(this.btnViewRooms_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(27, 111);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(190, 72);
            this.btnBookRoom.TabIndex = 2;
            this.btnBookRoom.Text = "Забронировать номер";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // btnCheckInOut
            // 
            this.btnCheckInOut.Location = new System.Drawing.Point(27, 189);
            this.btnCheckInOut.Name = "btnCheckInOut";
            this.btnCheckInOut.Size = new System.Drawing.Size(190, 72);
            this.btnCheckInOut.TabIndex = 3;
            this.btnCheckInOut.Text = "Заселение/Выселение";
            this.btnCheckInOut.UseVisualStyleBackColor = true;
            this.btnCheckInOut.Click += new System.EventHandler(this.btnCheckInOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 438);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(27, 345);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(190, 72);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Добавить номер";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(27, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 513);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheckInOut);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.btnViewRooms);
            this.Controls.Add(this.btnAddGuest);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СветлячОк";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnViewRooms;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Button btnCheckInOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnExit;
    }
}

