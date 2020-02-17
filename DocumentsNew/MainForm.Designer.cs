namespace DocumentsNew
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DocListView = new System.Windows.Forms.DataGridView();
            this.AddDocButton = new System.Windows.Forms.Button();
            this.OpenDocButton = new System.Windows.Forms.Button();
            this.DeleteDocButton = new System.Windows.Forms.Button();
            this.GoodList = new System.Windows.Forms.Button();
            this.ShowRegButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DocListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DocListView
            // 
            this.DocListView.AllowUserToAddRows = false;
            this.DocListView.AutoGenerateColumns = false;
            this.DocListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dateTimeDataGridViewTextBoxColumn,
            this.docTypeDataGridViewTextBoxColumn});
            this.DocListView.DataSource = this.docBindingSource;
            this.DocListView.Location = new System.Drawing.Point(27, 30);
            this.DocListView.Name = "DocListView";
            this.DocListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocListView.Size = new System.Drawing.Size(345, 150);
            this.DocListView.TabIndex = 0;
            // 
            // AddDocButton
            // 
            this.AddDocButton.Location = new System.Drawing.Point(27, 211);
            this.AddDocButton.Name = "AddDocButton";
            this.AddDocButton.Size = new System.Drawing.Size(75, 23);
            this.AddDocButton.TabIndex = 1;
            this.AddDocButton.Text = "Добавить";
            this.AddDocButton.UseVisualStyleBackColor = true;
            this.AddDocButton.Click += new System.EventHandler(this.AddDocButton_Click);
            // 
            // OpenDocButton
            // 
            this.OpenDocButton.Location = new System.Drawing.Point(137, 211);
            this.OpenDocButton.Name = "OpenDocButton";
            this.OpenDocButton.Size = new System.Drawing.Size(75, 23);
            this.OpenDocButton.TabIndex = 2;
            this.OpenDocButton.Text = "Открыть";
            this.OpenDocButton.UseVisualStyleBackColor = true;
            this.OpenDocButton.Click += new System.EventHandler(this.OpenDocButton_Click);
            // 
            // DeleteDocButton
            // 
            this.DeleteDocButton.Location = new System.Drawing.Point(241, 211);
            this.DeleteDocButton.Name = "DeleteDocButton";
            this.DeleteDocButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteDocButton.TabIndex = 3;
            this.DeleteDocButton.Text = "Удалить";
            this.DeleteDocButton.UseVisualStyleBackColor = true;
            this.DeleteDocButton.Click += new System.EventHandler(this.DeleteDocButton_Click);
            // 
            // GoodList
            // 
            this.GoodList.Location = new System.Drawing.Point(27, 257);
            this.GoodList.Name = "GoodList";
            this.GoodList.Size = new System.Drawing.Size(154, 23);
            this.GoodList.TabIndex = 4;
            this.GoodList.Text = "Список комплектующих";
            this.GoodList.UseVisualStyleBackColor = true;
            this.GoodList.Click += new System.EventHandler(this.GoodList_Click);
            // 
            // ShowRegButton
            // 
            this.ShowRegButton.Location = new System.Drawing.Point(203, 257);
            this.ShowRegButton.Name = "ShowRegButton";
            this.ShowRegButton.Size = new System.Drawing.Size(132, 23);
            this.ShowRegButton.TabIndex = 5;
            this.ShowRegButton.Text = "Показать записи";
            this.ShowRegButton.UseVisualStyleBackColor = true;
            this.ShowRegButton.Click += new System.EventHandler(this.ShowRegButton_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Код";
            this.Id.Name = "Id";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // docTypeDataGridViewTextBoxColumn
            // 
            this.docTypeDataGridViewTextBoxColumn.DataPropertyName = "DocType";
            this.docTypeDataGridViewTextBoxColumn.HeaderText = "Тип документа";
            this.docTypeDataGridViewTextBoxColumn.Name = "docTypeDataGridViewTextBoxColumn";
            // 
            // docBindingSource
            // 
            this.docBindingSource.DataSource = typeof(DocumentsNew.Doc);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.ShowRegButton);
            this.Controls.Add(this.GoodList);
            this.Controls.Add(this.DeleteDocButton);
            this.Controls.Add(this.OpenDocButton);
            this.Controls.Add(this.AddDocButton);
            this.Controls.Add(this.DocListView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DocListView;
        private System.Windows.Forms.BindingSource docBindingSource;
        private System.Windows.Forms.Button AddDocButton;
        private System.Windows.Forms.Button OpenDocButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DeleteDocButton;
        private System.Windows.Forms.Button GoodList;
        private System.Windows.Forms.Button ShowRegButton;
    }
}

