using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace scrape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text; ///convert url into variables
            string soursecode = WorkerClass.getSoursecode(url);
            StreamWriter sw = new StreamWriter("website.html");
            sw.Write(soursecode);
            sw.Close();

        }
    }
}
