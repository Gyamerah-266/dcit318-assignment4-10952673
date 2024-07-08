using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing_Canvas
{
    public partial class DrawingForm : Form
    {
        private bool drawing = false;
        private Point startPoint;
        private Point endPoint;

        public DrawingForm()
        {
            InitializeComponent();
        }

        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                startPoint = e.Location;
            }
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                endPoint = e.Location;
                this.Invalidate();
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = false;
                endPoint = e.Location;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (drawing)
            {
                e.Graphics.DrawLine(Pens.Black, startPoint, endPoint);
            }
        }
    }
}

