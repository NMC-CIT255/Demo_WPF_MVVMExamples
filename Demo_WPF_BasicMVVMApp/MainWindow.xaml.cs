using Microsoft.Win32;
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

namespace Demo_WPF_BasicMVVMApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ImageData _image;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ImageData();
        }

        //private void OnIsImageExist(object sender, CanExecuteRoutedEventArgs e)
        //{
        //    e.CanExecute = _image != null;
        //}

        //private void OnZoomIn(object sender, ExecutedRoutedEventArgs e)
        //{
        //    _image.Zoom *= 1.2;
        //}

        //private void OnZoomOut(object sender, ExecutedRoutedEventArgs e)
        //{
        //    _image.Zoom /= 1.2;
        //}

        //private void OnOpen(object sender, ExecutedRoutedEventArgs e)
        //{
        //    var dlg = new OpenFileDialog
        //    {
        //        Filter = "Image Flies|*.jpg; *.png; *.bmp; *.gif"
        //    };
        //    if (dlg.ShowDialog() == true)
        //    {
        //        _image = new ImageData(dlg.FileName);
        //        DataContext = _image;
        //    }
        //}

        //private void OnNormalZoom(object sender, ExecutedRoutedEventArgs e)
        //{
        //    _image.Zoom = 1;
        //}
    }
}
