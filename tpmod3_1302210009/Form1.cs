using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmod3_1302210009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Text = "Halo " + this.textBox1.Text + "!!!";
            //setelah mengklik button1(Submit)
            //apabila textbox1 tidak berisi maka label1 hanya akan menampilkan halo
            //apabila textbox1 berisi maka akan menghasilkan halo+isi dari textbox 1
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
