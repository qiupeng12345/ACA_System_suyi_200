using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Test
{
    
    public partial class frmTest : Form
    {
        private delegate void show();
        private System.Threading.Timer tim;
        static int i = 0;
        Thread th = new Thread(qp);
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th.IsBackground = true;
            th.Start();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            //tim = new System.Threading.Timer(display, this, 0, 100);
            //Thread th = new Thread(display);
            //th.IsBackground = true;
            //th.Start();


        }
        public static void qp()
        {
            i++;
            Thread.Sleep(100);
        }
        private void display()
        {
            if (InvokeRequired)
            {
                show d = new show(display);
                textBox1.Invoke(d);
            }

            
        }
    }
}
