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
        Button[,] button;



        
       //123456789
        public Form1()
        {
            InitializeComponent();
            button = new Button[7, 5];

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 5; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Parent = dataGridView1; 
                    button[i, j].Location = new Point(5 + 70 * i, 5 + 70 * j);
                    button[i, j].Size = new Size(70, 70); 
                    button[i, j].FlatAppearance.BorderSize = 0;               
                }

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
            
        }
		
	}
}
