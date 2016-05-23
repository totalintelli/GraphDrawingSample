using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 800;
            this.Height = 600;
            this.Text = "WinForm";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 너비
            float Width = panel1.Width;

            // 높이
            float Height = panel1.Height;

            // 실제 드로잉 영역
            // 마진
            Padding RectMargin = new System.Windows.Forms.Padding(30, 30, 30, 30);
            // 드로잉 너비
            float DrawingWidth = (panel1.ClientRectangle.Width - (RectMargin.Right + RectMargin.Left)) / 5;
            // 드로잉 높이
            float DrawingHeight = (panel1.ClientRectangle.Height - (RectMargin.Top + RectMargin.Bottom)) / 3;
            // 드로잉 너비의 두 배
            float DrawingWidthDouble = DrawingWidth * 2f;
            // 원을 그리는 사각형
            RectangleF CircleRect = new RectangleF(RectMargin.Left, RectMargin.Top, DrawingWidth, DrawingHeight);

            // 원을 그린다.
            e.Graphics.FillEllipse(new SolidBrush(Color.Purple), CircleRect);



            //**************************
        }
    }
}
