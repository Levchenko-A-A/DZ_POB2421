namespace HomeWork28_3
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
            TreeNode treeNode1 = new TreeNode("Триммеры");
            TreeNode treeNode2 = new TreeNode("Газонокосилки");
            TreeNode treeNode3 = new TreeNode("Аэраторы");
            TreeNode treeNode4 = new TreeNode("Техника для сада", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Котлы");
            TreeNode treeNode6 = new TreeNode("Насосы");
            TreeNode treeNode7 = new TreeNode("Фильтры");
            TreeNode treeNode8 = new TreeNode("Водоснабжение, фильтрация и отопление", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Сучкорезы");
            TreeNode treeNode10 = new TreeNode("Секаторы");
            TreeNode treeNode11 = new TreeNode("Бензоинструмент");
            TreeNode treeNode12 = new TreeNode("Инструменты", new TreeNode[] { treeNode9, treeNode10, treeNode11 });
            TreeNode treeNode13 = new TreeNode("Подставки");
            TreeNode treeNode14 = new TreeNode("Дачный гарнитур");
            TreeNode treeNode15 = new TreeNode("Мебель", new TreeNode[] { treeNode13, treeNode14 });
            TreeNode treeNode16 = new TreeNode("Садовый инструмент и инвентарь", new TreeNode[] { treeNode12, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Садовая техника", new TreeNode[] { treeNode4, treeNode8, treeNode16 });
            treeViewGardenEquipment = new TreeView();
            button = new Button();
            button1 = new Button();
            textBoxText = new TextBox();
            buttonAdd = new Button();
            buttonSub = new Button();
            SuspendLayout();
            // 
            // treeViewGardenEquipment
            // 
            treeViewGardenEquipment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            treeViewGardenEquipment.Location = new Point(12, 12);
            treeViewGardenEquipment.Name = "treeViewGardenEquipment";
            treeNode1.Name = "Узел4";
            treeNode1.Text = "Триммеры";
            treeNode2.Name = "Узел5";
            treeNode2.Text = "Газонокосилки";
            treeNode3.Name = "Узел6";
            treeNode3.Text = "Аэраторы";
            treeNode4.Name = "Узел1";
            treeNode4.Text = "Техника для сада";
            treeNode5.Name = "Узел7";
            treeNode5.Text = "Котлы";
            treeNode6.Name = "Узел8";
            treeNode6.Text = "Насосы";
            treeNode7.Name = "Узел9";
            treeNode7.Text = "Фильтры";
            treeNode8.Name = "Узел2";
            treeNode8.Text = "Водоснабжение, фильтрация и отопление";
            treeNode9.Name = "Узел12";
            treeNode9.Text = "Сучкорезы";
            treeNode10.Name = "Узел13";
            treeNode10.Text = "Секаторы";
            treeNode11.Name = "Узел14";
            treeNode11.Text = "Бензоинструмент";
            treeNode12.Name = "Узел10";
            treeNode12.Text = "Инструменты";
            treeNode13.Name = "Узел15";
            treeNode13.Text = "Подставки";
            treeNode14.Name = "Узел16";
            treeNode14.Text = "Дачный гарнитур";
            treeNode15.Name = "Узел11";
            treeNode15.Text = "Мебель";
            treeNode16.Name = "Узел3";
            treeNode16.Text = "Садовый инструмент и инвентарь";
            treeNode17.Name = "MainRoot";
            treeNode17.Text = "Садовая техника";
            treeViewGardenEquipment.Nodes.AddRange(new TreeNode[] { treeNode17 });
            treeViewGardenEquipment.Size = new Size(523, 376);
            treeViewGardenEquipment.TabIndex = 0;
            // 
            // button
            // 
            button.Location = new Point(12, 462);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 1;
            button.Text = "Развернуть";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(112, 462);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Свернуть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(12, 394);
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(523, 27);
            textBoxText.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 427);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(112, 427);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(94, 29);
            buttonSub.TabIndex = 6;
            buttonSub.Text = "Удалить";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 592);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxText);
            Controls.Add(button1);
            Controls.Add(button);
            Controls.Add(treeViewGardenEquipment);
            Name = "Form1";
            Text = "Садовая техника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewGardenEquipment;
        private Button button;
        private Button button1;
        private TextBox textBoxText;
        private Button buttonAdd;
        private Button buttonSub;
    }
}
