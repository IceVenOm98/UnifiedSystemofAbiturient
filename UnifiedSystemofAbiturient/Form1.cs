using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifiedSystemofAbiturient
{
    public partial class Form1 : Form
    {
        private SystemController SystemController = new SystemController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int number))
                SystemController.newUniversity(textBox1.Text, number);
            reloadUniversities();
        }
        private void reloadUniversities()
        {
            richTextBox1.Text = "";
            foreach (University u in SystemController.getUniversities())
            {
                richTextBox1.Text += "\n\nУниверситет " + u.Title +
                    ". Количество мест: " + u.Places
                    + ". Количество мест на данный момент: " + u.getFreePlaces();
            }
        }
    }
}
