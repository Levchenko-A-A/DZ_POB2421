namespace HW_OOP_28._5
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
            dataGridViewTask = new DataGridView();
            textBoxTitle = new TextBox();
            dateTimePickerTime = new DateTimePicker();
            textBoxStatus = new TextBox();
            buttonAdd = new Button();
            buttonOk = new Button();
            comboBoxPriority = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTask
            // 
            dataGridViewTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask.Location = new Point(12, 12);
            dataGridViewTask.Name = "dataGridViewTask";
            dataGridViewTask.Size = new Size(434, 426);
            dataGridViewTask.TabIndex = 0;
            dataGridViewTask.CellClick += dataGridViewTask_CellClick;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(452, 12);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Название";
            textBoxTitle.Size = new Size(200, 23);
            textBoxTitle.TabIndex = 1;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Location = new Point(452, 41);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(200, 23);
            dateTimePickerTime.TabIndex = 3;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(452, 99);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.PlaceholderText = "Статус";
            textBoxStatus.Size = new Size(200, 23);
            textBoxStatus.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(452, 128);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(200, 33);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(452, 167);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(200, 33);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "Выполнено";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Items.AddRange(new object[] { "Высокий", "Средний", "Низкий" });
            comboBoxPriority.Location = new Point(452, 70);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(200, 23);
            comboBoxPriority.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(comboBoxPriority);
            Controls.Add(buttonOk);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxStatus);
            Controls.Add(dateTimePickerTime);
            Controls.Add(textBoxTitle);
            Controls.Add(dataGridViewTask);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxTitle;
        private DateTimePicker dateTimePickerTime;
        private TextBox textBoxStatus;
        private Button buttonAdd;
        private Button buttonOk;
        public DataGridView dataGridViewTask;
        private ComboBox comboBoxPriority;
    }
}
