using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void оборудованиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оборудованиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workshopDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.workshopDataSet.Оборудование);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm4 = new Form2();
            frm4.Show();
            this.Hide();
        }
    }
}
