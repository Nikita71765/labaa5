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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void цехBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.цехBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workshopDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.Цех". При необходимости она может быть перемещена или удалена.
            this.цехTableAdapter.Fill(this.workshopDataSet.Цех);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm4 = new Form2();
            frm4.Show();
            this.Hide();
        }
    }
}
