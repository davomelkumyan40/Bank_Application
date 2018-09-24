using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bank_App
{
    public partial class GeneralControl : UserControl
    {
        public GeneralControl()
        {
            InitializeComponent();
            slider.Enabled = true;
        }

        private int imgIndex = 1;
        private void Slider()
        {
            if(imgIndex == 8)
            {
                imgIndex = 1;
            }
            var fileInfo = new FileInfo($@".\SlideImages\{imgIndex}.jpg");
            if (fileInfo.Exists)
            {
                slideIMG.ImageLocation = fileInfo.DirectoryName + @"\" + fileInfo.Name;
                imgIndex++;
            }
            else
                slider.Enabled = false;
           
        }

        private void slider_Tick(object sender, EventArgs e)
        {
            Slider();
        }
    }
}
