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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DocListView = new System.Windows.Forms.DataGridView();
            this.AddDocButton = new System.Windows.Forms.Button();
            this.OpenDocButton = new System.Windows.Forms.Button();
            this.DeleteDocButton = new System.Windows.Forms.Button();
            this.GoodList = new System.Windows.Forms.Button();
            this.ShowRegButton = new System.Windows.Forms.Button();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.IdOlvColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DocListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
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
            this.DocListView.Location = new System.Drawing.Point(15, 406);
            this.DocListView.Name = "DocListView";
            this.DocListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocListView.Size = new System.Drawing.Size(345, 150);
            this.DocListView.TabIndex = 0;
            this.DocListView.Visible = false;
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
            this.DeleteDocButton.Visible = false;
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
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.IdOlvColumn);
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdOlvColumn,
            this.olvColumn1,
            this.olvColumn3});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.HideSelection = false;
            this.objectListView1.Location = new System.Drawing.Point(27, 12);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(330, 186);
            this.objectListView1.TabIndex = 6;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // IdOlvColumn
            // 
            this.IdOlvColumn.AspectName = "Id";
            this.IdOlvColumn.Groupable = false;
            this.IdOlvColumn.Text = "Код";
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "DateTime";
            this.olvColumn1.Groupable = false;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Дата";
            this.olvColumn1.Width = 125;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "DocType";
            this.olvColumn3.Groupable = false;
            this.olvColumn3.Text = "Тип документа";
            this.olvColumn3.Width = 132;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectListView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn IdOlvColumn;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.Label label1;
    }
}

