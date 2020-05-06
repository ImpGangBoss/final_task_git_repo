using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            double number;
            double.TryParse(textBox1.Text.ToString(), out number);
            if(sphere_volume(number) < 0)
            {
                label2.Text = "Wrong number!";
            }
            else
                label2.Text = sphere_volume(number).ToString();
        }
        public static double sphere_volume(double radius)
        {
            return (4 * Math.PI * Math.Pow(radius, 3))/3;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
