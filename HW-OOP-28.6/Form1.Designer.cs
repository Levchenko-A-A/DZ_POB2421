namespace HW_OOP_28._6
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
            dataGridViewExcel = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            buttonOpen = new Button();
            buttonSave = new Button();
            textBoxValue = new TextBox();
            label1 = new Label();
            buttonEdit = new Button();
            buttonAddColums = new Button();
            textBoxNameColums = new TextBox();
            buttonAddRow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExcel).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewExcel
            // 
            dataGridViewExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExcel.Location = new Point(12, 12);
            dataGridViewExcel.Name = "dataGridViewExcel";
            dataGridViewExcel.Size = new Size(940, 595);
            dataGridViewExcel.TabIndex = 0;
            dataGridViewExcel.CellClick += dataGridViewExcel_CellClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(730, 646);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(108, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Открыть";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(844, 646);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(12, 643);
            textBoxValue.Multiline = true;
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(127, 32);
            textBoxValue.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(39, 617);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            label1.Text = "Значение";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(145, 644);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(86, 31);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAddColums
            // 
            buttonAddColums.Location = new Point(463, 644);
            buttonAddColums.Name = "buttonAddColums";
            buttonAddColums.Size = new Size(127, 31);
            buttonAddColums.TabIndex = 6;
            buttonAddColums.Text = "Добавить столбец";
            buttonAddColums.UseVisualStyleBackColor = true;
            buttonAddColums.Click += buttonAddColums_Click;
            // 
            // textBoxNameColums
            // 
            textBoxNameColums.Location = new Point(463, 613);
            textBoxNameColums.Multiline = true;
            textBoxNameColums.Name = "textBoxNameColums";
            textBoxNameColums.Size = new Size(127, 25);
            textBoxNameColums.TabIndex = 7;
            // 
            // buttonAddRow
            // 
            buttonAddRow.Location = new Point(330, 644);
            buttonAddRow.Name = "buttonAddRow";
            buttonAddRow.Size = new Size(127, 31);
            buttonAddRow.TabIndex = 8;
            buttonAddRow.Text = "Добавить строку";
            buttonAddRow.UseVisualStyleBackColor = true;
            buttonAddRow.Click += buttonAddRow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 687);
            Controls.Add(buttonAddRow);
            Controls.Add(textBoxNameColums);
            Controls.Add(buttonAddColums);
            Controls.Add(buttonEdit);
            Controls.Add(label1);
            Controls.Add(textBoxValue);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(dataGridViewExcel);
            Name = "Form1";
            Text = "Редактор Excel";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExcel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewExcel;
        private OpenFileDialog openFileDialog1;
        private Button buttonOpen;
        private Button buttonSave;
        private TextBox textBoxValue;
        private Label label1;
        private Button buttonEdit;
        private Button buttonAddColums;
        private TextBox textBoxNameColums;
        private Button buttonAddRow;
    }
}
