using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ProjetoTrello
{
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            homeControl.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            homeControl.BringToFront();
            SearchButton.BringToFront();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            settingsControl1.BringToFront();
            SearchButton.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addProject_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            searchControl1.BringToFront();
            searchControl1.Focus();
        }

        private void Power_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
            SearchButton.BringToFront();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            SearchButton.BringToFront();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            SearchButton.BringToFront();
        }

        private void searchControl1_Load(object sender, EventArgs e)
        {
         
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void homeControl_MouseDown(object sender, MouseEventArgs e)
        {
            SearchButton.BringToFront();
        }

        private void sidePanelBlue_MouseDown(object sender, MouseEventArgs e)
        {
            SearchButton.BringToFront();
        }

        private void homeControl_Load(object sender, EventArgs e)
        {

        }
    }
}
