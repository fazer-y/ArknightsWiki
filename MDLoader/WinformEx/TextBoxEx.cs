using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsWiki.WinformEx
{
    public class TextBoxEx : TextBox
    {
        public bool roundCorner = false;
        public float radius = 0.0f;
        private Color crBorderActive = Color.FromArgb(Convert.ToInt32("FF3283C4", 16));
        private Color crRectActive = Color.FromArgb(Convert.ToInt32("FFE3F3FB", 16));
        private Color crBorderDefault = Color.FromArgb(215, 215, 215);
        public Color crBorderPainting { get; set; }

        public TextBoxEx(bool roundCorner, float radius, Color crBorderPainting) : base()
        {
            this.radius = radius;
            this.roundCorner = roundCorner;
            this.crBorderPainting = crBorderPainting;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (!roundCorner)
            {
                base.OnPaint(pe);
                return;
            }
            Graphics g = pe.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //g.SmoothingMode = SmoothingMode.HighQuality;
            //g.CompositingQuality = CompositingQuality.HighQuality;
            //g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            Rectangle rect = this.ClientRectangle;
            Brush brhBorder = new SolidBrush(crBorderPainting);
            Brush brhRect = new SolidBrush(BackColor);
            Brush b0 = new SolidBrush(this.Parent.BackColor);
            Brush bfont = new SolidBrush(ForeColor);
            try
            {
                g.Clear(this.Parent.BackColor);
                try
                {
                    GraphicsPath path = CreateRoundRect(rect.Left, rect.Top, rect.Left + rect.Width, rect.Top + rect.Height);
                    g.FillPath(brhBorder, path);
                    path.Dispose();
                    path = CreateRoundRect(rect.Left, rect.Top, rect.Left + rect.Width, rect.Top + rect.Height);
                    g.FillPath(brhRect, path);
                    path.Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine("FillPath:" + e.Message);
                }
                if (this.Text != string.Empty)
                {
                    StringFormat sf = StringFormat.GenericTypographic;
                    sf.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
                    SizeF sizeoftext = g.MeasureString(this.Text, Font);
                    float tx = (float)((this.Width - sizeoftext.Width) / 2.0);
                    float ty = (float)((this.Height - sizeoftext.Height) / 2.0);
                    g.DrawString(this.Text, Font, bfont, tx, ty);
                }
            }
            finally
            {
                b0.Dispose();
                brhBorder.Dispose();
                brhRect.Dispose();
                bfont.Dispose();
            }
        }

        private GraphicsPath CreateRoundRect(float rleft, float rtop, float rwidth, float rheight)
        {
            float r = radius;
            if (rwidth < rheight)
            {
                if (radius > rwidth / 2f)
                    r = rwidth / 2f;
            }
            else
            {
                if (radius > rheight / 2f)
                    r = rheight / 2f;
            }

            GraphicsPath path;
            RectangleF rectRow = new RectangleF(rleft, rtop + r, rwidth, rheight - r * 2);
            RectangleF rectColumn = new RectangleF(rleft + r, rtop, rwidth - r * 2, rheight);
            path = new GraphicsPath(FillMode.Winding);
            path.AddRectangle(rectRow);
            path.AddRectangle(rectColumn);
            //左上
            path.AddEllipse(rleft, rtop, r * 2, r * 2);
            //右上
            path.AddEllipse(rleft + rwidth - r * 2, rtop, r * 2, r * 2);
            //左下
            path.AddEllipse(rleft, rtop + rheight - r * 2, r * 2, r * 2);
            //右下
            path.AddEllipse(rleft + rwidth - r * 2, rtop + rheight - r * 2, r * 2, r * 2);
            return path;
        }
    }
}
