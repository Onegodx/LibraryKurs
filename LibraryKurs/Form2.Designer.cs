namespace LibraryKurs
{
    partial class Form2
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
            System.Windows.Forms.Label идентификаторLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label авторLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label жанрLabel;
            System.Windows.Forms.Label дата_публикацииLabel;
            System.Windows.Forms.Label количество_экземпляровLabel;
            System.Windows.Forms.Label издательствоLabel;
            System.Windows.Forms.Label идентификатор_книгиLabel;
            System.Windows.Forms.Label индентификатор_залаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.kursDataSet = new LibraryKurs.KursDataSet();
            this.книгаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгаTableAdapter = new LibraryKurs.KursDataSetTableAdapters.КнигаTableAdapter();
            this.tableAdapterManager = new LibraryKurs.KursDataSetTableAdapters.TableAdapterManager();
            this.книгаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.книгаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.авторTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.жанрTextBox = new System.Windows.Forms.TextBox();
            this.дата_публикацииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.количество_экземпляровTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.издательствоTextBox = new System.Windows.Forms.TextBox();
            this.читательныйЗалBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.читательныйЗалBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.читательныйЗалBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читательный_ЗалTableAdapter = new LibraryKurs.KursDataSetTableAdapters.Читательный_ЗалTableAdapter();
            this.идентификатор_книгиTextBox = new System.Windows.Forms.TextBox();
            this.читательныйЗалBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.книгаDataGridView = new System.Windows.Forms.DataGridView();
            this.индентификатор_залаTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            идентификаторLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            авторLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            жанрLabel = new System.Windows.Forms.Label();
            дата_публикацииLabel = new System.Windows.Forms.Label();
            количество_экземпляровLabel = new System.Windows.Forms.Label();
            издательствоLabel = new System.Windows.Forms.Label();
            идентификатор_книгиLabel = new System.Windows.Forms.Label();
            индентификатор_залаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingNavigator)).BeginInit();
            this.книгаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // идентификаторLabel
            // 
            идентификаторLabel.AutoSize = true;
            идентификаторLabel.Location = new System.Drawing.Point(26, 61);
            идентификаторLabel.Name = "идентификаторLabel";
            идентификаторLabel.Size = new System.Drawing.Size(0, 13);
            идентификаторLabel.TabIndex = 1;
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(26, 105);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(58, 13);
            названиеLabel.TabIndex = 3;
            названиеLabel.Text = "название:";
            // 
            // авторLabel
            // 
            авторLabel.AutoSize = true;
            авторLabel.Location = new System.Drawing.Point(26, 148);
            авторLabel.Name = "авторLabel";
            авторLabel.Size = new System.Drawing.Size(39, 13);
            авторLabel.TabIndex = 5;
            авторLabel.Text = "автор:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(26, 190);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(34, 13);
            ценаLabel.TabIndex = 7;
            ценаLabel.Text = "цена:";
            // 
            // жанрLabel
            // 
            жанрLabel.AutoSize = true;
            жанрLabel.Location = new System.Drawing.Point(26, 236);
            жанрLabel.Name = "жанрLabel";
            жанрLabel.Size = new System.Drawing.Size(36, 13);
            жанрLabel.TabIndex = 9;
            жанрLabel.Text = "жанр:";
            // 
            // дата_публикацииLabel
            // 
            дата_публикацииLabel.AutoSize = true;
            дата_публикацииLabel.Location = new System.Drawing.Point(26, 309);
            дата_публикацииLabel.Name = "дата_публикацииLabel";
            дата_публикацииLabel.Size = new System.Drawing.Size(95, 13);
            дата_публикацииLabel.TabIndex = 11;
            дата_публикацииLabel.Text = "дата публикации:";
            // 
            // количество_экземпляровLabel
            // 
            количество_экземпляровLabel.AutoSize = true;
            количество_экземпляровLabel.Location = new System.Drawing.Point(26, 349);
            количество_экземпляровLabel.Name = "количество_экземпляровLabel";
            количество_экземпляровLabel.Size = new System.Drawing.Size(139, 13);
            количество_экземпляровLabel.TabIndex = 13;
            количество_экземпляровLabel.Text = "количество экземпляров:";
            // 
            // издательствоLabel
            // 
            издательствоLabel.AutoSize = true;
            издательствоLabel.Location = new System.Drawing.Point(26, 273);
            издательствоLabel.Name = "издательствоLabel";
            издательствоLabel.Size = new System.Drawing.Size(80, 13);
            издательствоLabel.TabIndex = 55;
            издательствоLabel.Text = "издательство:";
            // 
            // идентификатор_книгиLabel
            // 
            идентификатор_книгиLabel.AutoSize = true;
            идентификатор_книгиLabel.Location = new System.Drawing.Point(26, 61);
            идентификатор_книгиLabel.Name = "идентификатор_книгиLabel";
            идентификатор_книгиLabel.Size = new System.Drawing.Size(120, 13);
            идентификатор_книгиLabel.TabIndex = 57;
            идентификатор_книгиLabel.Text = "идентификатор книги:";
            // 
            // индентификатор_залаLabel
            // 
            индентификатор_залаLabel.AutoSize = true;
            индентификатор_залаLabel.Location = new System.Drawing.Point(27, 391);
            индентификатор_залаLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            индентификатор_залаLabel.Name = "индентификатор_залаLabel";
            индентификатор_залаLabel.Size = new System.Drawing.Size(121, 13);
            индентификатор_залаLabel.TabIndex = 58;
            индентификатор_залаLabel.Text = "индентификатор зала:";
            // 
            // kursDataSet
            // 
            this.kursDataSet.DataSetName = "KursDataSet";
            this.kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = LibraryKurs.KursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КнигаTableAdapter = this.книгаTableAdapter;
            this.tableAdapterManager.КнижнаяСделкаTableAdapter = null;
            this.tableAdapterManager.ЧитательTableAdapter = null;
            this.tableAdapterManager.Читательный_ЗалTableAdapter = null;
            this.tableAdapterManager.ЭкземплярTableAdapter = null;
            // 
            // книгаBindingNavigator
            // 
            this.книгаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.книгаBindingNavigator.BindingSource = this.книгаBindingSource;
            this.книгаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.книгаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.книгаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.книгаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.книгаBindingNavigatorSaveItem});
            this.книгаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.книгаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.книгаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.книгаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.книгаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.книгаBindingNavigator.Name = "книгаBindingNavigator";
            this.книгаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.книгаBindingNavigator.Size = new System.Drawing.Size(1391, 27);
            this.книгаBindingNavigator.TabIndex = 0;
            this.книгаBindingNavigator.Text = "bindingNavigator1";
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
            // книгаBindingNavigatorSaveItem
            // 
            this.книгаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.книгаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("книгаBindingNavigatorSaveItem.Image")));
            this.книгаBindingNavigatorSaveItem.Name = "книгаBindingNavigatorSaveItem";
            this.книгаBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.книгаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.книгаBindingNavigatorSaveItem.Click += new System.EventHandler(this.книгаBindingNavigatorSaveItem_Click);
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(182, 105);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(129, 20);
            this.названиеTextBox.TabIndex = 4;
            // 
            // авторTextBox
            // 
            this.авторTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "автор", true));
            this.авторTextBox.Location = new System.Drawing.Point(182, 148);
            this.авторTextBox.Name = "авторTextBox";
            this.авторTextBox.Size = new System.Drawing.Size(129, 20);
            this.авторTextBox.TabIndex = 6;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(182, 190);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(129, 20);
            this.ценаTextBox.TabIndex = 8;
            // 
            // жанрTextBox
            // 
            this.жанрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "жанр", true));
            this.жанрTextBox.Location = new System.Drawing.Point(182, 229);
            this.жанрTextBox.Name = "жанрTextBox";
            this.жанрTextBox.Size = new System.Drawing.Size(129, 20);
            this.жанрTextBox.TabIndex = 10;
            // 
            // дата_публикацииDateTimePicker
            // 
            this.дата_публикацииDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.книгаBindingSource, "дата_публикации", true));
            this.дата_публикацииDateTimePicker.Location = new System.Drawing.Point(182, 308);
            this.дата_публикацииDateTimePicker.Name = "дата_публикацииDateTimePicker";
            this.дата_публикацииDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.дата_публикацииDateTimePicker.TabIndex = 12;
            // 
            // количество_экземпляровTextBox
            // 
            this.количество_экземпляровTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "количество_экземпляров", true));
            this.количество_экземпляровTextBox.Location = new System.Drawing.Point(182, 349);
            this.количество_экземпляровTextBox.Name = "количество_экземпляровTextBox";
            this.количество_экземпляровTextBox.Size = new System.Drawing.Size(129, 20);
            this.количество_экземпляровTextBox.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(29, 471);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 54;
            this.button6.Text = "Посаледняя";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(133, 471);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 52;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(131, 509);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 23);
            this.button7.TabIndex = 55;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // издательствоTextBox
            // 
            this.издательствоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "издательство", true));
            this.издательствоTextBox.Location = new System.Drawing.Point(182, 266);
            this.издательствоTextBox.Name = "издательствоTextBox";
            this.издательствоTextBox.Size = new System.Drawing.Size(129, 20);
            this.издательствоTextBox.TabIndex = 56;
            // 
            // читательныйЗалBindingSource2
            // 
            this.читательныйЗалBindingSource2.DataMember = "Читательный Зал";
            this.читательныйЗалBindingSource2.DataSource = this.kursDataSet;
            // 
            // читательныйЗалBindingSource1
            // 
            this.читательныйЗалBindingSource1.DataMember = "Читательный Зал";
            this.читательныйЗалBindingSource1.DataSource = this.kursDataSet;
            // 
            // читательныйЗалBindingSource
            // 
            this.читательныйЗалBindingSource.DataMember = "Читательный Зал";
            this.читательныйЗалBindingSource.DataSource = this.kursDataSet;
            // 
            // читательный_ЗалTableAdapter
            // 
            this.читательный_ЗалTableAdapter.ClearBeforeFill = true;
            // 
            // идентификатор_книгиTextBox
            // 
            this.идентификатор_книгиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "идентификатор_книги", true));
            this.идентификатор_книгиTextBox.Location = new System.Drawing.Point(182, 58);
            this.идентификатор_книгиTextBox.Name = "идентификатор_книгиTextBox";
            this.идентификатор_книгиTextBox.Size = new System.Drawing.Size(129, 20);
            this.идентификатор_книгиTextBox.TabIndex = 58;
            // 
            // читательныйЗалBindingSource3
            // 
            this.читательныйЗалBindingSource3.DataMember = "Читательный Зал";
            this.читательныйЗалBindingSource3.DataSource = this.kursDataSet;
            // 
            // книгаDataGridView
            // 
            this.книгаDataGridView.AutoGenerateColumns = false;
            this.книгаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.книгаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn13});
            this.книгаDataGridView.DataSource = this.книгаBindingSource;
            this.книгаDataGridView.Location = new System.Drawing.Point(342, 29);
            this.книгаDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.книгаDataGridView.Name = "книгаDataGridView";
            this.книгаDataGridView.RowHeadersWidth = 51;
            this.книгаDataGridView.RowTemplate.Height = 24;
            this.книгаDataGridView.Size = new System.Drawing.Size(1026, 254);
            this.книгаDataGridView.TabIndex = 58;
            // 
            // индентификатор_залаTextBox
            // 
            this.индентификатор_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "индентификатор_зала", true));
            this.индентификатор_залаTextBox.Location = new System.Drawing.Point(182, 386);
            this.индентификатор_залаTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.индентификатор_залаTextBox.Name = "индентификатор_залаTextBox";
            this.индентификатор_залаTextBox.Size = new System.Drawing.Size(129, 20);
            this.индентификатор_залаTextBox.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "идентификатор_книги";
            this.dataGridViewTextBoxColumn3.HeaderText = "идентификатор книги";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "название";
            this.dataGridViewTextBoxColumn4.HeaderText = "название";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "автор";
            this.dataGridViewTextBoxColumn5.HeaderText = "автор";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "цена";
            this.dataGridViewTextBoxColumn6.HeaderText = "цена";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "жанр";
            this.dataGridViewTextBoxColumn7.HeaderText = "жанр";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "дата_публикации";
            this.dataGridViewTextBoxColumn8.HeaderText = "дата_публикации";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "издательство";
            this.dataGridViewTextBoxColumn10.HeaderText = "издательство";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "индентификатор_зала";
            this.dataGridViewTextBoxColumn13.HeaderText = "индентификатор зала";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 555);
            this.Controls.Add(индентификатор_залаLabel);
            this.Controls.Add(this.индентификатор_залаTextBox);
            this.Controls.Add(this.книгаDataGridView);
            this.Controls.Add(идентификатор_книгиLabel);
            this.Controls.Add(this.идентификатор_книгиTextBox);
            this.Controls.Add(издательствоLabel);
            this.Controls.Add(this.издательствоTextBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(количество_экземпляровLabel);
            this.Controls.Add(this.количество_экземпляровTextBox);
            this.Controls.Add(дата_публикацииLabel);
            this.Controls.Add(this.дата_публикацииDateTimePicker);
            this.Controls.Add(жанрLabel);
            this.Controls.Add(this.жанрTextBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(авторLabel);
            this.Controls.Add(this.авторTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(идентификаторLabel);
            this.Controls.Add(this.книгаBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingNavigator)).EndInit();
            this.книгаBindingNavigator.ResumeLayout(false);
            this.книгаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читательныйЗалBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KursDataSet kursDataSet;
        private System.Windows.Forms.BindingSource книгаBindingSource;
        private KursDataSetTableAdapters.КнигаTableAdapter книгаTableAdapter;
        private KursDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator книгаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton книгаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox авторTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox жанрTextBox;
        private System.Windows.Forms.DateTimePicker дата_публикацииDateTimePicker;
        private System.Windows.Forms.TextBox количество_экземпляровTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox издательствоTextBox;
        private System.Windows.Forms.BindingSource читательныйЗалBindingSource;
        private KursDataSetTableAdapters.Читательный_ЗалTableAdapter читательный_ЗалTableAdapter;
        private System.Windows.Forms.BindingSource читательныйЗалBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox идентификатор_книгиTextBox;
        private System.Windows.Forms.BindingSource читательныйЗалBindingSource2;
        private System.Windows.Forms.BindingSource читательныйЗалBindingSource3;
        private System.Windows.Forms.DataGridView книгаDataGridView;
        private System.Windows.Forms.TextBox индентификатор_залаTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}