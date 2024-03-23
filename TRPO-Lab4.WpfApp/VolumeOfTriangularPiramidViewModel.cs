using System.ComponentModel;
using System.Windows;
using TRPO_Lab3.ClassLibrary;

namespace TRPO_Lab4.Wpf.ViewModels
{
    public class VolumeOfTriangularPiramidViewModel : INotifyPropertyChanged
    {
        private double a;
        private double h;
        private double s;

        public double side
        {
            get => a;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Сторона длолжна быть больше 0");
                    return;
                }

                a = value;
                OnPropertyChanged(nameof(side));
                Calc();
            }
        }

        public double height
        {
            get => h;
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Высота должна быть больше 0");
                    return;
                }

                h = value;
                OnPropertyChanged(nameof(height));
                Calc();
            }
        }

        public double Volume
        {
            get => s;
            set
            {
                s = value;
                OnPropertyChanged(nameof(Volume));
            }
        }

        public VolumeOfTriangularPiramidViewModel()
        {
            side = 1;
            height = 1;
        }

        private void Calc()
        {
            Volume = Square.Calc(side, height);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
