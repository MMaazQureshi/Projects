using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
            label3.Text = DateTime.Now.ToShortTimeString();
            label5.Text=Class1.higher+"/"+Class1.lower;
            Class1 obj = new Class1();
            if (Class1.higher > 140 || Class1.higher <=90 && Class1.lower <= 60 || Class1.lower >= 90)
            { label7.BackColor = System.Drawing.Color.Red; }
            label7.Text =obj.numbers_ranges(Class1.higher, Class1.lower,label7);
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
