namespace шаблон_приложения
{
    partial class Manager
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
            this.components = new System.ComponentModel.Container();
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView_booking = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new шаблон_приложения.DataSet1();
            this.bookingsTableAdapter = new шаблон_приложения.DataSet1TableAdapters.bookingsTableAdapter();
            this.button_save = new System.Windows.Forms.Button();
            this.label_table_booking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(286, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(256, 20);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Рабочая область менеджера";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView_booking
            // 
            this.dataGridView_booking.AllowUserToAddRows = false;
            this.dataGridView_booking.AllowUserToDeleteRows = false;
            this.dataGridView_booking.AutoGenerateColumns = false;
            this.dataGridView_booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_booking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.guestidDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.datebeginDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView_booking.DataSource = this.bookingsBindingSource;
            this.dataGridView_booking.Location = new System.Drawing.Point(28, 116);
            this.dataGridView_booking.Name = "dataGridView_booking";
            this.dataGridView_booking.Size = new System.Drawing.Size(751, 150);
            this.dataGridView_booking.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guestidDataGridViewTextBoxColumn
            // 
            this.guestidDataGridViewTextBoxColumn.DataPropertyName = "guest_id";
            this.guestidDataGridViewTextBoxColumn.HeaderText = "guest_id";
            this.guestidDataGridViewTextBoxColumn.Name = "guestidDataGridViewTextBoxColumn";
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            // 
            // datebeginDataGridViewTextBoxColumn
            // 
            this.datebeginDataGridViewTextBoxColumn.DataPropertyName = "date_begin";
            this.datebeginDataGridViewTextBoxColumn.HeaderText = "date_begin";
            this.datebeginDataGridViewTextBoxColumn.Name = "datebeginDataGridViewTextBoxColumn";
            // 
            // dateendDataGridViewTextBoxColumn
            // 
            this.dateendDataGridViewTextBoxColumn.DataPropertyName = "date_end";
            this.dateendDataGridViewTextBoxColumn.HeaderText = "date_end";
            this.dateendDataGridViewTextBoxColumn.Name = "dateendDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "bookings";
            this.bookingsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(372, 272);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_table_booking
            // 
            this.label_table_booking.AutoSize = true;
            this.label_table_booking.Location = new System.Drawing.Point(25, 90);
            this.label_table_booking.Name = "label_table_booking";
            this.label_table_booking.Size = new System.Drawing.Size(125, 13);
            this.label_table_booking.TabIndex = 5;
            this.label_table_booking.Text = "Таблица бронирований";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_table_booking);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView_booking);
            this.Controls.Add(this.label_title);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Manager";
            this.Text = "Окно менеджера";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.DataGridView dataGridView_booking;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private DataSet1TableAdapters.bookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_table_booking;
    }
}