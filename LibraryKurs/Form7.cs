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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Взятые_книги_читателя". При необходимости она может быть перемещена или удалена.
            this.взятые_книги_читателяTableAdapter.Fill(this.kursDataSet.Взятые_книги_читателя);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.книга_Определенного_ЖанраTableAdapter.Fill(this.kursDataSet.Книга_Определенного_Жанра, жанрToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
