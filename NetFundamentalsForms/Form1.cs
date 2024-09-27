using NetFundamentalsStandardLibrary;
using System;
using System.Windows.Forms;

namespace NetFundamentalsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstname = textBox1.Text;
            var result = StringConcatinator.Concatenate(firstname);

            MessageBox.Show(result);
        }
    }
}
