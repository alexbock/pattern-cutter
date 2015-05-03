using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace pattern_cutter
{
    public partial class ImageRegionSelector : UserControl
    {
        public ImageRegionSelector()
        {
            InitializeComponent();
            DottedOutlineWhite = new Pen(Color.White);
            DottedOutlineWhite.DashPattern = new float[] { 4, 4 };
            DottedOutlineBlack = new Pen(Color.Black);
            DottedOutlineWhiteTransparent = new Pen(Color.FromArgb(128, 255, 255, 255));
            DottedOutlineWhiteTransparent.DashPattern = new float[] { 4, 4 };
            DottedOutlineBlackTransparent = new Pen(Color.FromArgb(128, 0, 0, 0));
        }

        private Pen DottedOutlineWhite;
        private Pen DottedOutlineBlack;
        private Pen DottedOutlineWhiteTransparent;
        private Pen DottedOutlineBlackTransparent;

        enum Mode { None, Select, Translate }
        public enum SelectModeOrigin { Corner, Center }

        public Image Source { get; set; }
        public Rectangle Selection { get; private set; }
        public SelectModeOrigin SelectionOrigin { get; set; }
        public Configuration Config { get; set; } = new Configuration();

        private Point currentSelectionStart;
        private Point currentSelectionEnd;
        private Rectangle currentSelection
        {
            get
            {
                // create a rectangle where the selection points are corners
                Point start = currentSelectionStart;
                Point end = currentSelectionEnd;
                start = TranslateMouseToImage(start);
                end = TranslateMouseToImage(end);
                bool centerMode = SelectionOrigin == SelectModeOrigin.Center;
                if ((ModifierKeys & Keys.Control) == Keys.Control) centerMode = !centerMode;
                if (centerMode)
                {
                    // determine the northwest and southeast corners of the inscribing square
                    int radius = (int)Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
                    Point a = new Point(start.X - radius, start.Y - radius);
                    Point b = new Point(start.X + radius, start.Y + radius);
                    start = a;
                    end = b;
                }
                else
                {
                    // constrain the end point to force a square
                    int diffX = end.X - start.X;
                    int diffY = end.Y - start.Y;
                    int diff = Math.Min(Math.Abs(diffX), Math.Abs(diffY));
                    end.X = start.X + Math.Sign(diffX) * diff;
                    end.Y = start.Y + Math.Sign(diffY) * diff;
                }
                Point[] points = new Point[4];
                points[0] = start;
                points[1] = end;
                points[2] = new Point(start.X, end.Y);
                points[3] = new Point(end.X, start.Y);
                points = points.OrderBy(point => point.Y).ThenBy(point => point.X).ToArray();
                Rectangle rect = new Rectangle(points[0], new Size(points[1].X - points[0].X, points[2].Y - points[0].Y));
                return rect;
            }
        }

        private Point dragStart;
        private Point dragEnd;

        private Mode mode = Mode.None;
        private Rectangle ImageDestination
        {
            get
            {
                // scale the image proportionally and center it to fill the viewport
                double widthScale = (double)Width / Source.Width;
                double heightScale = (double)Height / Source.Height;
                double scale = Math.Min(widthScale, heightScale);
                int drawWidth = (int)(Source.Width * scale);
                int drawHeight = (int)(Source.Height * scale);
                int drawX = Width / 2 - drawWidth / 2;
                int drawY = Height / 2 - drawHeight / 2;
                return new Rectangle(drawX, drawY, drawWidth, drawHeight);
            }
        }

        private static MouseButtons GetButtonForMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.None: return MouseButtons.None;
                case Mode.Select: return MouseButtons.Left;
                case Mode.Translate: return MouseButtons.Right;
                default: throw new InvalidEnumArgumentException();
            }
        }

        private static Mode GetModeForButton(MouseButtons buttons)
        {
            switch (buttons)
            {
                case MouseButtons.None: return Mode.None;
                case MouseButtons.Left: return Mode.Select;
                case MouseButtons.Right: return Mode.Translate;
                default: return Mode.None;
            }
        }

        private Point TranslateMouseToImage(Point m)
        {
            Rectangle dest = ImageDestination;
            m.X -= (Width - ImageDestination.Width) / 2;
            m.Y -= (Height - ImageDestination.Height) / 2;
            m.X = (int)((double)Source.Width / dest.Width * m.X);
            m.Y = (int)((double)Source.Height / dest.Height * m.Y);
            return m;
        }

        private Rectangle TranslateImageToMouse(Rectangle r)
        {
            Rectangle dest = ImageDestination;
            r.X = (int)((double)dest.Width / Source.Width * r.X);
            r.X += (Width - ImageDestination.Width) / 2;
            r.Y = (int)((double)dest.Height / Source.Height * r.Y);
            r.Y += (Height - ImageDestination.Height) / 2;
            r.Width = (int)((double)dest.Width / Source.Width * r.Width);
            r.Height = (int)((double)dest.Height / Source.Height * r.Height);
            return r;
        }

        private void DrawSelectionOutline(Graphics g, Rectangle rect)
        {
            rect = TranslateImageToMouse(rect);
            g.DrawEllipse(DottedOutlineBlack, rect);
            g.DrawEllipse(DottedOutlineWhite, rect);
            int overscanWidth = (int)(Config.DefaultOverscan * rect.Width);
            int overscanHeight = (int)(Config.DefaultOverscan * rect.Height);
            rect.Width += overscanWidth;
            rect.Height += overscanHeight;
            rect.X -= overscanWidth / 2;
            rect.Y -= overscanHeight / 2;
            g.DrawRectangle(DottedOutlineBlackTransparent, rect);
            g.DrawRectangle(DottedOutlineWhiteTransparent, rect);
        }

        private void ImageRegionSelector_Paint(object sender, PaintEventArgs e)
        {
            if (Source == null)
            {
                e.Graphics.FillRectangle(Brushes.Magenta, ClientRectangle);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Gray, ClientRectangle);
                e.Graphics.DrawImage(Source, ImageDestination);
                if (mode == Mode.Select)
                {
                    DrawSelectionOutline(e.Graphics, currentSelection);
                }
                else
                {
                    Rectangle selection = Selection;
                    if (mode == Mode.Translate)
                    {
                        selection.X += (dragEnd.X - dragStart.X);
                        selection.Y += (dragEnd.Y - dragStart.Y);
                    }
                    DrawSelectionOutline(e.Graphics, selection);
                }
            }
        }

        private void ImageRegionSelector_MouseDown(object sender, MouseEventArgs e)
        {
            if (mode != Mode.None) return;
            mode = GetModeForButton(e.Button);
            if (mode == Mode.Select)
            {
                currentSelectionStart = e.Location;
                currentSelectionEnd = currentSelectionStart;
            }
            else if (mode == Mode.Translate)
            {
                dragStart = e.Location;
                dragEnd = dragStart;
            }
        }

        private void ImageRegionSelector_MouseUp(object sender, MouseEventArgs e)
        {
            if (mode == Mode.Select)
            {
                Selection = currentSelection;
            }
            else if (mode == Mode.Translate)
            {
                Point p = new Point(Selection.X + (dragEnd.X - dragStart.X), Selection.Y + (dragEnd.Y - dragStart.Y));
                Selection = new Rectangle(p, Selection.Size);
            }
            mode = Mode.None;
            Invalidate();
        }

        private void ImageRegionSelector_MouseMove(object sender, MouseEventArgs e)
        {
            if (mode == Mode.Select)
            {
                currentSelectionEnd = e.Location;
                Invalidate();
            }
            else if (mode == Mode.Translate)
            {
                dragEnd = e.Location;
                Invalidate();
            }
        }

        private void ImageRegionSelector_MouseLeave(object sender, EventArgs e)
        {
            mode = Mode.None;
            Invalidate();
        }

        private void ImageRegionSelector_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ImageRegionSelector_KeyDown(object sender, KeyEventArgs e)
        {
            Invalidate();
        }

        private void ImageRegionSelector_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }
    }
}
