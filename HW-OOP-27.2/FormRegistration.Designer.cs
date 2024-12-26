namespace HW_OOP_27._2
{
    partial class FormRegistration
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
            textBoxLogin = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxRegistration = new TextBox();
            labelEmailWarning = new Label();
            labelWarning = new Label();
            dateTimePickerBers = new DateTimePicker();
            comboBoxRole = new ComboBox();
            buttonReg = new Button();
            textBoxRepit = new TextBox();
            labelPassWarning = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 12);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите логин";
            textBoxLogin.Size = new Size(260, 23);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 41);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Введите Имя";
            textBoxFirstName.Size = new Size(260, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 70);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Введите Фамилию";
            textBoxLastName.Size = new Size(260, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 99);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Введите Адрес почты";
            textBoxEmail.Size = new Size(260, 23);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxRegistration
            // 
            textBoxRegistration.Location = new Point(12, 146);
            textBoxRegistration.Name = "textBoxRegistration";
            textBoxRegistration.PlaceholderText = "Введите Пароль";
            textBoxRegistration.Size = new Size(260, 23);
            textBoxRegistration.TabIndex = 4;
            textBoxRegistration.TextChanged += textBoxRegistration_TextChanged;
            // 
            // labelEmailWarning
            // 
            labelEmailWarning.AutoSize = true;
            labelEmailWarning.ForeColor = Color.Red;
            labelEmailWarning.Location = new Point(12, 125);
            labelEmailWarning.Name = "labelEmailWarning";
            labelEmailWarning.Size = new Size(0, 15);
            labelEmailWarning.TabIndex = 5;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(12, 172);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(0, 15);
            labelWarning.TabIndex = 6;
            // 
            // dateTimePickerBers
            // 
            dateTimePickerBers.Location = new Point(12, 239);
            dateTimePickerBers.Name = "dateTimePickerBers";
            dateTimePickerBers.Size = new Size(260, 23);
            dateTimePickerBers.TabIndex = 7;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "User" });
            comboBoxRole.Location = new Point(12, 268);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(260, 23);
            comboBoxRole.TabIndex = 8;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(69, 297);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(138, 23);
            buttonReg.TabIndex = 9;
            buttonReg.Text = "Зарегистрироваться";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // textBoxRepit
            // 
            textBoxRepit.Location = new Point(12, 195);
            textBoxRepit.Name = "textBoxRepit";
            textBoxRepit.PlaceholderText = "Повторите Пароль";
            textBoxRepit.Size = new Size(260, 23);
            textBoxRepit.TabIndex = 10;
            textBoxRepit.TextChanged += textBoxRepit_TextChanged;
            // 
            // labelPassWarning
            // 
            labelPassWarning.AutoSize = true;
            labelPassWarning.ForeColor = Color.Red;
            labelPassWarning.Location = new Point(12, 221);
            labelPassWarning.Name = "labelPassWarning";
            labelPassWarning.Size = new Size(0, 15);
            labelPassWarning.TabIndex = 11;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 330);
            Controls.Add(labelPassWarning);
            Controls.Add(textBoxRepit);
            Controls.Add(buttonReg);
            Controls.Add(comboBoxRole);
            Controls.Add(dateTimePickerBers);
            Controls.Add(labelWarning);
            Controls.Add(labelEmailWarning);
            Controls.Add(textBoxRegistration);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLogin);
            Name = "FormRegistration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxRegistration;
        private Label labelEmailWarning;
        private Label labelWarning;
        private DateTimePicker dateTimePickerBers;
        private ComboBox comboBoxRole;
        private Button buttonReg;
        private TextBox textBoxRepit;
        private Label labelPassWarning;
    }
}