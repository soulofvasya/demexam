namespace шаблон_приложения
{
    partial class Auth
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
            this.button_auth = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_auth
            // 
            this.button_auth.Location = new System.Drawing.Point(367, 358);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(75, 23);
            this.button_auth.TabIndex = 0;
            this.button_auth.Text = "Войти";
            this.button_auth.UseVisualStyleBackColor = true;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(327, 185);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(41, 13);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Логин:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(320, 217);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(48, 13);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Пароль:";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(405, 177);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(123, 20);
            this.textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(405, 217);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(123, 20);
            this.textBox_password.TabIndex = 4;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(350, 69);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(101, 13);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Окно авторизации";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_auth);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_title;
    }
}

