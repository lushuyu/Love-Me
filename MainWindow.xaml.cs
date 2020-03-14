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

namespace Love_Me
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rd = new Random();
            Button btn = sender as Button;
            double maxW = this.Width;
            double maxH = this.Height;
            double w = btn.Width;
            double h = btn.Height;
            double l = rd.Next(0, (int)(maxW - w));
            double t = rd.Next(0, (int)(maxH - h));
            btn.Margin = new Thickness(l, t, 0, 0);
        }

        private void closing_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("关不掉！");
            e.Cancel = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lab1.Visibility = System.Windows.Visibility.Hidden;
            lab2.Content = "谢谢媳妇！";
            btn3.Visibility = System.Windows.Visibility.Visible;
            btn1.Visibility = System.Windows.Visibility.Hidden;
            btn2.Visibility = System.Windows.Visibility.Hidden;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
