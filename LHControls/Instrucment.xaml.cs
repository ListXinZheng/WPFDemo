using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LHControls
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class Instrucment : UserControl
    {


        public Brush PlateBackground
        {
            get { return (Brush)GetValue(plateBackgroundProperty); }
            set { SetValue(plateBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for plateBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty plateBackgroundProperty =
            DependencyProperty.Register("plateBackground", typeof(Brush), typeof(Instrucment), new PropertyMetadata(default(Brush)));


        /// <summary>
        /// 仪表盘的值
        /// </summary>
        public int Value
        {
            get { return (int)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty,value); }
        }
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(Instrucment),
             new PropertyMetadata(default(int),new PropertyChangedCallback(OnpropertyChanged)) );




        public int MaxValue
        {
            get { return (int)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(int), typeof(Instrucment), new PropertyMetadata(default(int), 
                new PropertyChangedCallback(OnpropertyChanged)));
        public int MinValue
        {
            get { return (int)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(int), typeof(Instrucment), new PropertyMetadata(default(int), new PropertyChangedCallback(OnpropertyChanged)));



        public int Interval
        {
            get { return (int)GetValue(IntervalProperty); }
            set
            {
                SetValue(IntervalProperty, value);
                if (value<=5)
                {
                    SetValue(IntervalProperty,5);
                }
            }
        }

        // Using a DependencyProperty as the backing store for Interval.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IntervalProperty =
            DependencyProperty.Register("Interval", typeof(int), typeof(Instrucment), new PropertyMetadata(default(int), new PropertyChangedCallback(OnpropertyChanged)));



        public int TextFontSize
        {
            get { return (int)GetValue(TextFontSizeProperty); }
            set { SetValue(TextFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextFontSizeProperty =
            DependencyProperty.Register("TextFontSize", typeof(int), typeof(Instrucment), new PropertyMetadata(0, new PropertyChangedCallback(OnpropertyChanged)));



        public Brush PointerBackGround
        {
            get { return (Brush)GetValue(PointerBackGroundProperty); }
            set { SetValue(PointerBackGroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PointerBackGround.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PointerBackGroundProperty =
            DependencyProperty.Register("PointerBackGround", typeof(Brush), typeof(Instrucment), new PropertyMetadata(default(Brush)));



        public Brush TextForeGround
        {
            get { return (Brush)GetValue(TextForeGroundProperty); }
            set { SetValue(TextForeGroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextForeGround.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextForeGroundProperty =
            DependencyProperty.Register("TextForeGround", typeof(Brush), typeof(Instrucment), new PropertyMetadata(default(Brush)));



        public Brush LineShowColor
        {
            get { return (Brush)GetValue(LineShowColorProperty); }
            set { SetValue(LineShowColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LineShowColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LineShowColorProperty =
            DependencyProperty.Register("LineShowColor", typeof(Brush), typeof(Instrucment), new PropertyMetadata(default(Brush)));


        public static void OnpropertyChanged(DependencyObject d,DependencyPropertyChangedEventArgs e )
        {
            (d as Instrucment).Refresh();
        }
        public Instrucment()
        {
            InitializeComponent();
            this.SizeChanged += Instrucment_SizeChanged;
        }

        private void Instrucment_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double misize = Math.Min(this.RenderSize. Width,this.RenderSize. Height);
            Circle.Width = Circle.Height = misize;

        }
        private void Refresh()
        {
            double radius = this.Circle.Width / 2;
            if (double.IsNaN(radius))
            {
                return;
            }
            this.maincanvas.Children.Clear();
            int interval = this.Interval <= 5 ? 5 : this.Interval;
            double step = 270.0 / (MaxValue - MinValue);
            for (int i = 0; i <= MaxValue - MinValue; i++)
            {
                Line linescale;
                if (i % interval == 0)
                {
                    linescale = new Line();
                    linescale.X1 = radius - (radius - 20 ) * Math.Cos((i * step - 45) * Math.PI / 180);
                    linescale.Y1 = radius - (radius - 20 ) * Math.Sin((i * step - 45) * Math.PI / 180);
                    linescale.X2 = radius - (radius - 5) * Math.Cos((i * step - 45) * Math.PI / 180);
                    linescale.Y2 = radius - (radius - 5) * Math.Sin((i * step - 45) * Math.PI / 180);
                    linescale.Stroke = LineShowColor;
                    linescale.StrokeThickness = 1;
                    TextBlock txt  = new TextBlock();
                    txt.Text = (-Math.Abs(MinValue) + i).ToString();
                    txt.FontSize = TextFontSize==0? 14:TextFontSize;
                    txt.Width = 30;
                    txt.TextAlignment = TextAlignment.Center;
                    txt.Foreground = TextForeGround;
                    Canvas.SetLeft(txt, radius - (radius - 36) * Math.Cos((i * step - 45) * Math.PI / 180)-17);
                    Canvas.SetTop(txt,radius - (radius - 36) * Math.Sin((i * step - 45) * Math.PI / 180)-10);
                    this.maincanvas.Children.Add(txt);
                }
                else
                {
                    linescale = new Line();
                    linescale.X1 = radius - (radius - 13) * Math.Cos((i * step - 45) * Math.PI / 180);
                    linescale.Y1 = radius - (radius - 13) * Math.Sin((i * step - 45) * Math.PI / 180);
                    linescale.X2 = radius - (radius - 5) * Math.Cos((i * step - 45) * Math.PI / 180);
                    linescale.Y2 = radius - (radius - 5) * Math.Sin((i * step - 45) * Math.PI / 180);
                    linescale.Stroke = LineShowColor;
                    linescale.StrokeThickness = 1;
                }
                this.maincanvas.Children.Add(linescale);
            }
            string sdata = $"M{radius/2} {radius} A{radius/2} {radius/2} 0 1 1 {radius} {radius*1.5}";
            var converter = TypeDescriptor.GetConverter(typeof(Geometry));
            this.pathname.Data= (Geometry)converter.ConvertFrom(sdata);


            var realoffsetvalue = Math.Abs(MinValue) / (double)(MaxValue - MinValue) * 270f;
            DoubleAnimation da = new DoubleAnimation((int)(this.Value * step) - 45 + realoffsetvalue, new Duration(TimeSpan.FromMilliseconds(300)));


            this.rtpointer.BeginAnimation(RotateTransform.AngleProperty, da);

            sdata = $"M{radius*0.2} {radius},{radius}  {radius-5},{radius} {radius+5}";
            this.Pointer.Data = (Geometry)converter.ConvertFrom(sdata);


        }
    }
}
