namespace HomeWork25_1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            acToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            buttonAddTack = new Button();
            buttonDelTack = new Button();
            labelAllTack = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelActTack = new Label();
            labelOverdueTack = new Label();
            textBoxNameTackAdd = new TextBox();
            label1 = new Label();
            textBoxNameTackDel = new TextBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, acToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(748, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // acToolStripMenuItem
            // 
            acToolStripMenuItem.Name = "acToolStripMenuItem";
            acToolStripMenuItem.Size = new Size(66, 24);
            acToolStripMenuItem.Text = "Action";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // buttonAddTack
            // 
            buttonAddTack.Location = new Point(62, 531);
            buttonAddTack.Name = "buttonAddTack";
            buttonAddTack.Size = new Size(184, 50);
            buttonAddTack.TabIndex = 3;
            buttonAddTack.Text = "Добавить задачу";
            buttonAddTack.UseVisualStyleBackColor = true;
            // 
            // buttonDelTack
            // 
            buttonDelTack.Location = new Point(499, 531);
            buttonDelTack.Name = "buttonDelTack";
            buttonDelTack.Size = new Size(184, 50);
            buttonDelTack.TabIndex = 4;
            buttonDelTack.Text = "Удалить Задачу";
            buttonDelTack.UseVisualStyleBackColor = true;
            // 
            // labelAllTack
            // 
            labelAllTack.Dock = DockStyle.Fill;
            labelAllTack.Location = new Point(3, 0);
            labelAllTack.Name = "labelAllTack";
            labelAllTack.Size = new Size(243, 46);
            labelAllTack.TabIndex = 5;
            labelAllTack.Text = "Список задач";
            labelAllTack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(labelAllTack, 0, 0);
            tableLayoutPanel1.Controls.Add(labelActTack, 1, 0);
            tableLayoutPanel1.Controls.Add(labelOverdueTack, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7048349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.295166F));
            tableLayoutPanel1.Size = new Size(748, 393);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // labelActTack
            // 
            labelActTack.AutoSize = true;
            labelActTack.Dock = DockStyle.Fill;
            labelActTack.Location = new Point(252, 0);
            labelActTack.Name = "labelActTack";
            labelActTack.Size = new Size(243, 46);
            labelActTack.TabIndex = 6;
            labelActTack.Text = "Актуальные задачи";
            labelActTack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOverdueTack
            // 
            labelOverdueTack.AutoSize = true;
            labelOverdueTack.Dock = DockStyle.Fill;
            labelOverdueTack.Location = new Point(501, 0);
            labelOverdueTack.Name = "labelOverdueTack";
            labelOverdueTack.Size = new Size(244, 46);
            labelOverdueTack.TabIndex = 7;
            labelOverdueTack.Text = "Просроченные задания";
            labelOverdueTack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNameTackAdd
            // 
            textBoxNameTackAdd.Location = new Point(62, 491);
            textBoxNameTackAdd.Name = "textBoxNameTackAdd";
            textBoxNameTackAdd.Size = new Size(184, 34);
            textBoxNameTackAdd.TabIndex = 8;
            // 
            // label1
            // 
            label1.Location = new Point(62, 445);
            label1.Name = "label1";
            label1.Size = new Size(184, 43);
            label1.TabIndex = 9;
            label1.Text = "Название задачи";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNameTackDel
            // 
            textBoxNameTackDel.Location = new Point(501, 491);
            textBoxNameTackDel.Name = "textBoxNameTackDel";
            textBoxNameTackDel.Size = new Size(184, 34);
            textBoxNameTackDel.TabIndex = 10;
            // 
            // label2
            // 
            label2.Location = new Point(499, 445);
            label2.Name = "label2";
            label2.Size = new Size(184, 43);
            label2.TabIndex = 11;
            label2.Text = "Название задачи";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 603);
            Controls.Add(label2);
            Controls.Add(textBoxNameTackDel);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonDelTack);
            Controls.Add(buttonAddTack);
            Controls.Add(textBoxNameTackAdd);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Плантровщик задач";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem acToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button buttonAddTack;
        private Button buttonDelTack;
        private Label labelAllTack;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelActTack;
        private Label labelOverdueTack;
        private TextBox textBoxNameTackAdd;
        private Label label1;
        private TextBox textBoxNameTackDel;
        private Label label2;
    }
}
