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

namespace GetDateTimeFormat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var d1 = DateTime.Now;
            var str = $"_{d1.Year}{d1.Month}{d1.Month}.{d1.Hour}{d1.Minute}";

            TextBox1.Text = str;
            
            Clipboard.SetText(str);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var d1 = DateTime.Now;
            var str = $"_{d1.Year}{d1.Month}{d1.Month}.{d1.Hour}{d1.Minute}";

            TextBox1.Text = str;
            
            Clipboard.SetText(str);
        }
    }
}
