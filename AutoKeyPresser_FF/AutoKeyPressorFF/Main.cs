using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AutoKeyPressorFF
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwdata, int dwextrainfo);
        public enum mouseeventflags
        {
            LeftDown = 2,
            LeftUp = 4,
        }

        public void leftclick(Point p)
        {
            mouse_event((int)(mouseeventflags.LeftDown), p.X, p.Y, 0, 0);
            mouse_event((int)(mouseeventflags.LeftUp), p.X, p.Y, 0, 0);
        }

        bool stop = true;

        private void startStop_btn_Click(object sender, EventArgs e)
        {
            stop = (stop) ? false : true;
            timer1.Interval = (int)numericUpDown1.Value;
            timer1.Enabled = true;

            if (!stop) timer1.Start();
            if (stop) timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            leftclick(new Point(MousePosition.X, MousePosition.Y));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Keyboard.IsKeyDown(Key.S))
            {
                timer1.Interval = (int)numericUpDown1.Value;
                timer1.Start();
            }
            if(Keyboard.IsKeyDown(Key.E))
            {
                timer1.Interval = (int)numericUpDown1.Value;
                timer1.Stop();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 1;
            timer2.Start();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
