using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metoden_1._5_Primtal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            primtal(); 
        }

        private void primtal()
        {
            
            int tal = Convert.ToInt32(textBox1.Text);

            if (tal > 0 && tal < 3)
            {
                MessageBox.Show("Talet är ett primtal");
            }
            if (tal % 2 == 0)
            {
                 MessageBox.Show("Talet är inte ett primtal");
            }
            for (int i = 3; i < tal / 2; i++)
            {
                if (tal % 1 == 0)
                {
                     MessageBox.Show("Talet är inte ett primtal");
                }
                 MessageBox.Show("Talet är ett primtal");
            }
        }

    }
}
