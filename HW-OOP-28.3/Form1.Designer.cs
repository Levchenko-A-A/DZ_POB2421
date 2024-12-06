namespace HW_OOP_28._3
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
            dataGridViewContact = new DataGridView();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxPatronymic = new TextBox();
            textBoxAdress = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            textBoxPhone = new TextBox();
            textBoxMail = new TextBox();
            buttonRead = new Button();
            buttonSave = new Button();
            label1 = new Label();
            textBoxSort = new TextBox();
            buttonSort = new Button();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContact).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewContact
            // 
            dataGridViewContact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContact.Location = new Point(12, 11);
            dataGridViewContact.Margin = new Padding(4);
            dataGridViewContact.Name = "dataGridViewContact";
            dataGridViewContact.RowHeadersWidth = 51;
            dataGridViewContact.Size = new Size(620, 764);
            dataGridViewContact.TabIndex = 0;
            dataGridViewContact.CellClick += dataGridViewContact_CellClick;
            dataGridViewContact.KeyDown += dataGridViewContact_KeyDown;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(640, 11);
            textBoxFirstName.Margin = new Padding(4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Имя";
            textBoxFirstName.Size = new Size(311, 34);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(640, 85);
            textBoxLastName.Margin = new Padding(4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(311, 34);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(640, 48);
            textBoxPatronymic.Margin = new Padding(4);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.PlaceholderText = "Отчество";
            textBoxPatronymic.Size = new Size(311, 34);
            textBoxPatronymic.TabIndex = 3;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(640, 122);
            textBoxAdress.Margin = new Padding(4);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.PlaceholderText = "Адрес";
            textBoxAdress.Size = new Size(311, 34);
            textBoxAdress.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(640, 232);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(312, 42);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(641, 280);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(312, 39);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(640, 159);
            textBoxPhone.Margin = new Padding(4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.PlaceholderText = "Номер телефона";
            textBoxPhone.Size = new Size(311, 34);
            textBoxPhone.TabIndex = 7;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(640, 196);
            textBoxMail.Margin = new Padding(4);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "Элекстронный адрес";
            textBoxMail.Size = new Size(311, 34);
            textBoxMail.TabIndex = 8;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(639, 736);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(312, 38);
            buttonRead.TabIndex = 9;
            buttonRead.Text = "Прочитать";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(639, 689);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(312, 41);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.Location = new Point(641, 333);
            label1.Name = "label1";
            label1.Size = new Size(310, 25);
            label1.TabIndex = 11;
            label1.Text = "Введите Имя для сортировки";
            // 
            // textBoxSort
            // 
            textBoxSort.Location = new Point(641, 361);
            textBoxSort.Name = "textBoxSort";
            textBoxSort.Size = new Size(310, 34);
            textBoxSort.TabIndex = 12;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(641, 401);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(312, 39);
            buttonSort.TabIndex = 13;
            buttonSort.Text = "Сортировать";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(639, 446);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(312, 39);
            buttonReset.TabIndex = 14;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 786);
            Controls.Add(buttonReset);
            Controls.Add(buttonSort);
            Controls.Add(textBoxSort);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(buttonRead);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxPhone);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxPatronymic);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(dataGridViewContact);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Список контактов";
            ((System.ComponentModel.ISupportInitialize)dataGridViewContact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewContact;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPatronymic;
        private TextBox textBoxAdress;
        private Button buttonAdd;
        private Button buttonEdit;
        private TextBox textBoxPhone;
        private TextBox textBoxMail;
        private Button buttonRead;
        private Button buttonSave;
        private Label label1;
        private TextBox textBoxSort;
        private Button buttonSort;
        private Button buttonReset;
    }
}
