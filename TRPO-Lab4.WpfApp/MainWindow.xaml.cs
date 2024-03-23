using System.Windows;
using System.Windows.Controls;
using TRPO_Lab3.ClassLibrary;
using TRPO_Lab4.Wpf.ViewModels;

namespace TRPO_Lab4.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public VolumeOfTriangularPiramidViewModel ViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VolumeOfTriangularPiramidViewModel();
        }

    }
}