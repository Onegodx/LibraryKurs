namespace LibraryKurs
{
    partial class Form6
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
            System.Windows.Forms.Label конечная_датаLabel;
            System.Windows.Forms.Label отметка_о_возвратеLabel;
            System.Windows.Forms.Label идентификатор_сделкиLabel;
            System.Windows.Forms.Label идентификатор_экземпляраLabel;
            System.Windows.Forms.Label идентификатор_читателяLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.kursDataSet = new LibraryKurs.KursDataSet();
            this.книжнаяСделкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книжнаяСделкаTableAdapter = new LibraryKurs.KursDataSetTableAdapters.КнижнаяСделкаTableAdapter();
            this.tableAdapterManager = new LibraryKurs.KursDataSetTableAdapters.TableAdapterManager();
            this.книжнаяСделкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.книжнаяСделкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.конечная_датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.отметка_о_возвратеCheckBox = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.читательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгаTableAdapter = new LibraryKurs.KursDataSetTableAdapters.КнигаTableAdapter();
            this.читательTableAdapter = new LibraryKurs.KursDataSetTableAdapters.ЧитательTableAdapter();
            this.экземплярBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экземплярTableAdapter = new LibraryKurs.KursDataSetTableAdapters.ЭкземплярTableAdapter();
            this.идентификатор_сделкиTextBox = new System.Windows.Forms.TextBox();
            this.книжнаяСделкаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идентификатор_экземпляраTextBox = new System.Windows.Forms.TextBox();
            this.идентификатор_читателяTextBox = new System.Windows.Forms.TextBox();
            конечная_датаLabel = new System.Windows.Forms.Label();
            отметка_о_возвратеLabel = new System.Windows.Forms.Label();
            идентификатор_сделкиLabel = new System.Windows.Forms.Label();
            идентификатор_экземпляраLabel = new System.Windows.Forms.Label();
            идентификатор_читателяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжнаяСделкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжнаяСделкаBindingNavigator)).BeginInit();
            this.книжнаяСделкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземплярBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжнаяСделкаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // конечная_датаLabel
            // 
            конечная_датаLabel.AutoSize = true;
            конечная_датаLabel.Location = new System.Drawing.Point(18, 79);
            конечная_датаLabel.Name = "конечная_датаLabel";
            конечная_датаLabel.Size = new System.Drawing.Size(83, 13);
            конечная_датаLabel.TabIndex = 3;
            конечная_датаLabel.Text = "конечная дата:";
            // 
            // отметка_о_возвратеLabel
            // 
            отметка_о_возвратеLabel.AutoSize = true;
            отметка_о_возвратеLabel.Location = new System.Drawing.Point(18, 128);
            отметка_о_возвратеLabel.Name = "отметка_о_возвратеLabel";
            отметка_о_возвратеLabel.Size = new System.Drawing.Size(111, 13);
            отметка_о_возвратеLabel.TabIndex = 5;
            отметка_о_возвратеLabel.Text = "отметка о возврате:";
            // 
            // идентификатор_сделкиLabel
            // 
            идентификатор_сделкиLabel.AutoSize = true;
            идентификатор_сделкиLabel.Location = new System.Drawing.Point(18, 34);
            идентификатор_сделкиLabel.Name = "идентификатор_сделкиLabel";
            идентификатор_сделкиLabel.Size = new System.Drawing.Size(127, 13);
            идентификатор_сделкиLabel.TabIndex = 85;
            идентификатор_сделкиLabel.Text = "идентификатор сделки:";
            // 
            // идентификатор_экземпляраLabel
            // 
            идентификатор_экземпляраLabel.AutoSize = true;
            идентификатор_экземпляраLabel.Location = new System.Drawing.Point(18, 172);
            идентификатор_экземпляраLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            идентификатор_экземпляраLabel.Name = "идентификатор_экземпляраLabel";
            идентификатор_экземпляраLabel.Size = new System.Drawing.Size(153, 13);
            идентификатор_экземпляраLabel.TabIndex = 86;
            идентификатор_экземпляраLabel.Text = "идентификатор экземпляра:";
            // 
            // идентификатор_читателяLabel
            // 
            идентификатор_читателяLabel.AutoSize = true;
            идентификатор_читателяLabel.Location = new System.Drawing.Point(18, 219);
            идентификатор_читателяLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            идентификатор_читателяLabel.Name = "идентификатор_читателяLabel";
            идентификатор_читателяLabel.Size = new System.Drawing.Size(136, 13);
            идентификатор_читателяLabel.TabIndex = 87;
            идентификатор_читателяLabel.Text = "идентификатор читателя:";
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книжнаяСделкаBindingSource
            // 
            this.книжнаяСделкаBindingSource.DataMember = "КнижнаяСделка";
            this.книжнаяСделкаBindingSource.DataSource = this.kursDataSet;
            // 
            // книжнаяСделкаTableAdapter
            // 
            this.книжнаяСделкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LibraryKurs.KursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.КнижнаяСделкаTableAdapter = this.книжнаяСделкаTableAdapter;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Читательный_ЗалTableAdapter = null;
            this.tableAdapterManager.ЭкземплярTableAdapter = null;
            // 
            // книжнаяСделкаBindingNavigator
            // 
            this.книжнаяСделкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.книжнаяСделкаBindingNavigator.BindingSource = this.книжнаяСделкаBindingSource;
            this.книжнаяСделкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.книжнаяСделкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.книжнаяСделкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.книжнаяСделкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.книжнаяСделкаBindingNavigatorSaveItem});
            this.книжнаяСделкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.книжнаяСделкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.книжнаяСделкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.книжнаяСделкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.книжнаяСделкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.книжнаяСделкаBindingNavigator.Name = "книжнаяСделкаBindingNavigator";
            this.книжнаяСделкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.книжнаяСделкаBindingNavigator.Size = new System.Drawing.Size(1112, 27);
            this.книжнаяСделкаBindingNavigator.TabIndex = 0;
            this.книжнаяСделкаBindingNavigator.Text = "bindingNavigator1";
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
            // книжнаяСделкаBindingNavigatorSaveItem
            // 
            this.книжнаяСделкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.книжнаяСделкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("книжнаяСделкаBindingNavigatorSaveItem.Image")));
            this.книжнаяСделкаBindingNavigatorSaveItem.Name = "книжнаяСделкаBindingNavigatorSaveItem";
            this.книжнаяСделкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.книжнаяСделкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.книжнаяСделкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.книжнаяСделкаBindingNavigatorSaveItem_Click);
            // 
            // конечная_датаDateTimePicker
            // 
            this.конечная_датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.книжнаяСделкаBindingSource, "конечная_дата", true));
            this.конечная_датаDateTimePicker.Location = new System.Drawing.Point(180, 79);
            this.конечная_датаDateTimePicker.Name = "конечная_датаDateTimePicker";
            this.конечная_датаDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.конечная_датаDateTimePicker.TabIndex = 4;
            // 
            // отметка_о_возвратеCheckBox
            // 
            this.отметка_о_возвратеCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.книжнаяСделкаBindingSource, "отметка_о_возврате", true));
            this.отметка_о_возвратеCheckBox.Location = new System.Drawing.Point(180, 123);
            this.отметка_о_возвратеCheckBox.Name = "отметка_о_возвратеCheckBox";
            this.отметка_о_возвратеCheckBox.Size = new System.Drawing.Size(104, 24);
            this.отметка_о_возвратеCheckBox.TabIndex = 6;
            this.отметка_о_возвратеCheckBox.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(114, 354);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 23);
            this.button7.TabIndex = 83;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 82;
            this.button6.Text = "Посаледняя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(116, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 81;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 80;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 79;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 78;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 77;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // читательBindingSource
            // 
            this.читательBindingSource.DataMember = "Читатель";
            this.читательBindingSource.DataSource = this.kursDataSet;
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
            // читательTableAdapter
            // 
            this.читательTableAdapter.ClearBeforeFill = true;
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
            // идентификатор_сделкиTextBox
            // 
            this.идентификатор_сделкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книжнаяСделкаBindingSource, "идентификатор_сделки", true));
            this.идентификатор_сделкиTextBox.Location = new System.Drawing.Point(180, 28);
            this.идентификатор_сделкиTextBox.Name = "идентификатор_сделкиTextBox";
            this.идентификатор_сделкиTextBox.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_сделкиTextBox.TabIndex = 86;
            this.идентификатор_сделкиTextBox.TextChanged += new System.EventHandler(this.идентификатор_сделкиTextBox_TextChanged);
            // 
            // книжнаяСделкаDataGridView
            // 
            this.книжнаяСделкаDataGridView.AutoGenerateColumns = false;
            this.книжнаяСделкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.книжнаяСделкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.книжнаяСделкаDataGridView.DataSource = this.книжнаяСделкаBindingSource;
            this.книжнаяСделкаDataGridView.Location = new System.Drawing.Point(397, 29);
            this.книжнаяСделкаDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.книжнаяСделкаDataGridView.Name = "книжнаяСделкаDataGridView";
            this.книжнаяСделкаDataGridView.RowHeadersWidth = 51;
            this.книжнаяСделкаDataGridView.RowTemplate.Height = 24;
            this.книжнаяСделкаDataGridView.Size = new System.Drawing.Size(672, 228);
            this.книжнаяСделкаDataGridView.TabIndex = 86;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "идентификатор_сделки";
            this.dataGridViewTextBoxColumn2.HeaderText = "идентификатор сделки";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "конечная_дата";
            this.dataGridViewTextBoxColumn5.HeaderText = "конечная_дата";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "отметка_о_возврате";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Возвращен";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "идентификатор_экземпляра";
            this.dataGridViewTextBoxColumn8.HeaderText = "идентификатор экземпляра";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "идентификатор_читателя";
            this.dataGridViewTextBoxColumn9.HeaderText = "идентификатор читателя";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // идентификатор_экземпляраTextBox
            // 
            this.идентификатор_экземпляраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книжнаяСделкаBindingSource, "идентификатор_экземпляра", true));
            this.идентификатор_экземпляраTextBox.Location = new System.Drawing.Point(180, 172);
            this.идентификатор_экземпляраTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.идентификатор_экземпляраTextBox.Name = "идентификатор_экземпляраTextBox";
            this.идентификатор_экземпляраTextBox.Size = new System.Drawing.Size(134, 20);
            this.идентификатор_экземпляраTextBox.TabIndex = 87;
            // 
            // идентификатор_читателяTextBox
            // 
            this.идентификатор_читателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книжнаяСделкаBindingSource, "идентификатор_читателя", true));
            this.идентификатор_читателяTextBox.Location = new System.Drawing.Point(180, 214);
            this.идентификатор_читателяTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.идентификатор_читателяTextBox.Name = "идентификатор_читателяTextBox";
            this.идентификатор_читателяTextBox.Size = new System.Drawing.Size(134, 20);
            this.идентификатор_читателяTextBox.TabIndex = 88;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 443);
            this.Controls.Add(идентификатор_читателяLabel);
            this.Controls.Add(this.идентификатор_читателяTextBox);
            this.Controls.Add(идентификатор_экземпляраLabel);
            this.Controls.Add(this.идентификатор_экземпляраTextBox);
            this.Controls.Add(this.книжнаяСделкаDataGridView);
            this.Controls.Add(идентификатор_сделкиLabel);
            this.Controls.Add(this.идентификатор_сделкиTextBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(отметка_о_возвратеLabel);
            this.Controls.Add(this.отметка_о_возвратеCheckBox);
            this.Controls.Add(конечная_датаLabel);
            this.Controls.Add(this.конечная_датаDateTimePicker);
            this.Controls.Add(this.книжнаяСделкаBindingNavigator);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжнаяСделкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжнаяСделкаBindingNavigator)).EndInit();
            this.книжнаяСделкаBindingNavigator.ResumeLayout(false);
            this.книжнаяСделкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экземплярBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книжнаяСделкаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource книжнаяСделкаBindingSource;
        private KursDataSetTableAdapters.КнижнаяСделкаTableAdapter книжнаяСделкаTableAdapter;
        private KursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator книжнаяСделкаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton книжнаяСделкаBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker конечная_датаDateTimePicker;
        private System.Windows.Forms.CheckBox отметка_о_возвратеCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource книгаBindingSource;
        private KursDataSetTableAdapters.КнигаTableAdapter книгаTableAdapter;
        private System.Windows.Forms.BindingSource читательBindingSource;
        private KursDataSetTableAdapters.ЧитательTableAdapter читательTableAdapter;
        private System.Windows.Forms.BindingSource экземплярBindingSource;
        private KursDataSetTableAdapters.ЭкземплярTableAdapter экземплярTableAdapter;
        private System.Windows.Forms.TextBox идентификатор_сделкиTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView книжнаяСделкаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox идентификатор_экземпляраTextBox;
        private System.Windows.Forms.TextBox идентификатор_читателяTextBox;
    }
}