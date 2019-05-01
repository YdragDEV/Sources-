using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicLoginSytem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123" && textBox2.Text == "123")
            {

                MessageBox.Show("Logado com sucesso");
                var f2 = new Form2();
                f2.Show();
            }

            else
            {

                MessageBox.Show("ERRO");
            }

            

        }
    }
}
