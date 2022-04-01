using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private IView view;
        private IController controller;
        public Form1()
        {
            InitializeComponent();


        }

        public void PaintShape(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void SetInFild(int i, int j)
        {
            controller.UpdateModel(i, j);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
