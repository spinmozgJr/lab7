namespace lab7
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
            this.addInformationButton = new System.Windows.Forms.Button();
            this.deleteInformationButton = new System.Windows.Forms.Button();
            this.clearInformationButton = new System.Windows.Forms.Button();
            this.saveDBButton = new System.Windows.Forms.Button();
            this.loadDBButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.columnOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addInformationButton
            // 
            this.addInformationButton.Location = new System.Drawing.Point(12, 414);
            this.addInformationButton.Name = "addInformationButton";
            this.addInformationButton.Size = new System.Drawing.Size(94, 29);
            this.addInformationButton.TabIndex = 1;
            this.addInformationButton.Text = "Добавить";
            this.addInformationButton.UseVisualStyleBackColor = true;
            this.addInformationButton.Click += new System.EventHandler(this.addInformationButton_Click);
            // 
            // deleteInformationButton
            // 
            this.deleteInformationButton.Location = new System.Drawing.Point(112, 414);
            this.deleteInformationButton.Name = "deleteInformationButton";
            this.deleteInformationButton.Size = new System.Drawing.Size(94, 29);
            this.deleteInformationButton.TabIndex = 2;
            this.deleteInformationButton.Text = "Удалить";
            this.deleteInformationButton.UseVisualStyleBackColor = true;
            this.deleteInformationButton.Click += new System.EventHandler(this.deleteInformationButton_Click);
            // 
            // clearInformationButton
            // 
            this.clearInformationButton.Location = new System.Drawing.Point(212, 414);
            this.clearInformationButton.Name = "clearInformationButton";
            this.clearInformationButton.Size = new System.Drawing.Size(94, 29);
            this.clearInformationButton.TabIndex = 3;
            this.clearInformationButton.Text = "Очистить";
            this.clearInformationButton.UseVisualStyleBackColor = true;
            this.clearInformationButton.Click += new System.EventHandler(this.clearInformationButton_Click);
            // 
            // saveDBButton
            // 
            this.saveDBButton.Location = new System.Drawing.Point(594, 414);
            this.saveDBButton.Name = "saveDBButton";
            this.saveDBButton.Size = new System.Drawing.Size(94, 29);
            this.saveDBButton.TabIndex = 4;
            this.saveDBButton.Text = "Сохранить";
            this.saveDBButton.UseVisualStyleBackColor = true;
            this.saveDBButton.Click += new System.EventHandler(this.saveDBButton_Click);
            // 
            // loadDBButton
            // 
            this.loadDBButton.Location = new System.Drawing.Point(694, 414);
            this.loadDBButton.Name = "loadDBButton";
            this.loadDBButton.Size = new System.Drawing.Size(94, 29);
            this.loadDBButton.TabIndex = 5;
            this.loadDBButton.Text = "Загрузить";
            this.loadDBButton.UseVisualStyleBackColor = true;
            this.loadDBButton.Click += new System.EventHandler(this.loadDBButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnOrderNumber,
            this.columnComment,
            this.columnPath});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(776, 333);
            this.dataGridView.TabIndex = 6;
            // 
            // columnOrderNumber
            // 
            this.columnOrderNumber.HeaderText = "№";
            this.columnOrderNumber.MinimumWidth = 6;
            this.columnOrderNumber.Name = "columnOrderNumber";
            this.columnOrderNumber.Width = 50;
            // 
            // columnComment
            // 
            this.columnComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnComment.HeaderText = "Комментарий";
            this.columnComment.MinimumWidth = 6;
            this.columnComment.Name = "columnComment";
            // 
            // columnPath
            // 
            this.columnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPath.HeaderText = "Путь к файлу";
            this.columnPath.MinimumWidth = 6;
            this.columnPath.Name = "columnPath";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.loadDBButton);
            this.Controls.Add(this.saveDBButton);
            this.Controls.Add(this.clearInformationButton);
            this.Controls.Add(this.deleteInformationButton);
            this.Controls.Add(this.addInformationButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button addInformationButton;
        private Button deleteInformationButton;
        private Button clearInformationButton;
        private Button saveDBButton;
        private Button loadDBButton;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn columnOrderNumber;
        private DataGridViewTextBoxColumn columnComment;
        private DataGridViewTextBoxColumn columnPath;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}