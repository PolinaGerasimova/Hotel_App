namespace Hotel_App
{
    partial class AddRoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComfortLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPricePerNight = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(139, 45);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(136, 22);
            this.txtRoomNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер комнаты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вместимость:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(401, 45);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(136, 22);
            this.txtCapacity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип:";
            // 
            // cmbComfortLevel
            // 
            this.cmbComfortLevel.FormattingEnabled = true;
            this.cmbComfortLevel.Items.AddRange(new object[] {
            "эконом",
            "стандарт",
            "комфорт",
            "люкс"});
            this.cmbComfortLevel.Location = new System.Drawing.Point(602, 44);
            this.cmbComfortLevel.Name = "cmbComfortLevel";
            this.cmbComfortLevel.Size = new System.Drawing.Size(135, 24);
            this.cmbComfortLevel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Комплектация:";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(139, 97);
            this.txtEquipment.Multiline = true;
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Size = new System.Drawing.Size(598, 102);
            this.txtEquipment.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Цена:";
            // 
            // txtPricePerNight
            // 
            this.txtPricePerNight.Location = new System.Drawing.Point(139, 220);
            this.txtPricePerNight.Name = "txtPricePerNight";
            this.txtPricePerNight.Size = new System.Drawing.Size(136, 22);
            this.txtPricePerNight.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(600, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.Location = new System.Drawing.Point(407, 276);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(137, 40);
            this.btnSaveRoom.TabIndex = 10;
            this.btnSaveRoom.Text = "Сохранить";
            this.btnSaveRoom.UseVisualStyleBackColor = true;
            this.btnSaveRoom.Click += new System.EventHandler(this.btnSaveRoom_Click);
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 328);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveRoom);
            this.Controls.Add(this.txtPricePerNight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbComfortLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomNumber);
            this.Name = "AddRoomForm";
            this.Text = "Добавление номера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbComfortLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPricePerNight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveRoom;
    }
}