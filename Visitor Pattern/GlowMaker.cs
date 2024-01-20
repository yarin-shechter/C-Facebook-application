using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookApplication
{
    class GlowMaker
    { 
        private IColorable m_ObjectToMakeGlow;
        private Timer m_Timer;
        private int m_Alpha;
        private bool m_ColorAscending;
        private int m_ColorIncrement = 30;
        private Color m_BaseColor;
        private Color m_GlowColor;


        internal GlowMaker(IColorable i_ObjectToMakeGlow, Color i_GlowColor)
        {
            this.m_ObjectToMakeGlow = i_ObjectToMakeGlow;
            this.m_Alpha = 0;
            this.m_ColorAscending = true;
            this.m_Timer = new Timer(){Interval = 50};
            this.m_BaseColor = i_ObjectToMakeGlow.Color;
            this.m_GlowColor = i_GlowColor;
            this.m_Timer.Tick += m_Timer_Tick;
        }

        internal void MakeObjectGlow()
        {
            this.m_ColorAscending = true;
            this.m_Alpha = 0;
            this.m_ObjectToMakeGlow.Color = this.m_BaseColor;
            this.m_Timer.Start();
        }

        private void m_Timer_Tick(object sender, EventArgs e)
        {
            if (m_ColorAscending)
            {
                this.m_Alpha += this.m_ColorIncrement;
                this.m_ColorAscending = this.m_Alpha + this.m_ColorIncrement < 255;
                this.m_ObjectToMakeGlow.Color = calculateColor();
            }
            else
            {
                this.m_Alpha -= this.m_ColorIncrement;
                this.m_ObjectToMakeGlow.Color = calculateColor();
                if (this.m_Alpha - m_ColorIncrement < 0)
                {
                    this.m_Timer.Stop();
                    this.m_ColorAscending = true;
                    this.m_Alpha = 0;
                    this.m_ObjectToMakeGlow.Color = calculateColor();
                }
            }

        }

        private Color calculateColor()
        {
            return alphaBlend(Color.FromArgb(this.m_Alpha, this.m_GlowColor), this.m_BaseColor);
        }
        private Color alphaBlend(Color i_First, Color i_Second)
        {
            int r = (i_First.R * i_First.A / 255) + (i_Second.R * i_Second.A * (255 - i_First.A) / (255 * 255));
            int g = (i_First.G * i_First.A / 255) + (i_Second.G * i_Second.A * (255 - i_First.A) / (255 * 255));
            int b = (i_First.B * i_First.A / 255) + (i_Second.B * i_Second.A * (255 - i_First.A) / (255 * 255));
            int a = i_First.A + (i_Second.A * (255 - i_First.A) / 255);
            return Color.FromArgb(a, r, g, b);
        }


    }
}
