using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp113
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cEmployee u = new cWorker();

            try
            {
                int x = 50000000;
                int y = 50000000;
                int z = x / y;
            }
            catch (Exception ex)
            {
            }
        }
    }
}

