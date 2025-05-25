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
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new шаблон_приложения.DataSet1();
            this.bookingsTableAdapter = new шаблон_приложения.DataSet1TableAdapters.bookingsTableAdapter();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new шаблон_приложения.DataSet1TableAdapters.guestsTableAdapter();
            this.panel_manager = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(283, 51);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(256, 20);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Рабочая область менеджера";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "guests";
            this.guestsBindingSource.DataSource = this.dataSet1;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // panel_manager
            // 
            this.panel_manager.Location = new System.Drawing.Point(12, 139);
            this.panel_manager.Name = "panel_manager";
            this.panel_manager.Size = new System.Drawing.Size(776, 233);
            this.panel_manager.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.bookingsToolStripMenuItem.Text = "Бронирования";
            this.bookingsToolStripMenuItem.Click += new System.EventHandler(this.bookingsToolStripMenuItem_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_manager);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Manager";
            this.Text = "Окно менеджера";
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private DataSet1TableAdapters.bookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private DataSet1TableAdapters.guestsTableAdapter guestsTableAdapter;
        private System.Windows.Forms.Panel panel_manager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
    }
}