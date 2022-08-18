using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirclePerimeter
{
    public partial class CirclePer : Form
    {
        public CirclePer()
        {
            InitializeComponent();
        }

        private void CirclePerimer_Load(object sender, EventArgs e)
        {

        }

        public double Perimeter(double radius)
        {
            return Convert.ToInt32(2 * Math.PI * radius);
        }

        private void CirclePer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var radius = double.Parse (tbradius.Text);
            var perimeter = Perimeter(radius);
            tbperimeter.Text = perimeter.ToString();  

        }
    }
}
