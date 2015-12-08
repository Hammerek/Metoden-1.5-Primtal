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
    public partial class Form1 : Form //Kamil EEDAT14A
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primtal(); //metod
        }

        private void primtal() //metod
        {
            int tal = Convert.ToInt32(textBox1.Text); //variabel
            bool x = prime(tal);

            if (x)//om x (tal) är sant då talet är ett primtal
            {
                MessageBox.Show("Talet är ett primtal.");
            }
            else //om x (tal) är falskt då talet är inte ett primtal
            {
                MessageBox.Show("Talet är inte ett primtal.");
            }
        }

        private static bool prime(int tal) //bool metoden 
        {
            if (tal < 3) //om talet är mindre än 3
            {
                if (tal == 2) // om tal är lika med 2 
                {
                    return true; //returnera sant 
                }
                else
                {
                    return false; //returnera falskt
                }

            }
            else //annars
            {
                if (tal % 2 == 0) //om talet är jämnt
                {
                    return false; //returnera falskt
                }
                else
                {
                    int i;
                    for (i = 3; tal % i != 0; i += 2) //for loop som räknar från 3
                        ;

                    if (i == tal) //om i är lika med tal då talet är ett primtal
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
    

