namespace шаблон_приложения
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new шаблон_приложения.DataSet1();
            this.usersTableAdapter = new шаблон_приложения.DataSet1TableAdapters.usersTableAdapter();
            this.panelContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.bookingServicesToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.guestsToolStripMenuItem,
            this.shiftsToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.table2ToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.adminToolStripMenuItem.Text = "Администрирование";
            this.adminToolStripMenuItem.Visible = false;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.usersToolStripMenuItem.Text = "таблица пользователей";
            
            // 
            // table2ToolStripMenuItem
            // 
            this.table2ToolStripMenuItem.Name = "table2ToolStripMenuItem";
            this.table2ToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.table2ToolStripMenuItem.Text = "таблица2";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.servicesToolStripMenuItem.Text = "Услуги";
            this.servicesToolStripMenuItem.Visible = false;
            // 
            // bookingServicesToolStripMenuItem
            // 
            this.bookingServicesToolStripMenuItem.Name = "bookingServicesToolStripMenuItem";
            this.bookingServicesToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.bookingServicesToolStripMenuItem.Text = "Заказы";
            this.bookingServicesToolStripMenuItem.Visible = false;
            this.bookingServicesToolStripMenuItem.Click += new System.EventHandler(this.bookingServicesToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.bookingsToolStripMenuItem.Text = "Бронирования";
            this.bookingsToolStripMenuItem.Visible = false;
            // 
            // guestsToolStripMenuItem
            // 
            this.guestsToolStripMenuItem.Name = "guestsToolStripMenuItem";
            this.guestsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.guestsToolStripMenuItem.Text = "Гости";
            this.guestsToolStripMenuItem.Visible = false;
            this.guestsToolStripMenuItem.Click += new System.EventHandler(this.guestsToolStripMenuItem_Click);
            // 
            // shiftsToolStripMenuItem
            // 
            this.shiftsToolStripMenuItem.Name = "shiftsToolStripMenuItem";
            this.shiftsToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.shiftsToolStripMenuItem.Text = "Смены";
            this.shiftsToolStripMenuItem.Visible = false;
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.employeesToolStripMenuItem.Text = "Сотрудники";
            this.employeesToolStripMenuItem.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать!";
            
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(12, 72);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1043, 470);
            this.panelContent.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem table2ToolStripMenuItem;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.Panel panelContent;
    }
}