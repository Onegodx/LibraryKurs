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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void читательный_ЗалBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательный_ЗалBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Читаттель_и_зал". При необходимости она может быть перемещена или удалена.
            this.читаттель_и_залTableAdapter.Fill(this.kursDataSet.Читаттель_и_зал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Читательный_Зал". При необходимости она может быть перемещена или удалена.
            this.читательный_ЗалTableAdapter.Fill(this.kursDataSet.Читательный_Зал);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            читательный_ЗалBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            читательный_ЗалBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            читательный_ЗалBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            читательный_ЗалBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            читательный_ЗалBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            читательный_ЗалBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательный_ЗалBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);
        }

        private void идентификатор_залаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void читаттель_и_залDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
