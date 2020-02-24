namespace DocumentsNew
{
    partial class FindGood
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddGoodToDocButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.AddNewGoodButton = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.goodNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 67);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(282, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddGoodToDocButton
            // 
            this.AddGoodToDocButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddGoodToDocButton.Location = new System.Drawing.Point(102, 239);
            this.AddGoodToDocButton.Name = "AddGoodToDocButton";
            this.AddGoodToDocButton.Size = new System.Drawing.Size(75, 23);
            this.AddGoodToDocButton.TabIndex = 1;
            this.AddGoodToDocButton.Text = "ОК";
            this.AddGoodToDocButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(183, 239);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddNewGoodButton
            // 
            this.AddNewGoodButton.Location = new System.Drawing.Point(18, 22);
            this.AddNewGoodButton.Name = "AddNewGoodButton";
            this.AddNewGoodButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewGoodButton.TabIndex = 3;
            this.AddNewGoodButton.Text = "Создать";
            this.AddNewGoodButton.UseVisualStyleBackColor = true;
            this.AddNewGoodButton.Click += new System.EventHandler(this.AddNewGoodButton_Click);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodBindingSource
            // 
            this.goodBindingSource.DataSource = typeof(DocumentsNew.Good);
            // 
            // goodBindingSource1
            // 
            this.goodBindingSource1.DataSource = typeof(DocumentsNew.Good);
            // 
            // FindGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewGoodButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.AddGoodToDocButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FindGood";
            this.Text = "FindGood";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddGoodToDocButton;
        private System.Windows.Forms.Button cancelButton;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource goodBindingSource;
        private System.Windows.Forms.BindingSource goodBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddNewGoodButton;
    }
}