namespace HomeWork28_1
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
            labelResult = new Label();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.FlatStyle = FlatStyle.System;
            labelResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(26, 33);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(909, 188);
            labelResult.TabIndex = 0;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            labelResult.MouseClick += label1_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 258);
            Controls.Add(labelResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label labelResult;
    }
}
