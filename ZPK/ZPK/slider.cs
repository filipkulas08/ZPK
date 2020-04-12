using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPK
{
    public partial class slider: UserControl
    {
        private int ColorR;
        private int ColorB;
        private int ColorG;
        private int SliderValue;
        private Color Kolor;

       public int Slider1V
        {
            get
            {
                return trackBar1.Value;
            }
            set
            {
                trackBar1.Value = SliderValue;
            }
        }
        public int Slider2V
        {
            get
            {
                return trackBar2.Value;
            }
            set
            {
                trackBar2.Value = SliderValue;
            }
        }
        public int Slider3V
        {
            get
            {
                return trackBar3.Value;
            }
            set
            {
                trackBar3.Value = SliderValue;
            }
        }
        public Color bgColor
        {
            get
            {
                return Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            }
            set
            {
                Kolor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            }
        }

        public int ColorRed
        {
            get
            {
                return ColorR;
            }
            set
            {
                ColorR = value;
                trackBar1.BackColor = Color.FromArgb(ColorR, 0, 0);

            }
        }
        public int ColorGreen
        {
            get
            {
                return ColorG;
            }
            set
            {
                ColorG = value;
                trackBar2.BackColor = Color.FromArgb(0, ColorG, 0);
            }
        }
        public int ColorBlue
        {
            get
            {
                return ColorB;
            }
            set
            {
                ColorB = value;
                trackBar3.BackColor = Color.FromArgb(0, 0, ColorB);
            }
        }
        public slider()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.BackColor = Color.FromArgb(trackBar1.Value, 0, 0);
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.BackColor = Color.FromArgb(0, trackBar2.Value, 0);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.BackColor = Color.FromArgb(0, 0, trackBar3.Value);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
