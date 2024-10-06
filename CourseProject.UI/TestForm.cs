using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{comboBox1.SelectedIndex} {comboBox1.SelectedItem.ToString()}");
            comboBox1.Text = "2";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
