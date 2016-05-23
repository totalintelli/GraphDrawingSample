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
            // 도형들의 색상
            SolidBrush FigureColor = new SolidBrush(Color.Purple);
            // 원을 그리는 사각형
            RectangleF CircleRect = new RectangleF(RectMargin.Left, RectMargin.Top, DrawingWidth * 0.9f, DrawingHeight * 0.9f);
            // 타원을 그리는 사각형
            RectangleF EllipseRect = new RectangleF(RectMargin.Left + DrawingWidth * 1.5f, RectMargin.Top, DrawingWidth * 0.9f /  2, DrawingHeight * 0.9f);
            // 계란을 그리는 사각형
            // 네잎을 그리는 사각형
            // 곡선으로 이루어진 삼각형을 그리는 사각형
            // 사각형을 그리는 사각형
            RectangleF Rect = new RectangleF(RectMargin.Left, RectMargin.Top + DrawingHeight * 1.2f, DrawingWidth * 0.9f, DrawingHeight * 0.9f);
            // 직사각형을 그리는 사각형
            RectangleF RectAngle = new RectangleF(RectMargin.Left + DrawingWidth * 1.5f, RectMargin.Top + DrawingHeight * 1.2f, DrawingWidth * 0.5f, DrawingHeight * 0.9f);
            // 삼각형의 좌표
            PointF[] TrianglePoints = {
                new PointF(RectMargin.Left + DrawingWidth * 2.5f, RectMargin.Top + DrawingHeight * 1.2f),
                new PointF(RectMargin.Left + DrawingWidth * 2.3f, RectMargin.Top + DrawingHeight * 2.1f),
                new PointF(RectMargin.Left + DrawingWidth * 2.7f, RectMargin.Top + DrawingHeight * 2.1f)
            };
            // 사다리꼴의 좌표
            // 마름모를 그리는 사각형
            // 오각형의 좌표
            PointF[] PentagonPoints =
            {
                new PointF(RectMargin.Left, RectMargin.Top + DrawingHeight * 2.5f),
                new PointF(RectMargin.Left + DrawingWidth * 0.45f, RectMargin.Top + DrawingHeight * 2.2f),
                new PointF(RectMargin.Left + DrawingWidth * 0.9f, RectMargin.Top + DrawingHeight * 2.5f),
                new PointF(RectMargin.Left + DrawingWidth * 0.7f, RectMargin.Top + DrawingHeight * 2.9f),
                new PointF(RectMargin.Left + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeight * 2.9f)
            };
            // 육각형의 좌표
            // 팔각형의 좌표
            // 평행사변형의 좌표
            // 초승달을 그리는 사각형

            // 원을 그린다.
            e.Graphics.FillEllipse(FigureColor, CircleRect);

            // 타원을 그린다.
            e.Graphics.FillEllipse(FigureColor, EllipseRect);

            // 계란을 그린다.
            // 네 잎을 그린다.
            // 곡선으로 이루어진 삼각형을 그린다.

            // 사각형을 그린다.
            e.Graphics.FillRectangle(FigureColor, Rect);

            // 직사각형을 그린다.
            e.Graphics.FillRectangle(FigureColor, RectAngle);
            // 삼각형을 그린다.
            e.Graphics.FillPolygon(FigureColor, TrianglePoints);

            // 사다리꼴을 그린다.
            // 마름모를 그린다.
            // 오각형을 그린다.
            e.Graphics.FillPolygon(FigureColor, PentagonPoints);

            // 육각형을 그린다.
            // 팔각형을 그린다.
            // 평행사변형을 그린다.
            // 초승달을 그린다.

            

            //**************************
        }
    }
}
