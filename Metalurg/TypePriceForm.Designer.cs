﻿namespace Metalurg
{
    partial class TypePriceForm
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(315, 75);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(551, 75);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Создать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(315, 269);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(276, 289);
            listBox1.TabIndex = 5;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // TypePriceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 309);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "TypePriceForm";
            Text = "TypePriceForm";
            Load += TypePriceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
    }
}