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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        public int i = 0;
        public double s = 0;

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            TextBox txbNew = new TextBox();
            txbNew.HorizontalAlignment = HorizontalAlignment.Left;
            txbNew.VerticalAlignment = VerticalAlignment.Top;
            txbNew.Height = 23;
            txbNew.TextWrapping = TextWrapping.Wrap;
            txbNew.Text = "0";
            txbNew.Width = 120;
            txbNew.Margin = new Thickness(10, 44 + 28*i, 0, 0);
            gMain.Children.Add(txbNew);
            i++;
            s = 0;
            foreach (var chl in gMain.Children)
                if (chl is TextBox) s += double.Parse(((TextBox)chl).Text);
            label1.Content = s;
        }

        private void amount_Click(object sender, RoutedEventArgs e)
        {
            s = 0;
            foreach (var chl in gMain.Children)
                if (chl is TextBox) s += double.Parse(((TextBox)chl).Text);
            label1.Content = s;
        }
    }
}
