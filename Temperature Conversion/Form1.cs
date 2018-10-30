using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cChoice.Checked)
                    convertC(Convert.ToDouble(temp.Text));
                else
                    convertF(Convert.ToDouble(temp.Text));
            } catch
            {
                MessageBox.Show("Error converting string to number!");
            }
            
        }

        private void convertF (double oldTemp)
        {
            double newTemp = (oldTemp * 9 / 5) + 32;
            outPutAnswer(newTemp);
        }

        private void convertC(double oldTemp)
        {
            double newTemp = (oldTemp - 32) * 9 / 5;
            outPutAnswer(newTemp);
        }

        private void outPutAnswer(double answer)
        {
            MessageBox.Show("It converts to " + answer);
        }
    }
}
