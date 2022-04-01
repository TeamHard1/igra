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
    public partial class Form1 : Form, IView
    {
        private IView view;
        private IController controller;
        public Form1()
        {
            InitializeComponent();


        }

        public void PaintShape(int i, int j)
        {
            
        }

        public void SetInFild(int i, int j)
        {
            controller.UpdateModel(i, j);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 7;
           
        }
    }
}
