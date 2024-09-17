namespace LibraryKurs
{
    partial class Form5
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
            System.Windows.Forms.Label полное_имяLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label идентификатор_читателяLabel;
            System.Windows.Forms.Label идентификатор_залаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.kursDataSet = new LibraryKurs.KursDataSet();
            this.читательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читательTableAdapter = new LibraryKurs.KursDataSetTableAdapters.ЧитательTableAdapter();
            this.tableAdapterManager = new LibraryKurs.KursDataSetTableAdapters.TableAdapterManager();
            this.читательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.читательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.полное_имяTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.читательныйЗалBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.идентификатор_читателяTextBox = new System.Windows.Forms.TextBox();
            this.читаттельИЗалBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читаттель_и_залTableAdapter = new LibraryKurs.KursDataSetTableAdapters.Читаттель_и_залTableAdapter();
            this.читательный_ЗалTableAdapter = new LibraryKurs.KursDataSetTableAdapters.Читательный_ЗалTableAdapter();
            this.читательDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.читательныйЗалBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.идентификатор_залаTextBox = new System.Windows.Forms.TextBox();
            полное_имяLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            идентификатор_читателяLabel = new System.Windows.Forms.Label();
            идентификатор_залаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательBindingNavigator)).BeginInit();
            this.читательBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читаттельИЗалBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // полное_имяLabel
            // 
            полное_имяLabel.AutoSize = true;
            полное_имяLabel.Location = new System.Drawing.Point(24, 77);
            полное_имяLabel.Name = "полное_имяLabel";
            полное_имяLabel.Size = new System.Drawing.Size(69, 13);
            полное_имяLabel.TabIndex = 76;
            полное_имяLabel.Text = "полное имя:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(24, 116);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(53, 13);
            телефонLabel.TabIndex = 77;
            телефонLabel.Text = "телефон:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(24, 158);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(40, 13);
            адресLabel.TabIndex = 78;
            адресLabel.Text = "адрес:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(24, 203);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(86, 13);
            дата_рожденияLabel.TabIndex = 79;
            дата_рожденияLabel.Text = "дата рождения:";
            // 
            // идентификатор_читателяLabel
            // 
            идентификатор_читателяLabel.AutoSize = true;
            идентификатор_читателяLabel.Location = new System.Drawing.Point(24, 36);
            идентификатор_читателяLabel.Name = "идентификатор_читателяLabel";
            идентификатор_читателяLabel.Size = new System.Drawing.Size(136, 13);
            идентификатор_читателяLabel.TabIndex = 83;
            идентификатор_читателяLabel.Text = "идентификатор читателя:";
            // 
            // идентификатор_залаLabel
            // 
            идентификатор_залаLabel.AutoSize = true;
            идентификатор_залаLabel.Location = new System.Drawing.Point(24, 245);
            идентификатор_залаLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            идентификатор_залаLabel.Name = "идентификатор_залаLabel";
            идентификатор_залаLabel.Size = new System.Drawing.Size(115, 13);
            идентификатор_залаLabel.TabIndex = 84;
            идентификатор_залаLabel.Text = "идентификатор зала:";
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // читательBindingSource
            // 
            this.читательBindingSource.DataMember = "Читатель";
            this.читательBindingSource.DataSource = this.kursDataSet;
            // 
            // читательTableAdapter
            // 
            this.читательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LibraryKurs.KursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КнигаTableAdapter = null;
            this.tableAdapterManager.КнижнаяСделкаTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = this.читательTableAdapter;
            this.tableAdapterManager.Читательный_ЗалTableAdapter = null;
            this.tableAdapterManager.ЭкземплярTableAdapter = null;
            // 
            // читательBindingNavigator
            // 
            this.читательBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.читательBindingNavigator.BindingSource = this.читательBindingSource;
            this.читательBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.читательBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.читательBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.читательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.читательBindingNavigatorSaveItem});
            this.читательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.читательBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.читательBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.читательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.читательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.читательBindingNavigator.Name = "читательBindingNavigator";
            this.читательBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.читательBindingNavigator.Size = new System.Drawing.Size(1197, 27);
            this.читательBindingNavigator.TabIndex = 0;
            this.читательBindingNavigator.Text = "bindingNavigator1";
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
            // читательBindingNavigatorSaveItem
            // 
            this.читательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.читательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("читательBindingNavigatorSaveItem.Image")));
            this.читательBindingNavigatorSaveItem.Name = "читательBindingNavigatorSaveItem";
            this.читательBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.читательBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.читательBindingNavigatorSaveItem.Click += new System.EventHandler(this.читательBindingNavigatorSaveItem_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(114, 415);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 23);
            this.button7.TabIndex = 76;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 377);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 75;
            this.button6.Text = "Посаледняя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(116, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 74;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 73;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 72;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 70;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // полное_имяTextBox
            // 
            this.полное_имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "полное_имя", true));
            this.полное_имяTextBox.Location = new System.Drawing.Point(166, 70);
            this.полное_имяTextBox.Name = "полное_имяTextBox";
            this.полное_имяTextBox.Size = new System.Drawing.Size(100, 20);
            this.полное_имяTextBox.TabIndex = 77;
            this.полное_имяTextBox.TextChanged += new System.EventHandler(this.полное_имяTextBox_TextChanged);
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(166, 109);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 20);
            this.телефонTextBox.TabIndex = 78;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(166, 151);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 20);
            this.адресTextBox.TabIndex = 79;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.читательBindingSource, "дата_рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(166, 196);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 80;
            // 
            // читательныйЗалBindingSource
            // 
            this.читательныйЗалBindingSource.DataMember = "Читательный Зал";
            this.читательныйЗалBindingSource.DataSource = this.kursDataSet;
            // 
            // идентификатор_читателяTextBox
            // 
            this.идентификатор_читателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "идентификатор_читателя", true));
            this.идентификатор_читателяTextBox.Location = new System.Drawing.Point(166, 33);
            this.идентификатор_читателяTextBox.Name = "идентификатор_читателяTextBox";
            this.идентификатор_читателяTextBox.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_читателяTextBox.TabIndex = 84;
            // 
            // читаттельИЗалBindingSource
            // 
            this.читаттельИЗалBindingSource.DataMember = "Читаттель и зал";
            this.читаттельИЗалBindingSource.DataSource = this.kursDataSet;
            // 
            // читаттель_и_залTableAdapter
            // 
            this.читаттель_и_залTableAdapter.ClearBeforeFill = true;
            // 
            // читательный_ЗалTableAdapter
            // 
            this.читательный_ЗалTableAdapter.ClearBeforeFill = true;
            // 
            // читательDataGridView
            // 
            this.читательDataGridView.AutoGenerateColumns = false;
            this.читательDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.читательDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.читательDataGridView.DataSource = this.читательBindingSource;
            this.читательDataGridView.Location = new System.Drawing.Point(387, 97);
            this.читательDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.читательDataGridView.Name = "читательDataGridView";
            this.читательDataGridView.RowHeadersWidth = 51;
            this.читательDataGridView.RowTemplate.Height = 24;
            this.читательDataGridView.Size = new System.Drawing.Size(782, 210);
            this.читательDataGridView.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "идентификатор_читателя";
            this.dataGridViewTextBoxColumn2.HeaderText = "идентификатор читателя";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "идентификатор читателя";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "полное_имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "полное_имя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "телефон";
            this.dataGridViewTextBoxColumn4.HeaderText = "телефон";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "адрес";
            this.dataGridViewTextBoxColumn5.HeaderText = "адрес";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "дата_рождения";
            this.dataGridViewTextBoxColumn7.HeaderText = "дата рождения";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "идентификатор_зала";
            this.dataGridViewTextBoxColumn9.HeaderText = "идентификатор зала";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // читательныйЗалBindingSource1
            // 
            this.читательныйЗалBindingSource1.DataMember = "Читательный Зал";
            this.читательныйЗалBindingSource1.DataSource = this.kursDataSet;
            // 
            // идентификатор_залаTextBox
            // 
            this.идентификатор_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.читательBindingSource, "идентификатор_зала", true));
            this.идентификатор_залаTextBox.Location = new System.Drawing.Point(166, 240);
            this.идентификатор_залаTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.идентификатор_залаTextBox.Name = "идентификатор_залаTextBox";
            this.идентификатор_залаTextBox.Size = new System.Drawing.Size(100, 20);
            this.идентификатор_залаTextBox.TabIndex = 85;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 458);
            this.Controls.Add(идентификатор_залаLabel);
            this.Controls.Add(this.идентификатор_залаTextBox);
            this.Controls.Add(this.читательDataGridView);
            this.Controls.Add(идентификатор_читателяLabel);
            this.Controls.Add(this.идентификатор_читателяTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(полное_имяLabel);
            this.Controls.Add(this.полное_имяTextBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.читательBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательBindingNavigator)).EndInit();
            this.читательBindingNavigator.ResumeLayout(false);
            this.читательBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читаттельИЗалBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource читательBindingSource;
        private KursDataSetTableAdapters.ЧитательTableAdapter читательTableAdapter;
        private KursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator читательBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton читательBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox полное_имяTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox идентификатор_читателяTextBox;
        private System.Windows.Forms.BindingSource читаттельИЗалBindingSource;
        private KursDataSetTableAdapters.Читаттель_и_залTableAdapter читаттель_и_залTableAdapter;
        private System.Windows.Forms.BindingSource читательныйЗалBindingSource;
        private KursDataSetTableAdapters.Читательный_ЗалTableAdapter читательный_ЗалTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView читательDataGridView;
        private System.Windows.Forms.BindingSource читательныйЗалBindingSource1;
        private System.Windows.Forms.TextBox идентификатор_залаTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}