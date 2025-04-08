namespace Hotel_App
{
    partial class RoomInfoForm
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnSaveGuest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(24, 27);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.Size = new System.Drawing.Size(1067, 424);
            this.dgvRooms.TabIndex = 0;
            // 
            // btnSaveGuest
            // 
            this.btnSaveGuest.Location = new System.Drawing.Point(954, 461);
            this.btnSaveGuest.Name = "btnSaveGuest";
            this.btnSaveGuest.Size = new System.Drawing.Size(137, 40);
            this.btnSaveGuest.TabIndex = 8;
            this.btnSaveGuest.Text = "Обновить";
            this.btnSaveGuest.UseVisualStyleBackColor = true;
            this.btnSaveGuest.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // RoomInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 513);
            this.Controls.Add(this.btnSaveGuest);
            this.Controls.Add(this.dgvRooms);
            this.Name = "RoomInfoForm";
            this.Text = "Информация о номерах";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnSaveGuest;
    }
}