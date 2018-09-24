using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            generalControl1.BringToFront();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //Application.Exit();
        }



        //Move Drag Drop
        private bool mouseDown;
        private Point lastLocation;

        private void generalPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void generalPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void generalPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private string text = null;
        private void buttons_MouseEnter(object sender, EventArgs e)
        {
            text = ((Button)sender).Text;
            System.Threading.Thread.Sleep(100);
            ((Button)sender).ImageAlign = ContentAlignment.MiddleCenter;
            ((Button)sender).Text = "";
            pointerPanel.Visible = true;
            pointerPanel.Height = ((Button)sender).Height;
            pointerPanel.Top = ((Button)sender).Top;

        }

        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ImageAlign = ContentAlignment.MiddleLeft;
            ((Button)sender).Text = text;
            pointerPanel.Visible = false;
            pointerPanel.Height = ((Button)sender).Height;
            pointerPanel.Top = ((Button)sender).Top;

        }


        private void generalButton_Click(object sender, EventArgs e)
        {
            logRegister1.Visible = false;
            generalControl1.Visible = true;
            generalControl1.BringToFront();
        }

        private void elipsButton1_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Cursor = Cursors.Hand;
            ((Button)sender).ForeColor = Color.FromArgb(105, 105, 105);
            ((Button)sender).BackColor = Color.FromArgb(0, 71, 160);
            ((Button)sender).Text = "";
            System.Threading.Thread.Sleep(100);
        }

        private void elipsButton1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Cursor = Cursors.Arrow;
            ((Button)sender).ForeColor = Color.FromArgb(105, 105, 105);
            ((Button)sender).BackColor = Color.White;
            if (((Button)sender).Name == "elipsButton1")
                ((Button)sender).Text = "Login";
            else
                ((Button)sender).Text = "Exit";
            System.Threading.Thread.Sleep(100);
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            depositControl1.Visible = false;
            generalControl1.Visible = false;
            userServices1.Visible = false;
            logRegister1.Visible = true;
            logRegister1.BringToFront();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            generalControl1.Visible = false;
            logRegister1.Visible = false;
            userServices1.Visible = false;
            depositControl1.Visible = true;
            depositControl1.BringToFront();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            generalControl1.Visible = false;
            logRegister1.Visible = false;
            depositControl1.Visible = false;
            userServices1.Visible = true;
            userServices1.BringToFront();
        }
    }
}
