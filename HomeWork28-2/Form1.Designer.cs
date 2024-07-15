namespace HomeWork28_2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUser = new TextBox();
            listBoxLogin = new ListBox();
            listBoxPassword = new ListBox();
            buttonRegen = new Button();
            buttonRemov = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(235, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 1;
            label2.Text = "Логин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(448, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(22, 56);
            textBoxUser.Margin = new Padding(4);
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(194, 85);
            textBoxUser.TabIndex = 3;
            // 
            // listBoxLogin
            // 
            listBoxLogin.FormattingEnabled = true;
            listBoxLogin.ItemHeight = 25;
            listBoxLogin.Location = new Point(235, 56);
            listBoxLogin.Margin = new Padding(4);
            listBoxLogin.Name = "listBoxLogin";
            listBoxLogin.Size = new Size(186, 329);
            listBoxLogin.TabIndex = 4;
            // 
            // listBoxPassword
            // 
            listBoxPassword.FormattingEnabled = true;
            listBoxPassword.ItemHeight = 25;
            listBoxPassword.Location = new Point(448, 56);
            listBoxPassword.Margin = new Padding(4);
            listBoxPassword.Name = "listBoxPassword";
            listBoxPassword.Size = new Size(186, 329);
            listBoxPassword.TabIndex = 5;
            // 
            // buttonRegen
            // 
            buttonRegen.Location = new Point(21, 149);
            buttonRegen.Margin = new Padding(4);
            buttonRegen.Name = "buttonRegen";
            buttonRegen.Size = new Size(195, 115);
            buttonRegen.TabIndex = 6;
            buttonRegen.Text = "СГЕНЕРИРОВАТЬ ПАРОЛЬ";
            buttonRegen.UseVisualStyleBackColor = true;
            buttonRegen.Click += buttonRegen_Click;
            // 
            // buttonRemov
            // 
            buttonRemov.Location = new Point(22, 272);
            buttonRemov.Margin = new Padding(4);
            buttonRemov.Name = "buttonRemov";
            buttonRemov.Size = new Size(195, 115);
            buttonRemov.TabIndex = 7;
            buttonRemov.Text = "Удилить запись";
            buttonRemov.UseVisualStyleBackColor = true;
            buttonRemov.Click += buttonRemov_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 409);
            Controls.Add(buttonRemov);
            Controls.Add(buttonRegen);
            Controls.Add(listBoxPassword);
            Controls.Add(listBoxLogin);
            Controls.Add(textBoxUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUser;
        private ListBox listBoxLogin;
        private ListBox listBoxPassword;
        private Button buttonRegen;
        private Button buttonRemov;
    }
}
