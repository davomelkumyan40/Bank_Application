using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App
{
    public partial class GeneralControl : UserControl
    {
        public GeneralControl()
        {
            InitializeComponent();
        }

        private int imgIndex = 1;
        private void Slider()
        {
            if(imgIndex == 8)
            {
                imgIndex = 1;
            }
            slideIMG.ImageLocation = $@"C:\Users\davom\source\repos\Bank_App\Bank_App\bin\Debug\SlideImages\{imgIndex}.jpg";
            imgIndex++;
        }

        private void slider_Tick(object sender, EventArgs e)
        {
            Slider();
        }
    }
}
