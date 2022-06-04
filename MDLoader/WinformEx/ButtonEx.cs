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
    public class ButtonEx : Button
    {
        public bool roundCorner = false;
        public float radius = 0.0f;
        private Color crBorderActive = Color.FromArgb(Convert.ToInt32("00FFFF", 16));
        private Color crRectActive = Color.FromArgb(Convert.ToInt32("FFE3F3FB", 16));
        private Color crBorderDefault = Color.FromArgb(215, 215, 215);
        public Color crBorderPainting { get; set; }
        public Color preColor;

        public ButtonEx() : base() { }

        public ButtonEx(bool roundCorner, float radius, Color crBorderPainting) : base()
        {
            this.radius = radius;
            this.roundCorner = roundCorner;
            this.crBorderPainting = crBorderPainting;
        }

        public void setActColor(Color crRectActive, Color preBackColor)
        {
            preColor = preBackColor;
            this.crRectActive = crRectActive;
        }

        public void setCorner(bool roundCorner, float radius, Color crBorderPainting)
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
                int borderSize = FlatAppearance.BorderSize;
                try
                {
                    GraphicsPath path = CreateRoundRect(rect.Left, rect.Top, rect.Left + rect.Width - borderSize, rect.Top + rect.Height - borderSize);
                    g.FillPath(brhBorder, path);
                    path.Dispose();
                    path = CreateRoundRect(rect.Left + borderSize / 2f, rect.Top + borderSize / 2f, rect.Left + rect.Width - borderSize * 2, rect.Top + rect.Height - borderSize * 2);
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

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = crRectActive;
            this.FlatAppearance.BorderColor = crBorderActive;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = Color.Gray;
            this.FlatAppearance.BorderColor = crBorderDefault;
        }
    }
}
