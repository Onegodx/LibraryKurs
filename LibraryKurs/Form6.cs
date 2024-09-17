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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void книжнаяСделкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книжнаяСделкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Экземпляр". При необходимости она может быть перемещена или удалена.
            this.экземплярTableAdapter.Fill(this.kursDataSet.Экземпляр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Читатель". При необходимости она может быть перемещена или удалена.
            this.читательTableAdapter.Fill(this.kursDataSet.Читатель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.kursDataSet.Книга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.КнижнаяСделка". При необходимости она может быть перемещена или удалена.
            this.книжнаяСделкаTableAdapter.Fill(this.kursDataSet.КнижнаяСделка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            книжнаяСделкаBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            книжнаяСделкаBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            книжнаяСделкаBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            книжнаяСделкаBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            книжнаяСделкаBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            книжнаяСделкаBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.книжнаяСделкаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.kursDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void идентификатор_сделкиTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
