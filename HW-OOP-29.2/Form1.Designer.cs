namespace HW_OOP_29._2
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
            textBoxSeach = new TextBox();
            comboBoxFilter = new ComboBox();
            dataGridViewInventors = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            textBoxName = new TextBox();
            textBoxQuant = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDesc = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventors).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSeach
            // 
            textBoxSeach.Location = new Point(12, 27);
            textBoxSeach.Name = "textBoxSeach";
            textBoxSeach.PlaceholderText = "Введите строку для поиска";
            textBoxSeach.Size = new Size(168, 23);
            textBoxSeach.TabIndex = 0;
            textBoxSeach.TextChanged += textBoxSeach_TextChanged;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Название", "Количество", "Цена" });
            comboBoxFilter.Location = new Point(186, 27);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(121, 23);
            comboBoxFilter.TabIndex = 1;
            // 
            // dataGridViewInventors
            // 
            dataGridViewInventors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventors.Location = new Point(12, 56);
            dataGridViewInventors.Name = "dataGridViewInventors";
            dataGridViewInventors.Size = new Size(684, 391);
            dataGridViewInventors.TabIndex = 2;
            dataGridViewInventors.CellClick += dataGridViewInventors_CellClick;
            dataGridViewInventors.KeyDown += dataGridViewInventors_KeyDown;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 463);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(899, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(702, 56);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Название";
            textBoxName.Size = new Size(179, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxQuant
            // 
            textBoxQuant.Location = new Point(702, 85);
            textBoxQuant.Name = "textBoxQuant";
            textBoxQuant.PlaceholderText = "Количество";
            textBoxQuant.Size = new Size(179, 23);
            textBoxQuant.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(702, 114);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Цена";
            textBoxPrice.Size = new Size(179, 23);
            textBoxPrice.TabIndex = 6;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(702, 143);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.PlaceholderText = "Пояснение";
            textBoxDesc.Size = new Size(179, 259);
            textBoxDesc.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(702, 408);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(84, 39);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(797, 408);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(84, 39);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(899, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 485);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxQuant);
            Controls.Add(textBoxName);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridViewInventors);
            Controls.Add(comboBoxFilter);
            Controls.Add(textBoxSeach);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventors).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSeach;
        private ComboBox comboBoxFilter;
        private DataGridView dataGridViewInventors;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox textBoxName;
        private TextBox textBoxQuant;
        private TextBox textBoxPrice;
        private TextBox textBoxDesc;
        private Button buttonAdd;
        private Button buttonEdit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}
