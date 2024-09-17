namespace LibraryKurs
{
    partial class Form3
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
            System.Windows.Forms.Label состояниеLabel;
            System.Windows.Forms.Label статусLabel;
            System.Windows.Forms.Label идентификатор_экземпляраLabel;
            System.Windows.Forms.Label идентификатор_книгиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kursDataSet = new LibraryKurs.KursDataSet();
            this.экземплярBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экземплярTableAdapter = new LibraryKurs.KursDataSetTableAdapters.ЭкземплярTableAdapter();
            this.tableAdapterManager = new LibraryKurs.KursDataSetTableAdapters.TableAdapterManager();
            this.экземплярBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.экземплярBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.состояниеTextBox = new System.Windows.Forms.TextBox();
            this.статусCheckBox = new System.Windows.Forms.CheckBox();
            this.книгаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгаTableAdapter = new LibraryKurs.KursDataSetTableAdapters.КнигаTableAdapter();
            this.идентификатор_экземпляраTextBox = new System.Windows.Forms.TextBox();
            this.экземплярDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идентификатор_книгиTextBox = new System.Windows.Forms.TextBox();
            состояниеLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            идентификатор_экземпляраLabel = new System.Windows.Forms.Label();
            идентификатор_книгиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземплярBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземплярBindingNavigator)).BeginInit();
            this.экземплярBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземплярDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // состояниеLabel
            // 
            состояниеLabel.AutoSize = true;
            состояниеLabel.Location = new System.Drawing.Point(20, 80);
            состояниеLabel.Name = "состояниеLabel";
            состояниеLabel.Size = new System.Drawing.Size(63, 13);
            состояниеLabel.TabIndex = 64;
            состояниеLabel.Text = "состояние:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(20, 118);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(43, 13);
            статусLabel.TabIndex = 65;
            статусLabel.Text = "статус:";
            // 
            // идентификатор_экземпляраLabel
            // 
            идентификатор_экземпляраLabel.AutoSize = true;
            идентификатор_экземпляраLabel.Location = new System.Drawing.Point(20, 38);
            идентификатор_экземпляраLabel.Name = "идентификатор_экземпляраLabel";
            идентификатор_экземпляраLabel.Size = new System.Drawing.Size(153, 13);
            идентификатор_экземпляраLabel.TabIndex = 68;
            идентификатор_экземпляраLabel.Text = "идентификатор экземпляра:";
            // 
            // идентификатор_книгиLabel
            // 
            идентификатор_книгиLabel.AutoSize = true;
            идентификатор_книгиLabel.Location = new System.Drawing.Point(20, 158);
            идентификатор_книгиLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            идентификатор_книгиLabel.Name = "идентификатор_книгиLabel";
            идентификатор_книгиLabel.Size = new System.Drawing.Size(120, 13);
            идентификатор_книгиLabel.TabIndex = 69;
            идентификатор_книгиLabel.Text = "идентификатор книги:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(114, 271);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 23);
            this.button7.TabIndex = 62;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 61;
            this.button6.Text = "Посаледняя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(116, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 60;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 59;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // экземплярBindingSource
            // 
            this.экземплярBindingSource.DataMember = "Экземпляр";
            this.экземплярBindingSource.DataSource = this.kursDataSet;
            // 
            // экземплярTableAdapter
            // 
            this.экземплярTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LibraryKurs.KursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.КнижнаяСделкаTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Читательный_ЗалTableAdapter = null;
            this.tableAdapterManager.ЭкземплярTableAdapter = this.экземплярTableAdapter;
            // 
            // экземплярBindingNavigator
            // 
            this.экземплярBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.экземплярBindingNavigator.BindingSource = this.экземплярBindingSource;
            this.экземплярBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.экземплярBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.экземплярBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.экземплярBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.экземплярBindingNavigatorSaveItem});
            this.экземплярBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.экземплярBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.экземплярBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.экземплярBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.экземплярBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.экземплярBindingNavigator.Name = "экземплярBindingNavigator";
            this.экземплярBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.экземплярBindingNavigator.Size = new System.Drawing.Size(918, 27);
            this.экземплярBindingNavigator.TabIndex = 63;
            this.экземплярBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // экземплярBindingNavigatorSaveItem
            // 
            this.экземплярBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.экземплярBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("экземплярBindingNavigatorSaveItem.Image")));
            this.экземплярBindingNavigatorSaveItem.Name = "экземплярBindingNavigatorSaveItem";
            this.экземплярBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.экземплярBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.экземплярBindingNavigatorSaveItem.Click += new System.EventHandler(this.экземплярBindingNavigatorSaveItem_Click);
            // 
            // состояниеTextBox
            // 
            this.состояниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экземплярBindingSource, "состояние", true));
            this.состояниеTextBox.Location = new System.Drawing.Point(180, 80);
            this.состояниеTextBox.Name = "состояниеTextBox";
            this.состояниеTextBox.Size = new System.Drawing.Size(100, 20);
            this.состояниеTextBox.TabIndex = 65;
            // 
            // статусCheckBox
            // 
            this.статусCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.экземплярBindingSource, "статус", true));
            this.статусCheckBox.Location = new System.Drawing.Point(180, 113);
            this.статусCheckBox.Name = "статусCheckBox";
            this.статусCheckBox.Size = new System.Drawing.Size(19, 24);
            this.статусCheckBox.TabIndex = 66;
            this.статусCheckBox.UseVisualStyleBackColor = true;
            // 
            // книгаBindingSource
            // 
            this.книгаBindingSource.DataMember = "Книга";
            this.книгаBindingSource.DataSource = this.kursDataSet;
            // 
            // книгаTableAdapter
            // 
            this.книгаTableAdapter.ClearBeforeFill = true;
            // 
            // идентификатор_экземпляраTextBox
            // 
            this.идентификатор_экземпляраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экземплярBindingSource, "идентификатор_экземпляра", true));
            this.идентификатор_экземпляраTextBox.Location = new System.Drawing.Point(180, 38);
            this.идентификатор_экземпляраTextBox.Name = "идентификатор_экземпляраTextBox";
            this.идентификатор_экземпляраTextBox.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_экземпляраTextBox.TabIndex = 69;
            // 
            // экземплярDataGridView
            // 
            this.экземплярDataGridView.AutoGenerateColumns = false;
            this.экземплярDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.экземплярDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.экземплярDataGridView.DataSource = this.экземплярBindingSource;
            this.экземплярDataGridView.Location = new System.Drawing.Point(348, 38);
            this.экземплярDataGridView.Name = "экземплярDataGridView";
            this.экземплярDataGridView.RowHeadersWidth = 51;
            this.экземплярDataGridView.Size = new System.Drawing.Size(544, 193);
            this.экземплярDataGridView.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "идентификатор_экземпляра";
            this.dataGridViewTextBoxColumn2.HeaderText = "идентификатор экземпляра";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "состояние";
            this.dataGridViewTextBoxColumn4.HeaderText = "состояние";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "статус";
            this.dataGridViewCheckBoxColumn1.HeaderText = "статус";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "идентификатор_книги";
            this.dataGridViewTextBoxColumn5.HeaderText = "идентификатор книги";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // идентификатор_книгиTextBox
            // 
            this.идентификатор_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.экземплярBindingSource, "идентификатор_книги", true));
            this.идентификатор_книгиTextBox.Location = new System.Drawing.Point(180, 158);
            this.идентификатор_книгиTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.идентификатор_книгиTextBox.Name = "идентификатор_книгиTextBox";
            this.идентификатор_книгиTextBox.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_книгиTextBox.TabIndex = 70;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 382);
            this.Controls.Add(идентификатор_книгиLabel);
            this.Controls.Add(this.идентификатор_книгиTextBox);
            this.Controls.Add(this.экземплярDataGridView);
            this.Controls.Add(идентификатор_экземпляраLabel);
            this.Controls.Add(this.идентификатор_экземпляраTextBox);
            this.Controls.Add(статусLabel);
            this.Controls.Add(this.статусCheckBox);
            this.Controls.Add(состояниеLabel);
            this.Controls.Add(this.состояниеTextBox);
            this.Controls.Add(this.экземплярBindingNavigator);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземплярBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземплярBindingNavigator)).EndInit();
            this.экземплярBindingNavigator.ResumeLayout(false);
            this.экземплярBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземплярDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource экземплярBindingSource;
        private KursDataSetTableAdapters.ЭкземплярTableAdapter экземплярTableAdapter;
        private KursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator экземплярBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton экземплярBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox состояниеTextBox;
        private System.Windows.Forms.CheckBox статусCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource книгаBindingSource;
        private KursDataSetTableAdapters.КнигаTableAdapter книгаTableAdapter;
        private System.Windows.Forms.TextBox идентификатор_экземпляраTextBox;
        private System.Windows.Forms.DataGridView экземплярDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox идентификатор_книгиTextBox;
    }
}