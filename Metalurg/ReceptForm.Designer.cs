namespace Metalurg
{
    partial class ReceptForm
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
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            receptProductBindingSource = new BindingSource(components);
            receptDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)receptProductBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(309, 23);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(489, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(327, 21);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(80, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { receptDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn, valueDataGridViewTextBoxColumn });
            dataGridView1.DataSource = receptProductBindingSource;
            dataGridView1.Location = new Point(12, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 214);
            dataGridView1.TabIndex = 4;
            // 
            // receptProductBindingSource
            // 
            receptProductBindingSource.DataSource = typeof(global::Model.Recept_Product);
            // 
            // receptDataGridViewTextBoxColumn
            // 
            receptDataGridViewTextBoxColumn.DataPropertyName = "Recept";
            receptDataGridViewTextBoxColumn.HeaderText = "Recept";
            receptDataGridViewTextBoxColumn.Name = "receptDataGridViewTextBoxColumn";
            receptDataGridViewTextBoxColumn.ReadOnly = true;
            receptDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.Width = 600;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            valueDataGridViewTextBoxColumn.HeaderText = "Value";
            valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // ReceptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "ReceptForm";
            Text = "ReceptForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)receptProductBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn receptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private BindingSource receptProductBindingSource;
    }
}