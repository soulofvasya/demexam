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
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблица1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблица2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблица1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new шаблон_приложения.DataSet1();
            this.usersTableAdapter = new шаблон_приложения.DataSet1TableAdapters.usersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem,
            this.рольToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблица1ToolStripMenuItem,
            this.таблица2ToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // таблица1ToolStripMenuItem
            // 
            this.таблица1ToolStripMenuItem.Name = "таблица1ToolStripMenuItem";
            this.таблица1ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.таблица1ToolStripMenuItem.Text = "таблица1";
            this.таблица1ToolStripMenuItem.Click += new System.EventHandler(this.таблица1ToolStripMenuItem_Click);
            // 
            // таблица2ToolStripMenuItem
            // 
            this.таблица2ToolStripMenuItem.Name = "таблица2ToolStripMenuItem";
            this.таблица2ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.таблица2ToolStripMenuItem.Text = "таблица2";
            // 
            // рольToolStripMenuItem
            // 
            this.рольToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблица1ToolStripMenuItem1});
            this.рольToolStripMenuItem.Name = "рольToolStripMenuItem";
            this.рольToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.рольToolStripMenuItem.Text = "2роль";
            // 
            // таблица1ToolStripMenuItem1
            // 
            this.таблица1ToolStripMenuItem1.Name = "таблица1ToolStripMenuItem1";
            this.таблица1ToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.таблица1ToolStripMenuItem1.Text = "таблица1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблица1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблица2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблица1ToolStripMenuItem1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}