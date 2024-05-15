using saper.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace saper
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            MapController.Init(this);
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
