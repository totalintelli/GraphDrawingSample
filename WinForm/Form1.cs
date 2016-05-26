﻿using System;
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
            float DrawingWidth = (panel1.ClientRectangle.Width - (RectMargin.Right + RectMargin.Left)) / 5.4f;   // 5.4f는 드로잉의 너비의 비율로 고정값.
            // 드로잉 높이
            float DrawingHeight = (panel1.ClientRectangle.Height - (RectMargin.Top + RectMargin.Bottom)) / 3.2f; // 3.2f는 드로잉의 너비의 비율로 고정값.
            // 드로잉 구역의 간격의 너비
            float GapWidth = DrawingWidth * 0.1f;                                                                // 0.1f는 드로잉 구역의 간격의 너비의 비율로 고정값.
            // 드로잉 구역의 간격의 높이
            float GapHeight = DrawingHeight * 0.1f;                                                              // 0.1f는 드로잉 구역의 간격의 높이의 비율로 고정값.
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
                { new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.3f, RectMargin.Top + DrawingHeight * 0.1f),     // 계란 윗 부분의 왼쪽.0.3f과 0.1f는 계란의 윗부분의 위치를 나타내는 값으로 고정값.
                  new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.1f, RectMargin.Top + DrawingHeight * 3 / 4.0f), // 계란 중간 부분의 왼쪽.0.1f와 3 / 4.0f는 계란의 중간 부분의 위치를 나타내는 값으로 고정값.
                  new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.5f, RectMargin.Top + DrawingHeight),            // 계란의 아랫 부분.0.5f는 계란의 아랫 부분의 위치를 나타내는 값으로 고정값.
                  new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthDouble - DrawingWidth * 0.1f, RectMargin.Top + DrawingHeight * 3 / 4.0f), // 계란의 중간 부분의 오른쪽. 0.1f와 3 / 4.0f는 계란의 중간 부분의 위치를 나타내는 값으로 고정값.
                  new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.7f, RectMargin.Top + DrawingHeight * 0.1f)      // 계란의 윗부분의 오른쪽0.7f와 0.1f는 계란의 윗부분의 위치를 나타내는 값으로 고정값.
                };
            // 네 잎을 그리는 사각형
            // 북쪽 잎을 그리는 사각형
            RectangleF NorthLeafRect = new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.25f,                   // 0.25f는 북쪽 잎의 위치를 나타내는 값으로 고정값.
                                                        RectMargin.Top, DrawingWidth / 2.0f, DrawingHeight / 2.0f);                                   // 2.0f는 북쪽 잎의 너비와 높이의 비율로 고정값.
            // 동쪽 잎을 그리는 사각형
            RectangleF EastLeafRect = new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth / 2.0f,                     // 2.0f는 동쪽 잎의 위치를 나타내기 위한 값으로 고정값.
                                                        RectMargin.Top + DrawingHeight / 4.0f, DrawingWidth / 2.0f, DrawingHeight / 2.0f);            // 4.0f는 동쪽 잎의 위치를 나타내기 위한 값이고 
            // 남쪽 잎을 그리는 사각형                                                                                                                   // 2.0f는 동쪽 잎의 너비와 높이의 비율로 고정값.                
            RectangleF SouthLeafRect = new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.25f,                   // 0.25는 남쪽 잎의 위치를 나타내기 위한 값으로 고정값.
                                                        RectMargin.Top + DrawingHeight / 2.0f, DrawingWidth / 2.0f, DrawingHeight / 2.0f);            // 2.0f는 남쪽 잎의 위치를 나타내기 위안 값이자 너비와 높이의 비율로 고정값.
            // 서쪽 잎을 그리는 사각형
            RectangleF WestLeafRect = new RectangleF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top + DrawingHeight / 4.0f,    // 4.0f는 서쪽 잎의 위치를 나타내기 위한 값으로 고정값.
                                                        DrawingWidth / 2.0f, DrawingHeight / 2.0f);                                                   // 2.0f는 남쪽 잎의 너비와 높이의 비율로 고정값.
            // 곡선으로 이루어진 삼각형의 좌표
            PointF[] CurvilinearTrianglePoints =
                { new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.5f, RectMargin.Top),                                // 곡선으로 이루어진 삼각형의 위쪽.0.5f는 곡선으로 이루어진 삼각형의 위쪽 부분의 꼭지점 위치를 나타내기 위한 값으로 고정값.
                  new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad, RectMargin.Top + DrawingHeight * 3 / 4.0f),                           // 곡선으로 이루어진 삼각형의 중간 부분의 왼쪽. 3 / 4.0f는 곡선으로 이루어진 삼각형의 중간 부분의 왼쪽의 위치를 나타내기 위한 값으로 고정값
                  new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.5f, RectMargin.Top + DrawingHeight),                // 곡선으로 이루어진 삼각형의 아래 부분. 0.5f는 곡선으로 이루어진 삼각형의 아래 부분의 위치를 나타내기 위한 값으로 고정값.
                  new PointF(RectMargin.Left + DrawingWidthFifth + GapWidthQuad, RectMargin.Top + DrawingHeight * 3 / 4.0f)                           // 곡선으로 이루어진 삼각형의 중간 부분의 오른쪽. 3 / 4.0f는 곡선으로 이루어진 삼각형의 중간 부분의 위치를 나타내기 위한 값으로 고정값.
                };

            // 정사각형을 그리는 사각형
            PointF[] SquarePoints = CalculateVertices(4, DrawingWidth / 2.0f, 45.0f,                                                                  // 4: 변의 개수, DrawingWidth / 2.0f : 도형을 감싸는 원의 지름, 45.0f : 점을 찍기 시작하는 각도
                                                new PointF(RectMargin.Left + DrawingWidth * 0.5f,                                                     // 도형을 감싸는 원의 X좌표. 0.5f는 도형을 감싸는 원의 X좌표를 나타내기 위한 값으로 고정값.
                                                    RectMargin.Top + DrawingHeight + GapHeight + DrawingHeight * 0.5f));                              // 도형을 감싸는 원의 Y좌표. 0.5f는 도형을 감싸는 원의 Y좌표를 나타내기 위한 값으로 고정값.
            // 직사각형을 그리는 사각형
            RectangleF RectAngle = new RectangleF(RectMargin.Left + DrawingWidth + GapWidth + DrawingWidth * 0.15f,                                   // 0.15f는 직사각형의 X좌표를 구하기 위한 값으로 고정값.
                                                  RectMargin.Top + DrawingHeight + GapHeight, DrawingWidth * 0.7f, DrawingHeight);                    // 0.7f는 직사각형의 Y좌표를 구하기 위한 값으로 고정값.
            // 삼각형의 좌표
            PointF[] TrianglePoints = CalculateVertices(3, DrawingWidth / 2.0f, 90.0f,                                                                // 3: 변의 개수, DrawingWidth / 2.0f : 도형을 감싸는 원의 지름, 90.0f : 점을 찍기 시작하는 각도
                                        new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.5f,                       // 도형을 감싸는 원의 X좌표. 0.5f는 도형을 감싸는 원의 X좌표를 나타내기 위한 값으로 고정값.
                                                    RectMargin.Top + DrawingHeight + GapHeight + DrawingHeight * 0.5f));                              // 도형을 감싸는 원의 Y좌표. 0.5f는 도형을 감싸는 원의 Y좌표를 나타내기 위한 값으로 고정값.
            // 사다리꼴의 좌표
            PointF[] TrapezoidPoints =
            {
              new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeight + GapHeight),    // 사다리꼴의 왼쪽 위에 있는 꼭지점. 0.2f는 사다리꼴의 왼쪽 위에 있는 꼭지점의 위치를 정하기 위한 값으로 고정값.
              new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.8f, RectMargin.Top + DrawingHeight + GapHeight),    // 사다리꼴의 오른쪽 위에 있는 꼭지점. 0.8f는 사다리꼴의 오른쪽 위에 있는 꼭지점의 위치를 정하기 위한 값으로 고정값.
              new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthTriple, RectMargin.Top + DrawingHeightDouble + GapHeight),                      // 사다리꼴의 오른쪽 아래에 있는 꼭지점.    
              new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top + DrawingHeightDouble + GapHeight)                     // 사다리꼴의 왼쪽 아래에 있는 꼭지점.
            };
            // 마름모의 좌표
            PointF[] RhombusPoints =
            {
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.5f, RectMargin.Top + DrawingHeight + GapHeight),                        // 마름모의 위에 있는 꼭지점. 0.5f는 마름모의 위에 있는 꼭지점의 위치를 정하기 위한 값으로 고정값.
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.8f, RectMargin.Top + DrawingHeight + GapHeight + DrawingHeight * 0.5f), // 마름모의 중간의 오른쪽에 있는 꼭지점. 0.8f와 0.5f는 마름모의 중간의 오른쪽에 있는 꼭지점의 위치를 정하기 위한 값으로 고정값.
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.5f, RectMargin.Top + DrawingHeightDouble + GapHeight),                  // 마름모의 아래에 있는 꼭지점. 0.5f는 마름모의 아래에 있는 꼭지점의 위치를 정하기 위한 값으로 고정값.
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeight + GapHeight + DrawingHeight * 0.5f)  // 마름모의 중간의 왼쪽에 있는 꼭지점. 마름모의 0.2f, 0.f5는 마름모의 중간의 왼쪽에 있는 꼭지점의 위치를 정하기 위한 값으로 고정값.
            };
            // 오각형의 좌표
            PointF[] PentagonPoints = CalculateVertices(5, DrawingWidth / 2.0f, 90.0f,                                               // 5: 변의 개수, DrawingWidth / 2.0f : 도형을 감싸는 원의 지름, 90.0f : 점을 찍기 시작하는 각도
                                        new PointF(RectMargin.Left + DrawingWidth * 0.5f,                                            // 도형을 감싸는 원의 X좌표. 0.5f는 도형을 감싸는 원의 X좌표를 나타내기 위한 값으로 고정값.
                                                    RectMargin.Top + DrawingHeightDouble + GapHeightDouble + DrawingHeight * 0.5f)); // 도형을 감싸는 원의 Y좌표. 0.5f는 도형을 감싸는 원의 Y좌표를 나타내기 위한 값으로 고정값.
            // 육각형의 좌표
            PointF[] HexagonPoints = CalculateVertices(6, DrawingWidth / 2.0f, 90.0f,                                                // 6: 변의 개수, DrawingWidth / 2.0f : 도형을 감싸는 원의 지름, 90.0f : 점을 찍기 시작하는 각도
                                        new PointF(RectMargin.Left + DrawingWidth + GapWidth + DrawingWidth * 0.5f,                  // 도형을 감싸는 원의 X좌표. 0.5f는 도형을 감싸는 원의 X좌표를 나타내기 위한 값으로 고정값.
                                                    RectMargin.Top + DrawingHeightDouble + GapHeightDouble + DrawingHeight * 0.5f)); // 도형을 감싸는 원의 Y좌표. 0.5f는 도형을 감싸는 원의 Y좌표를 나타내기 위한 값으로 고정값.   
            // 팔각형의 좌표
            PointF[] OctagonPoints = CalculateVertices(8, DrawingWidth / 2.0f, 90.0f,                                                // 8: 변의 개수, DrawingWidth / 2.0f : 도형을 감싸는 원의 지름, 90.0f : 점을 찍기 시작하는 각도
                                        new PointF(RectMargin.Left + DrawingWidthDouble + GapWidthDouble + DrawingWidth * 0.5f,      // 도형을 감싸는 원의 X좌표. 0.5f는 도형을 감싸는 원의 X좌표를 나타내기 위한 값으로 고정값.
                                                    RectMargin.Top + DrawingHeightDouble + GapHeightDouble + DrawingHeight * 0.5f)); // 도형을 감싸는 원의 Y좌표. 0.5f는 도형을 감싸는 원의 Y좌표를 나타내기 위한 값으로 고정값.
            // 평행사변형의 좌표
            PointF[] ParallelogramPoints =
            {
                new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.2f, RectMargin.Top + DrawingHeightDouble + GapHeightDouble), // 평행사변형의 왼쪽 위에 있는 꼭지점. 0.2f는 평행사변형의 왼쪽 위에 있는 꼭지점의 위치를 나타내기 위한 값으로 고정값.
                new PointF(RectMargin.Left + DrawingWidthQuad + GapWidthTriple, RectMargin.Top + DrawingHeightDouble + GapHeightDouble),                         // 평행사변형의 오른쪽 위에 있는 꼭지점.
                new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple + DrawingWidth * 0.8f, RectMargin.Top + DrawingHeightTriple + GapHeightDouble), // 평행사변형의 오른쪽 아래에 있는 꼭지점.0.8f는 평행사변형의 오른쪽 아래에 있는 꼭지점의 위치를 나타내기 위한 값으로 고정값.
                new PointF(RectMargin.Left + DrawingWidthTriple + GapWidthTriple, RectMargin.Top + DrawingHeightTriple + GapHeightDouble),                       // 평행사변형의 왼쪽 아래에 있는 꼭지점.
            };
            // 초승달을 그리는 사각형
            RectangleF CrescentRect = new RectangleF(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.25f, // 초승달을 감싸는 사각형의 X좌표. 0.25는 초승달을 감싸는 사각형의 X좌표를 나타내기 위한 값으로 고정값.
                                                     RectMargin.Top + DrawingHeightDouble + GapHeightDouble,                   // 초승달을 감싸는 사각형의 Y좌표.
                                                     DrawingWidth, DrawingHeight);                                             // 초승달을 감싸는 사각형의 너비와 높이.
            // 반원의 첫 번째 부분의 각도
            float StartAngle = 90.0f; // 90.0f는 고정값임.
            // 반원의 두 번재 부분의 각도
            float SweepAngle = 180.0f; // 180.0f는 고정값임.
            // 초승달 모양을 만들기 위한 GraphicsPath
            GraphicsPath CrescentClipPath = new GraphicsPath();
            CrescentClipPath.AddEllipse(RectMargin.Left + DrawingWidthQuad + GapWidthQuad + DrawingWidth * 0.4f,        // 초승달 모양을 만드는 음각 틀의 X좌표. 0.4f는 초승달 모양을 만드는 음각 틀의 X좌표를 나타내기 위한 값으로 고정값.
                                        RectMargin.Top + DrawingHeightDouble + GapHeightDouble - DrawingHeight * 0.06f, // 초승달 모양을 만드는 음각 틀의 Y좌표. 0.06f는 초승달 모양을 만드는 음각 틀의 Y좌표를 나타내기 위한 값으로 고정값.               
                                        DrawingWidth * 1.3f, DrawingHeight * 1.15f);                                    // 초승달 모양을 만드는 음각틀의 너비와 높이. 1.3f는 초승달 모양을 만드는 음각 틀의 너비의 비율이고 1.1f는 초승달 모양을 만드는 음각 틀의 높이의 비율로 고정값.
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
            // 각도에 해당하는 좌표.
            PointF xy = new PointF();
            // 라디안을 구한다.
            double radians = Degrees * Math.PI / 180.0;

            // X 좌표를 구한다. 반지름이 1인 원으로 계산한다.
            xy.X = (float)Math.Cos(radians) * Radius + Origin.X;
            // Y 좌표를 구한다. 반지름이 1인 원으로 계산한다.
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

            // 각도에 해당하는 좌표들
            List<PointF> points = new List<PointF>();
            // 각도
            float step = 360.0f / Sides;
            // 길이가 1인 원의 중점과 평행한 선과 첫 번째 점의 각도
            float angle = startingAngle;

            // 한 바퀴를 돈다.
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) 
            {
                // 각도에 해당하는 좌표들을 구한다.
                points.Add(DegreesToXY(angle, Radius, Center)); 
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
