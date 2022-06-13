using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfIntro
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Button btn = new Button
            {
                Content = "Dynamic Button",
                Background = Brushes.DeepSkyBlue,
                FontSize = 28.0,
                BorderBrush = Brushes.Red,
                BorderThickness = new Thickness(3),
                Height = 300,
                Width = 300
            };


            // btn.Background = new SolidColorBrush(Color.FromRgb(120, 200, 120));
            grid.Children.Add(btn);


            // WindowState = WindowState.Minimized;
            // WindowState = WindowState.Maximized;
            // WindowState = WindowState.Normal;



            // Random.Shared.Next()
        }
    }
}
