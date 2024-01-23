namespace HomeWork_ISP_203_13_01
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.LoginLable = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegistor = new System.Windows.Forms.Button();
            this.timerBlock = new System.Windows.Forms.Timer(this.components);
            this.labelPasswordCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoginLable.Location = new System.Drawing.Point(209, 111);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(124, 44);
            this.LoginLable.TabIndex = 0;
            this.LoginLable.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxLogin.Location = new System.Drawing.Point(114, 160);
            this.textBoxLogin.MaxLength = 12;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(314, 50);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPassword.Location = new System.Drawing.Point(196, 226);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(151, 44);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxPassword.Location = new System.Drawing.Point(114, 275);
            this.textBoxPassword.MaxLength = 16;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(314, 50);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonLogin.Location = new System.Drawing.Point(128, 375);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(286, 85);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegistor
            // 
            this.buttonRegistor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRegistor.Location = new System.Drawing.Point(153, 479);
            this.buttonRegistor.Name = "buttonRegistor";
            this.buttonRegistor.Size = new System.Drawing.Size(236, 62);
            this.buttonRegistor.TabIndex = 4;
            this.buttonRegistor.Text = "Регистрация";
            this.buttonRegistor.UseVisualStyleBackColor = true;
            this.buttonRegistor.Click += new System.EventHandler(this.buttonRegistor_Click);
            // 
            // timerBlock
            // 
            this.timerBlock.Interval = 20000;
            this.timerBlock.Tick += new System.EventHandler(this.timerBlock_Tick);
            // 
            // labelPasswordCount
            // 
            this.labelPasswordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPasswordCount.Location = new System.Drawing.Point(135, 336);
            this.labelPasswordCount.Name = "labelPasswordCount";
            this.labelPasswordCount.Size = new System.Drawing.Size(273, 31);
            this.labelPasswordCount.TabIndex = 5;
            this.labelPasswordCount.Text = "Кол-во попыток: 3";
            this.labelPasswordCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 652);
            this.Controls.Add(this.labelPasswordCount);
            this.Controls.Add(this.buttonRegistor);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.LoginLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Логин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegistor;
        private System.Windows.Forms.Timer timerBlock;
        private System.Windows.Forms.Label labelPasswordCount;
    }
}

