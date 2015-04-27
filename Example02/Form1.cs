using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcuateTotalButton_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(Num1.Text);
            int Number2 = int.Parse(Num2.Text);
            int Number3 = int.Parse(Num3.Text);
            int Number4 = int.Parse(Num4.Text);

            int Total = Number1 + Number2 + Number3 + Number4;
            MessageBox.Show("總和是 " + Total.ToString());
        }
    }
}