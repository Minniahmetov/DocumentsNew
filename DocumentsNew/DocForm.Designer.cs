﻿namespace DocumentsNew
{
    partial class DocForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TablePartGrid = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.RowDeleteButton = new System.Windows.Forms.Button();
            this.findGood = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tablePartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablePartStringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePartStringBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Реквизиты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип документа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Код";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Поступление",
            "Списание"});
            this.comboBox1.Location = new System.Drawing.Point(255, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(318, 385);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(399, 385);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // TablePartGrid
            // 
            this.TablePartGrid.AllowUserToAddRows = false;
            this.TablePartGrid.AllowUserToDeleteRows = false;
            this.TablePartGrid.AllowUserToResizeRows = false;
            this.TablePartGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.TablePartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.GoodName,
            this.quantity,
            this.Balance,
            this.GoodId});
            this.TablePartGrid.Location = new System.Drawing.Point(13, 202);
            this.TablePartGrid.Name = "TablePartGrid";
            this.TablePartGrid.Size = new System.Drawing.Size(461, 150);
            this.TablePartGrid.TabIndex = 3;
            this.TablePartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.TablePartGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablePartGrid_CellValueChanged);
            this.TablePartGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.TablePartGrid_EditingControlShowing);
            this.TablePartGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.TablePartGrid_RowsAdded);
            this.TablePartGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.TablePartGrid_RowsRemoved);
            // 
            // Serial
            // 
            this.Serial.HeaderText = "№";
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            // 
            // GoodName
            // 
            this.GoodName.HeaderText = "Наименование";
            this.GoodName.Name = "GoodName";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.Name = "quantity";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Остаток";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // GoodId
            // 
            this.GoodId.HeaderText = "GoodId";
            this.GoodId.Name = "GoodId";
            this.GoodId.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить строку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RowDeleteButton
            // 
            this.RowDeleteButton.Location = new System.Drawing.Point(154, 156);
            this.RowDeleteButton.Name = "RowDeleteButton";
            this.RowDeleteButton.Size = new System.Drawing.Size(117, 23);
            this.RowDeleteButton.TabIndex = 5;
            this.RowDeleteButton.Text = "Удалить строку";
            this.RowDeleteButton.UseVisualStyleBackColor = true;
            this.RowDeleteButton.Click += new System.EventHandler(this.RowDeleteButton_Click);
            // 
            // findGood
            // 
            this.findGood.Location = new System.Drawing.Point(298, 155);
            this.findGood.Name = "findGood";
            this.findGood.Size = new System.Drawing.Size(150, 23);
            this.findGood.TabIndex = 6;
            this.findGood.Text = "Подбор комплектующей";
            this.findGood.UseVisualStyleBackColor = true;
            this.findGood.Click += new System.EventHandler(this.findGood_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 423);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(461, 188);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tablePartBindingSource
            // 
            this.tablePartBindingSource.DataSource = typeof(DocumentsNew.TablePart);
            // 
            // tablePartStringBindingSource
            // 
            this.tablePartStringBindingSource.DataSource = typeof(DocumentsNew.TablePartString);
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 645);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.findGood);
            this.Controls.Add(this.RowDeleteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablePartGrid);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "DocForm";
            this.Text = "DocForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePartStringBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.ComboBox comboBox1;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CancelButton;
        protected internal System.Windows.Forms.DataGridView TablePartGrid;
        private System.Windows.Forms.BindingSource tablePartBindingSource;
        private System.Windows.Forms.BindingSource tablePartStringBindingSource;
        protected internal System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RowDeleteButton;
        private System.Windows.Forms.Button findGood;
        private System.Windows.Forms.TextBox textBox2;
    }
}