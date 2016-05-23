using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFForm
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.WindowState = System.Windows.WindowState.Normal;
            this.WindowStyle = System.Windows.WindowStyle.ToolWindow;
            this.Width = 800;
            this.Height = 600;
            this.Title = "WPFForm";
        }
    }

    class CustomDrawing : Canvas
    {
        protected override void OnRender(DrawingContext dc)
        {
            // 너비
            double Width = this.ActualWidth;

            // 높이
            double Height = this.ActualHeight;

            // 샘플 그리기
            dc.DrawLine(new Pen(Brushes.Black, 2), new Point(0, 0), new Point(100, 100));
            
            // 실제 드로잉 영역





            //**************************




            base.OnRender(dc);
        }

    }

}
