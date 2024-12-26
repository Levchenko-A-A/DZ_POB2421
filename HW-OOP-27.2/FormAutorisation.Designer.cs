namespace HW_OOP_27._2
{
    partial class FormAutorisation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            linkLabelRegistration = new LinkLabel();
            buttonEnter = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(61, 36);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите логин";
            textBoxLogin.Size = new Size(284, 23);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(61, 76);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Введите пароль";
            textBoxPassword.Size = new Size(284, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // linkLabelRegistration
            // 
            linkLabelRegistration.AutoSize = true;
            linkLabelRegistration.Location = new Point(143, 119);
            linkLabelRegistration.Name = "linkLabelRegistration";
            linkLabelRegistration.Size = new Size(119, 15);
            linkLabelRegistration.TabIndex = 2;
            linkLabelRegistration.TabStop = true;
            linkLabelRegistration.Text = "Зарегистрироваться";
            linkLabelRegistration.LinkClicked += linkLabelRegistration_LinkClicked;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(169, 150);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(75, 23);
            buttonEnter.TabIndex = 3;
            buttonEnter.Text = "Вход";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // FormAutorisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 245);
            Controls.Add(buttonEnter);
            Controls.Add(linkLabelRegistration);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Name = "FormAutorisation";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private LinkLabel linkLabelRegistration;
        private Button buttonEnter;
    }
}
