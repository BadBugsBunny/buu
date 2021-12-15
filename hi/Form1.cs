using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            btn1.TabStop = false;
            btn2.TabStop = false;
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btn2.Width);
            int y = r.Next(0, this.Height - btn2.Height);
            btn2.Location = new Point(x, y);
        }

        private void btn2_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btn2.Location == btn1.Location || btn2.Location == label1.Location || btn2.Location == label2.Location)
            {
                MoverBoton();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
