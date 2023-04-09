using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robotArm
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            label1.Text = "Developers";
            label2.Text = "Name : İbrahim Ensar KÖK ";
            label3.Text = "   ID    : 2014513048        ";
            label4.Text = "Name : Muhammed Akif KAYHANER  ";
            label5.Text = "   ID    : 2014513041";
            label6.Text = "Copyright © 2019";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
