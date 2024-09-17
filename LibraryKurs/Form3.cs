using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryKurs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void экземплярBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.экземплярBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.kursDataSet.Книга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Экземпляр". При необходимости она может быть перемещена или удалена.
            this.экземплярTableAdapter.Fill(this.kursDataSet.Экземпляр);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            экземплярBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            экземплярBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            экземплярBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            экземплярBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            экземплярBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            экземплярBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.экземплярBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);
        }
    }
}
