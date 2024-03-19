using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void climatebtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            carico.ImageSource = new BitmapImage(new Uri("Img/car_def.png", UriKind.Relative));
            battaryico.ImageSource = new BitmapImage(new Uri("Img/bat_def.png", UriKind.Relative));
            climatico.ImageSource = new BitmapImage(new Uri("Img/climat_en.png", UriKind.Relative));
        }

        private void battarybtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CarControlG.Visibility= Visibility.Hidden;
            BatControlG.Visibility= Visibility.Visible;
            climatebtn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#22252c");
            catbtn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#22252c");
            battarybtn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#5e52d8");
            carico.ImageSource = new BitmapImage(new Uri("Img/car_def.png", UriKind.Relative));
            battaryico.ImageSource = new BitmapImage(new Uri("Img/bat_en.png", UriKind.Relative));
            climatico.ImageSource = new BitmapImage(new Uri("Img/climat_def.png", UriKind.Relative));
            
        }

        private void catbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CarControlG.Visibility = Visibility.Visible;
            BatControlG.Visibility = Visibility.Hidden;
            carico.ImageSource = new BitmapImage(new Uri("Img/car_en.png", UriKind.Relative));
            battaryico.ImageSource = new BitmapImage(new Uri("Img/bat_def.png", UriKind.Relative));
            climatico.ImageSource = new BitmapImage(new Uri("Img/climat_def.png", UriKind.Relative));
            catbtn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#5e52d8");
            climatebtn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#22252c");
            battarybtn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#22252c"); 


        }
    }
}
