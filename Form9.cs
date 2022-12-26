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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void ремонтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.workshopDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.workshopDataSet.Ремонт);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm4 = new Form3();
            frm4.Show();
            this.Hide();
        }
    }
}
