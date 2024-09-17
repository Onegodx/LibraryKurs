namespace LibraryKurs
{
    partial class Form4
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
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label описаниеLabel1;
            System.Windows.Forms.Label идентификатор_залаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.kursDataSet = new LibraryKurs.KursDataSet();
            this.читательный_ЗалBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читательный_ЗалTableAdapter = new LibraryKurs.KursDataSetTableAdapters.Читательный_ЗалTableAdapter();
            this.tableAdapterManager = new LibraryKurs.KursDataSetTableAdapters.TableAdapterManager();
            this.читательный_ЗалBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.читательный_ЗалBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.читаттель_и_залBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читаттель_и_залTableAdapter = new LibraryKurs.KursDataSetTableAdapters.Читаттель_и_залTableAdapter();
            this.читаттель_и_залDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.читательный_ЗалDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идентификатор_залаTextBox = new System.Windows.Forms.TextBox();
            названиеLabel = new System.Windows.Forms.Label();
            описаниеLabel1 = new System.Windows.Forms.Label();
            идентификатор_залаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательный_ЗалBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательный_ЗалBindingNavigator)).BeginInit();
            this.читательный_ЗалBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читаттель_и_залBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читаттель_и_залDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательный_ЗалDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(18, 84);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(58, 13);
            названиеLabel.TabIndex = 4;
            названиеLabel.Text = "название:";
            // 
            // описаниеLabel1
            // 
            описаниеLabel1.AutoSize = true;
            описаниеLabel1.Location = new System.Drawing.Point(18, 127);
            описаниеLabel1.Name = "описаниеLabel1";
            описаниеLabel1.Size = new System.Drawing.Size(58, 13);
            описаниеLabel1.TabIndex = 8;
            описаниеLabel1.Text = "описание:";
            // 
            // идентификатор_залаLabel
            // 
            идентификатор_залаLabel.AutoSize = true;
            идентификатор_залаLabel.Location = new System.Drawing.Point(18, 43);
            идентификатор_залаLabel.Name = "идентификатор_залаLabel";
            идентификатор_залаLabel.Size = new System.Drawing.Size(115, 13);
            идентификатор_залаLabel.TabIndex = 69;
            идентификатор_залаLabel.Text = "идентификатор зала:";
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // читательный_ЗалBindingSource
            // 
            this.читательный_ЗалBindingSource.DataMember = "Читательный Зал";
            this.читательный_ЗалBindingSource.DataSource = this.kursDataSet;
            // 
            // читательный_ЗалTableAdapter
            // 
            this.читательный_ЗалTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LibraryKurs.KursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.КнижнаяСделкаTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Читательный_ЗалTableAdapter = this.читательный_ЗалTableAdapter;
            this.tableAdapterManager.ЭкземплярTableAdapter = null;
            // 
            // читательный_ЗалBindingNavigator
            // 
            this.читательный_ЗалBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.читательный_ЗалBindingNavigator.BindingSource = this.читательный_ЗалBindingSource;
            this.читательный_ЗалBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.читательный_ЗалBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.читательный_ЗалBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.читательный_ЗалBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.читательный_ЗалBindingNavigatorSaveItem});
            this.читательный_ЗалBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.читательный_ЗалBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.читательный_ЗалBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.читательный_ЗалBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.читательный_ЗалBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.читательный_ЗалBindingNavigator.Name = "читательный_ЗалBindingNavigator";
            this.читательный_ЗалBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.читательный_ЗалBindingNavigator.Size = new System.Drawing.Size(955, 27);
            this.читательный_ЗалBindingNavigator.TabIndex = 0;
            this.читательный_ЗалBindingNavigator.Text = "bindingNavigator1";
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
            // читательный_ЗалBindingNavigatorSaveItem
            // 
            this.читательный_ЗалBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.читательный_ЗалBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("читательный_ЗалBindingNavigatorSaveItem.Image")));
            this.читательный_ЗалBindingNavigatorSaveItem.Name = "читательный_ЗалBindingNavigatorSaveItem";
            this.читательный_ЗалBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.читательный_ЗалBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.читательный_ЗалBindingNavigatorSaveItem.Click += new System.EventHandler(this.читательный_ЗалBindingNavigatorSaveItem_Click);
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательный_ЗалBindingSource, "название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(139, 84);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.названиеTextBox.TabIndex = 5;
            // 
            // описаниеTextBox1
            // 
            this.описаниеTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательный_ЗалBindingSource, "описание", true));
            this.описаниеTextBox1.Location = new System.Drawing.Point(139, 127);
            this.описаниеTextBox1.Name = "описаниеTextBox1";
            this.описаниеTextBox1.Size = new System.Drawing.Size(100, 20);
            this.описаниеTextBox1.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(108, 274);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 23);
            this.button7.TabIndex = 69;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 68;
            this.button6.Text = "Посаледняя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(110, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 67;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 66;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 65;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 64;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // читаттель_и_залBindingSource
            // 
            this.читаттель_и_залBindingSource.DataMember = "Читаттель и зал";
            this.читаттель_и_залBindingSource.DataSource = this.kursDataSet;
            // 
            // читаттель_и_залTableAdapter
            // 
            this.читаттель_и_залTableAdapter.ClearBeforeFill = true;
            // 
            // читаттель_и_залDataGridView
            // 
            this.читаттель_и_залDataGridView.AutoGenerateColumns = false;
            this.читаттель_и_залDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.читаттель_и_залDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.читаттель_и_залDataGridView.DataSource = this.читаттель_и_залBindingSource;
            this.читаттель_и_залDataGridView.Location = new System.Drawing.Point(339, 211);
            this.читаттель_и_залDataGridView.Name = "читаттель_и_залDataGridView";
            this.читаттель_и_залDataGridView.RowHeadersWidth = 51;
            this.читаттель_и_залDataGridView.Size = new System.Drawing.Size(517, 220);
            this.читаттель_и_залDataGridView.TabIndex = 69;
            this.читаттель_и_залDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.читаттель_и_залDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "идентификатор_зала";
            this.dataGridViewTextBoxColumn2.HeaderText = "идентификатор зала";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "название";
            this.dataGridViewTextBoxColumn3.HeaderText = "название";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "идентификатор читателя";
            this.dataGridViewTextBoxColumn5.HeaderText = "идентификатор читателя";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "полное_имя";
            this.dataGridViewTextBoxColumn6.HeaderText = "полное_имя";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // читательный_ЗалDataGridView
            // 
            this.читательный_ЗалDataGridView.AutoGenerateColumns = false;
            this.читательный_ЗалDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.читательный_ЗалDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.читательный_ЗалDataGridView.DataSource = this.читательный_ЗалBindingSource;
            this.читательный_ЗалDataGridView.Location = new System.Drawing.Point(386, 12);
            this.читательный_ЗалDataGridView.Name = "читательный_ЗалDataGridView";
            this.читательный_ЗалDataGridView.RowHeadersWidth = 51;
            this.читательный_ЗалDataGridView.Size = new System.Drawing.Size(415, 168);
            this.читательный_ЗалDataGridView.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "идентификатор_зала";
            this.dataGridViewTextBoxColumn7.HeaderText = "идентификатор зала";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "название";
            this.dataGridViewTextBoxColumn8.HeaderText = "название";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "описание";
            this.dataGridViewTextBoxColumn9.HeaderText = "описание";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // идентификатор_залаTextBox
            // 
            this.идентификатор_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательный_ЗалBindingSource, "идентификатор_зала", true));
            this.идентификатор_залаTextBox.Location = new System.Drawing.Point(139, 43);
            this.идентификатор_залаTextBox.Name = "идентификатор_залаTextBox";
            this.идентификатор_залаTextBox.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_залаTextBox.TabIndex = 70;
            this.идентификатор_залаTextBox.TextChanged += new System.EventHandler(this.идентификатор_залаTextBox_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 524);
            this.Controls.Add(идентификатор_залаLabel);
            this.Controls.Add(this.идентификатор_залаTextBox);
            this.Controls.Add(this.читательный_ЗалDataGridView);
            this.Controls.Add(this.читаттель_и_залDataGridView);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(описаниеLabel1);
            this.Controls.Add(this.описаниеTextBox1);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(this.читательный_ЗалBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательный_ЗалBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательный_ЗалBindingNavigator)).EndInit();
            this.читательный_ЗалBindingNavigator.ResumeLayout(false);
            this.читательный_ЗалBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читаттель_и_залBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читаттель_и_залDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательный_ЗалDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource читательный_ЗалBindingSource;
        private KursDataSetTableAdapters.Читательный_ЗалTableAdapter читательный_ЗалTableAdapter;
        private KursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator читательный_ЗалBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton читательный_ЗалBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource читаттель_и_залBindingSource;
        private KursDataSetTableAdapters.Читаттель_и_залTableAdapter читаттель_и_залTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView читаттель_и_залDataGridView;
        private System.Windows.Forms.DataGridView читательный_ЗалDataGridView;
        private System.Windows.Forms.TextBox идентификатор_залаTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}