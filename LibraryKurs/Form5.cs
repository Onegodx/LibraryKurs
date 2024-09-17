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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void читательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.читательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Читательный_Зал". При необходимости она может быть перемещена или удалена.
            this.читательный_ЗалTableAdapter.Fill(this.kursDataSet.Читательный_Зал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Читаттель_и_зал". При необходимости она может быть перемещена или удалена.
            this.читаттель_и_залTableAdapter.Fill(this.kursDataSet.Читаттель_и_зал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Читатель". При необходимости она может быть перемещена или удалена.
            this.читательTableAdapter.Fill(this.kursDataSet.Читатель);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            читательBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            читательBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            читательBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            читательBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            читательBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            читательBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.читательBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.kursDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void полное_имяTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
