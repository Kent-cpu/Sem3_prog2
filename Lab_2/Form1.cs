using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try
            {
                Cars cars = XmlHandler.getCars();
                if(cars == null)
                {
                    MessageBox.Show("Проверьте наличие XML файла и его корректность.");
                    return;
                } 
                cars.print(dataGridView1);
            } catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}