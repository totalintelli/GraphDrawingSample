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
            float DrawingWidth = (panel1.ClientRectangle.Width - (RectMargin.Right + RectMargin.Left)) / 5.4f;
            // 드로잉 높이
            float DrawingHeight = (panel1.ClientRectangle.Height - (RectMargin.Top + RectMargin.Bottom)) / 3.2f;
            // 드로잉 구역의 간격의 너비
            float GapWidth = DrawingWidth * 0.1f;
            // 드로잉 구역의 간격의 높이
            float GapHeight = DrawingHeight * 0.1f;
            // 드로잉 너비의 2배
            float DrawingWidthDouble = DrawingWidth * 2.0f;
            // 드로잉 너비의 3배
            float DrawingWidthTriple = DrawingWidth * 3.0f;
            // 드로잉 너비의 4배
            float DrawingWidthQuard = DrawingWidth * 4.0f;
            // 드로잉 너비의 5배
            float DrawingWidthFifth = DrawingWidth * 5.0f;
            // 드로잉 높이의 2배
            float DrawingHeightDouble = DrawingHeight * 2.0f;
            // 드로잉 높이의 3배
            float DrawingHeightTriple = DrawingHeight * 3.0f;
            // 드로잉 구역의 간격의 너비의 2배
            float GapWidthDouble = GapWidth * 2.0f;
            // 드로잉 구역의 간격의 너비의 3배
            float GapWidthTriple = GapWidth * 3.0f;
            // 드로잉 구역의 간격의 너비의 4배
            float GapWidthQuad = GapWidth * 4.0f;
            // 드로잉 구역의 간격의 너비의 5배
            float GapWidthFifth = GapWidth * 5.0f;
            // 드로잉 구역의 간격의 높이의 2배
            float GapHeightDouble = GapHeight * 2.0f;
            // 드로잉 구역의 간격의 높이의 3배 
            float GapHeightTriple = GapHeight * 3.0f;

            // 드로잉 구역
            RectangleF[] Rects =
            {
                new RectangleF(RectMargin.Left, RectMargin.Top, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidth + GapWidth, RectMargin.Top, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble, RectMargin.Top, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthQuard + GapWidthQuad, RectMargin.Top, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left, RectMargin.Top + DrawingHeight + GapHeight, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidth + GapWidth, RectMargin.Top + DrawingHeight + GapHeight, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble, RectMargin.Top + DrawingHeight + GapHeight, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top + DrawingHeight + GapHeight, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthQuard + GapWidthQuad, RectMargin.Top + DrawingHeight + GapHeight, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left, RectMargin.Top + DrawingHeightDouble + GapHeightDouble, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidth + GapWidth, RectMargin.Top + DrawingHeightDouble + GapHeightDouble, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble, RectMargin.Top + DrawingHeightDouble + GapHeightDouble, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top + DrawingHeightDouble + GapHeightDouble, DrawingWidth, DrawingHeight),
                new RectangleF(RectMargin.Left + DrawingWidthQuard + GapWidthQuad, RectMargin.Top + DrawingHeightDouble + GapHeightDouble, DrawingWidth, DrawingHeight),
            };
            // 도형들의 색상
            SolidBrush FigureColor = new SolidBrush(Color.Purple);
            // 원을 그리는 사각형
            RectangleF CircleRect = new RectangleF(RectMargin.Left, RectMargin.Top, DrawingWidth, DrawingHeight);
            // 타원을 그리는 사각형
            RectangleF EllipseRect = new RectangleF(RectMargin.Left + DrawingWidth * 1.2f, RectMargin.Top, DrawingWidth * 0.7f, DrawingHeight * 0.9f);
            // 계란을 그리는 사각형
            // 네잎을 그리는 사각형
            // 곡선으로 이루어진 삼각형을 그리는 사각형
            // 사각형을 그리는 사각형
            RectangleF Rect = new RectangleF(RectMargin.Left, RectMargin.Top + DrawingHeight * 1.2f, DrawingWidth * 0.9f, DrawingHeight * 0.9f);
            // 직사각형을 그리는 사각형
            RectangleF RectAngle = new RectangleF(RectMargin.Left + DrawingWidth * 1.2f, RectMargin.Top + DrawingHeight * 1.2f, DrawingWidth * 0.7f, DrawingHeight * 0.9f);
            // 삼각형의 좌표
            PointF[] TrianglePoints = {
                new PointF(RectMargin.Left + DrawingWidth * 2.5f, RectMargin.Top + DrawingHeight * 1.2f),
                new PointF(RectMargin.Left + DrawingWidth * 2.2f, RectMargin.Top + DrawingHeight * 2.1f),
                new PointF(RectMargin.Left + DrawingWidth * 2.8f, RectMargin.Top + DrawingHeight * 2.1f)
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
            PointF[] HexagonPoints =
            {
                new PointF(RectMargin.Left + DrawingWidth + DrawingWidth / 4.0f, RectMargin.Top + DrawingHeight * 2.2f),
                new PointF(RectMargin.Left + DrawingWidth + DrawingWidth * 3 / 4.0f, RectMargin.Top + DrawingHeight * 2.2f),
                new PointF(RectMargin.Left + DrawingWidth * 2.0f, RectMargin.Top + DrawingHeight * 2.0f + DrawingHeight * 4 / 7.0f),
                new PointF(RectMargin.Left + DrawingWidth + DrawingWidth * 3 / 4.0f, RectMargin.Top + DrawingHeight * 2.9f),
                new PointF(RectMargin.Left + DrawingWidth + DrawingWidth / 4.0f, RectMargin.Top + DrawingHeight * 2.9f),
                new PointF(RectMargin.Left + DrawingWidth, RectMargin.Top + DrawingHeight * (2.0f + 4 / 7.0f))
            };
            // 팔각형의 좌표
            PointF[] OctagonPoints =
            {
                new PointF(RectMargin.Left + DrawingWidth * 2.0f + DrawingWidth / 3.0f, RectMargin.Top + DrawingHeight * 2.2f),
                new PointF(RectMargin.Left + DrawingWidth * 2.0f + DrawingWidth * 2 / 3.0f, RectMargin.Top + DrawingHeight * 2.2f),
                new PointF(RectMargin.Left + DrawingWidth * 2.8f, RectMargin.Top + DrawingHeight * 2.0f + DrawingHeight / 3.0f),
                new PointF(RectMargin.Left + DrawingWidth * 2.8f, RectMargin.Top + DrawingHeight * 2.0f + DrawingHeight * 2 / 3.0f),
                new PointF(RectMargin.Left + DrawingWidth * 2 + DrawingWidth * 2 / 3.0f, DrawingHeight * 3.07f),
                new PointF(RectMargin.Left + DrawingWidth * 2 + DrawingWidth / 3.0f, DrawingHeight * 3.07f),
                new PointF(RectMargin.Left + DrawingWidth * 2 + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeight * 2.0f + DrawingHeight * 2 / 3.0f),
                new PointF(RectMargin.Left + DrawingWidth * 2 + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeight * 2.0f + DrawingHeight * 1/ 7.0f)

            };

            // 평행사변형의 좌표
            // 초승달을 그리는 사각형

            // 드로잉 구역을 그린다.
            e.Graphics.DrawRectangles(Pens.Black, Rects);

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
            e.Graphics.FillPolygon(FigureColor, HexagonPoints);

            // 팔각형을 그린다.
            e.Graphics.FillPolygon(FigureColor, OctagonPoints);

            // 평행사변형을 그린다.
            // 초승달을 그린다.



            //**************************
        }
    }
}
