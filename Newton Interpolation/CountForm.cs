using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newton_Interpolation
{
    public partial class CountForm : Form
    {
        public Point[] p;

        public double[] buff;

        private double x;

        public CountForm()
        {
            InitializeComponent();
            textBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(textBox1.Text, out x))
                {
                    x = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong value", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Interpolator interpolator = new Interpolator();
            MainForm form1 = new MainForm();
            textBox2.Show();
            textBox2.Clear();
            textBox2.Text = interpolator.computeNewtonPoly(p, p.Length, x, buff).ToString();
        }
    }
}
