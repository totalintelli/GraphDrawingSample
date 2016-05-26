using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            float DrawingWidthQuad = DrawingWidth * 4.0f;
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

            // 도형들의 색상
            SolidBrush FigureColor = new SolidBrush(Color.Purple);
            // 원을 그리는 사각형
            RectangleF CircleRect = new RectangleF(RectMargin.Left, RectMargin.Top, DrawingWidth, DrawingHeight);
            // 타원을 그리는 사각형
            RectangleF EllipseRect = new RectangleF(RectMargin.Left + DrawingWidth + GapWidth + DrawingWidth * 0.15f, RectMargin.Top, DrawingWidth * 0.7f, DrawingHeight);
            // 계란의 좌표
            PointF[] OvalPoints =
                { new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.3f, RectMargin.Top + DrawingHeight * 0.1f),
                  new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.1f, RectMargin.Top + DrawingHeight * 3 / 4.0f),
                  new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.5f, RectMargin.Top + DrawingHeight),
                  new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthDouble - DrawingWidth * 0.1f, RectMargin.Top + DrawingHeight * 3 / 4.0f),
                  new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.7f, RectMargin.Top + DrawingHeight * 0.1f)
                };
            // 네 잎을 그리는 사각형
            // 북쪽 잎을 그리는 사각형
            RectangleF NorthLeafRect = new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.25f, 
                                                        RectMargin.Top, DrawingWidth / 2.0f, DrawingHeight / 2.0f);
            // 동쪽 잎을 그리는 사각형
            RectangleF EastLeafRect = new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth / 2.0f,
                                                        RectMargin.Top + DrawingHeight / 4.0f, DrawingWidth / 2.0f, DrawingHeight / 2.0f);
            // 남쪽 잎을 그리는 사각형
            RectangleF SouthLeafRect = new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.25f,
                                                        RectMargin.Top + DrawingHeight / 2.0f, DrawingWidth / 2.0f, DrawingHeight / 2.0f);
            // 서쪽 잎을 그리는 사각형
            RectangleF WestLeafRect = new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top + DrawingHeight / 4.0f,
                                                        DrawingWidth / 2.0f, DrawingHeight / 2.0f);
            // 곡선으로 이루어진 삼각형의 좌표
            PointF[] CurvilinearTrianglePoints =
                { new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.5f, RectMargin.Top),
                  new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad, RectMargin.Top + DrawingHeight * 3 / 4.0f),
                  new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.5f, RectMargin.Top + DrawingHeight),
                  new PointF(RectMargin.Left + DrawingWidthFifth + GapWidthQuad, RectMargin.Top + DrawingHeight * 3 / 4.0f)
                };

            // 정사각형을 그리는 사각형
            PointF[] SquarePoints = CalculateVertices(4, DrawingWidth / 2.0f, 45.0f,
                                                new PointF(RectMargin.Left + DrawingWidth / 2.0f,
                                                    RectMargin.Top + DrawingHeight + GapHeight + DrawingHeight * 0.5f));
            // 직사각형을 그리는 사각형
            RectangleF RectAngle = new RectangleF(RectMargin.Left + DrawingWidth + GapWidth + DrawingWidth * 0.15f, RectMargin.Top + DrawingHeight + GapHeight, DrawingWidth * 0.7f, DrawingHeight);
            // 삼각형의 좌표
            PointF[] TrianglePoints = CalculateVertices(3, DrawingWidth / 2.0f, 90.0f, 
                                        new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.5f, 
                                                    RectMargin.Top + DrawingHeight + GapHeight + DrawingHeight * 0.5f));
            // 사다리꼴의 좌표
            PointF[] TrapezoidPoints =
            {
              new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeight + GapHeight),
              new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.8f, RectMargin.Top + DrawingHeight + GapHeight),
              new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthTriple, RectMargin.Top + DrawingHeightDouble + GapHeight),
              new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top + DrawingHeightDouble + GapHeight)
            };
            // 마름모의 좌표
            PointF[] RhombusPoints =
            {
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.5f, RectMargin.Top + DrawingHeight + GapHeight),
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.8f, RectMargin.Top + DrawingHeight + GapHeight + DrawingHeight * 0.5f),
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.5f, RectMargin.Top + DrawingHeightDouble + GapHeight),
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeight + GapHeight + DrawingHeight * 0.5f)
            };
            // 오각형의 좌표
            PointF[] PentagonPoints = CalculateVertices(5, DrawingWidth / 2.0f, 90.0f,
                                        new PointF(RectMargin.Left + DrawingWidth / 2.0f,
                                                    RectMargin.Top + DrawingHeightDouble + GapHeightDouble + DrawingHeight * 0.5f));
            // 육각형의 좌표
            PointF[] HexagonPoints = CalculateVertices(6, DrawingWidth / 2.0f, 90.0f,
                                        new PointF(RectMargin.Left + DrawingWidth + GapWidth + DrawingWidth / 2.0f,
                                                    RectMargin.Top + DrawingHeightDouble + GapHeightDouble + DrawingHeight * 0.5f));
            // 팔각형의 좌표
            PointF[] OctagonPoints = CalculateVertices(8, DrawingWidth / 2.0f, 90.0f,
                                        new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth / 2.0f,
                                                    RectMargin.Top + DrawingHeightDouble + GapHeightDouble + DrawingHeight * 0.5f));
            // 평행사변형의 좌표
            PointF[] ParallelogramPoints =
            {
                new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeightDouble + GapHeightDouble),
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthTriple, RectMargin.Top + DrawingHeightDouble + GapHeightDouble),
                new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.8f, RectMargin.Top + DrawingHeightTriple + GapHeightDouble),
                new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top + DrawingHeightTriple + GapHeightDouble),
            };
            // 초승달을 그리는 사각형
            RectangleF CrescentRect = new RectangleF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.25f, 
                                                     RectMargin.Top + DrawingHeightDouble + GapHeightDouble,
                                                     DrawingWidth, DrawingHeight);
            // 반원의 첫 번째 부분의 각도
            float StartAngle = 90.0f; // 270.0f는 고정값임.
            // 반원의 두 번재 부분의 각도
            float SweepAngle = 180.0f; // 180.0f는 고정값임.
            // 초승달 모양을 만들기 위한 GraphicsPath
            GraphicsPath CrescentClipPath = new GraphicsPath();
            CrescentClipPath.AddEllipse(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.4f, 
                                        RectMargin.Top + DrawingHeightDouble + GapHeightDouble - DrawingHeight * 0.06f,
                                        DrawingWidth * 1.3f, DrawingHeight * 1.15f);
            // 그래픽 컨테이너에 초승달을 넣는다. 
            GraphicsContainer ContainerState = e.Graphics.BeginContainer();

            if(Width > 0 && Height > 0)
            {
                // 원을 그린다.
                e.Graphics.FillEllipse(FigureColor, CircleRect);

                // 타원을 그린다.
                e.Graphics.FillEllipse(FigureColor, EllipseRect);

                // 계란을 그린다.
                e.Graphics.FillClosedCurve(FigureColor, OvalPoints);

                // 네 잎을 그린다.
                // 북쪽에 있는 잎을 그린다.
                e.Graphics.FillEllipse(FigureColor, NorthLeafRect);
                // 동쪽에 있는 잎을 그린다.
                e.Graphics.FillEllipse(FigureColor, EastLeafRect);
                // 남쪽에 있는 잎을 그린다.
                e.Graphics.FillEllipse(FigureColor, SouthLeafRect);
                // 서쪽에 있는 잎을 그린다.
                e.Graphics.FillEllipse(FigureColor, WestLeafRect);

                // 곡선으로 이루어진 삼각형을 그린다.
                e.Graphics.FillClosedCurve(FigureColor, CurvilinearTrianglePoints);

                // 정사각형을 그린다.
                e.Graphics.FillPolygon(FigureColor, SquarePoints);

                // 직사각형을 그린다.
                e.Graphics.FillRectangle(FigureColor, RectAngle);
                // 삼각형을 그린다.
                e.Graphics.FillPolygon(FigureColor, TrianglePoints);

                // 사다리꼴을 그린다.
                e.Graphics.FillRegion(FigureColor,
                                        new Region(new GraphicsPath(TrapezoidPoints,
                                                    new byte[] { (byte)PathPointType.Start, (byte)PathPointType.Line,
                                                                 (byte)PathPointType.Line, (byte) PathPointType.Line})));

                // 마름모를 그린다.
                e.Graphics.FillRegion(FigureColor, 
                                        new Region(new GraphicsPath(RhombusPoints, 
                                                    new byte[] { (byte)PathPointType.Start, (byte)PathPointType.Line,
                                                                 (byte)PathPointType.Line, (byte) PathPointType.Line})));
                // 오각형을 그린다.
                e.Graphics.FillPolygon(FigureColor, PentagonPoints);

                // 육각형을 그린다.
                e.Graphics.FillPolygon(FigureColor, HexagonPoints);

                // 팔각형을 그린다.
                e.Graphics.FillPolygon(FigureColor, OctagonPoints);

                // 평행사변형을 그린다.
                e.Graphics.FillRegion(FigureColor,
                                        new Region(new GraphicsPath(ParallelogramPoints,
                                                    new byte[] { (byte)PathPointType.Start, (byte)PathPointType.Line,
                                                                 (byte)PathPointType.Line, (byte) PathPointType.Line})));

                // 초승달을 그린다.
                if (CrescentRect.Width > 0 && CrescentRect.Height > 0)
                {
                    // 초승달 문양을 만든다.
                    e.Graphics.SetClip(CrescentClipPath, CombineMode.Exclude);
                    // 반원을 그린다.
                    e.Graphics.FillPie(FigureColor, CrescentRect.X, CrescentRect.Y, CrescentRect.Width, CrescentRect.Height, StartAngle, SweepAngle);
                    // 그래픽 컨테이너를 끝낸다.
                    e.Graphics.EndContainer(ContainerState);
                }

            }

            //**************************
        }

        # region 정다각형의 좌표를 구하기
        /// <summary>
        /// 중점으로 부터의 각도에 해당하는 좌표를 계산한다.(0도는 오른쪽에 있다.)
        /// </summary>

        private PointF DegreesToXY(float Degrees, float Radius, PointF Origin)
        {
            PointF xy = new PointF();
            double radians = Degrees * Math.PI / 180.0;

            xy.X = (float)Math.Cos(radians) * Radius + Origin.X;
            xy.Y = (float)Math.Sin(-radians) * Radius + Origin.Y;

            return xy;
        }

        /// <summary>
        /// 중점으로 부터의 각도에 해당하는 좌표들을 계산한다.(0도는 오른쪽에 있다.)
        /// </summary>
        private PointF[] CalculateVertices(int Sides, float Radius, float startingAngle, PointF Center)
        {
            if (Sides < 3)
                throw new ArgumentException("다각형의 변의 개수는 3개 이상이어야 합니다.");

            List<PointF> points = new List<PointF>();
            float step = 360.0f / Sides;

            float angle = startingAngle; //starting angle
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) //go in a full circle
            {
                points.Add(DegreesToXY(angle, Radius, Center)); //code snippet from above
                angle += step;
            }

            return points.ToArray();
        }
        #endregion

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
