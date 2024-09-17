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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void книгаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Читательный_Зал". При необходимости она может быть перемещена или удалена.
            this.читательный_ЗалTableAdapter.Fill(this.kursDataSet.Читательный_Зал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.kursDataSet.Книга);

        }

        private void button1_Click(object sender, EventArgs e)
        {
              книгаBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            книгаBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            книгаBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            книгаBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            книгаBindingSource.RemoveCurrent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            книгаBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursDataSet);
        }

        
    }
}
