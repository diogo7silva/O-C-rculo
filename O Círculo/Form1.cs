using System;
using System.Windows.Forms;

namespace O_Círculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Círculo C = new Círculo();
        private void Button1_Click(object sender, EventArgs e)
        {
            C.Raio = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked) label1.Text = C.Area.ToString();
            else if (radioButton2.Checked) label1.Text = C.Perimetro.ToString();
            else if (radioButton3.Checked) label1.Text = C.Diametro.ToString();
        }
    }
}
