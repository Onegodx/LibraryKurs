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

    public partial class Form10 : Form

    {

        public Form10()

        {

            InitializeComponent();

        }



        private void Form10_Load(object sender, EventArgs e)

        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Книга". При необходимости она может быть перемещена или удалена. 

            this.книгаTableAdapter.Fill(this.kursDataSet.Книга);



        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)

        {



        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

            button1.Enabled = true;

        }



        private void button1_Click(object sender, EventArgs e)

        {



            {

                DataGridViewColumn column = null;

                switch (listBox1.SelectedIndex)

                {

                    case 0:

                        {

                            column = dataGridViewTextBoxColumn2;

                            break;

                        }

                    case 1:

                        {

                            column = dataGridViewTextBoxColumn3;

                            break;

                        }

                    case 2:

                        {

                            column = dataGridViewTextBoxColumn4;

                            break;

                        }

                    case 3:

                        {

                            column = dataGridViewTextBoxColumn5;

                            break;

                        }

                    case 4:

                        {

                            column = dataGridViewTextBoxColumn6;

                            break;

                        }

                    case 5:

                        {

                            column = dataGridViewTextBoxColumn7;

                            break;

                        }

                    

                    case 7:

                        {

                            column = dataGridViewTextBoxColumn9;

                            break;

                        }

                }

                if (radioButton1.Checked)

                    книгаDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Ascending);



                else

                    книгаDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);



            }

        }

        private void книгаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {



        }



        private void button2_Click(object sender, EventArgs e)

        {

            {

                string filter = "";



                if (!string.IsNullOrWhiteSpace(textBox2.Text))

                {

                    filter += "автор='" + textBox2.Text + "' AND ";

                }



                if (!string.IsNullOrWhiteSpace(textBox1.Text))

                {

                    filter += "издательство='" + textBox1.Text + "' AND ";

                }

                if (!string.IsNullOrWhiteSpace(textBox3.Text))

                {

                    int yearFilter = 0;

                    if (Int32.TryParse(textBox3.Text, out yearFilter))

                    {

                        filter += "дата_публикации >= '" + yearFilter.ToString() + "-01-01' AND '";

                    }

                }







                if (!string.IsNullOrWhiteSpace(filter))

                {

                    filter = filter.Substring(0, filter.Length - 5);



                    книгаBindingSource.Filter = filter;

                }

            }

        }



        private void button4_Click(object sender, EventArgs e)

        {

            книгаBindingSource.Filter = "";

        }



        private void button5_Click(object sender, EventArgs e)

        {

            Close();

        }



        private void Form10_Load_1(object sender, EventArgs e)

        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet2.Книга". При необходимости она может быть перемещена или удалена. 

            this.книгаTableAdapter.Fill(this.kursDataSet.Книга);



        }



        private void книгаBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)

        {

            this.Validate();

            this.книгаBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.kursDataSet);



        }



        private void книгаDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {



        }

    }

}


